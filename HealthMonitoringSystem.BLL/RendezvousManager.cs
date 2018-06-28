// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- RendezvousManager.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;
using Ninject;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class RendezvousManager : IRendezvousSol
    {
        private IRendezvousDAL _rendezvousDal;

        public RendezvousManager()
        {
            _rendezvousDal = new NinjectManager().CoreKernel.Get<IRendezvousDAL>();
        }

        public Rendezvous Select(int id)
        {
            return _rendezvousDal.Select(id);
        }

        public List<Rendezvous> Rendezvouses(DateTime time, int? doctorId, bool? isActive = true)
        {
            return _rendezvousDal.Rendezvouses(time, doctorId, isActive);
        }


        public ProcessResult Insert(Rendezvous newRendezvous, bool toExamination)
        {
            newRendezvous.IsActive = !toExamination;
            newRendezvous.Date = toExamination ? DateTime.Today : newRendezvous.Date;

            ProcessResult result = Verifyrendezvous(newRendezvous);
            if (result.Result != Extensions.BLLResult.Verified) return result;

            result = IsHoliday(newRendezvous.Date);
            if (result.Result != Extensions.BLLResult.Success) return result;

            result = IsExistOtherRendezvous(newRendezvous);
            if (result.Result == Extensions.BLLResult.AlreadyFound) return result;

            DAL.Extensions.DataBaseResult baseResult = _rendezvousDal.Insert(ref newRendezvous);

            switch (baseResult)
            {
                case DAL.Extensions.DataBaseResult.Error:
                    result.Errors.Add(Extensions.InnerException);
                    result.Result = Extensions.BLLResult.InnerException;
                    break;
                case DAL.Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case DAL.Extensions.DataBaseResult.Success:
                    break;
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    break;
                case DAL.Extensions.DataBaseResult.NotFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (toExamination)
            {
                DiagnosisManager diagnosisManager = new DiagnosisManager();
                Diagnosis diagnosis = diagnosisManager.GetDefaultDiagnosis();
                ExaminationManager manager = new ExaminationManager();
                manager.Insert(new Examination
                {
                    CanSendMessage = false, PatientId = newRendezvous.PatientId, DoctorId = newRendezvous.DoctorId, Time = newRendezvous.Date, RendezvousId = newRendezvous.Id, IsActive = true, DiagnosisId = diagnosis.Id
                });
            }

            result.Errors.Add(Extensions.SuccessProcess);
            result.Errors.Add(String.Format("Kayıt numarası: {0}", newRendezvous.Id));
            result.Result = Extensions.BLLResult.Success;
            return result;
        }

        private ProcessResult IsHoliday(DateTime date)
        {
            ProcessResult result = new ProcessResult();
            HolidayManager manager = new HolidayManager();
            List<Holiday> holidays = manager.Holidays();
            List<Holiday> list = holidays.Where(h => (h.Year == null || h.Year == date.Year) && h.Month == date.Month && h.Day == date.Day).ToList();
            result.Result = list.Count == 0 && date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday ? Extensions.BLLResult.Success : Extensions.BLLResult.NotVerified;
            if (result.Result == Extensions.BLLResult.Success) return result;
            result.Errors.Add(String.Format("Tatil günlerinde randevu alınamaz.\nDenk gelen tatiller:"));
            foreach (Holiday holiday in list)
            {
                result.Errors.Add(holiday.Name);
            }

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                result.Errors.Add("Hafta sonu");

            return result;
        }

        public bool Update(Rendezvous newInfoRendezvous)
        {
            return _rendezvousDal.Update(newInfoRendezvous);
        }

        public ProcessResult Delete(int id)
        {
            ProcessResult result = new ProcessResult();

            RendezvousManager rendezvousManager = new RendezvousManager();
            Rendezvous rendezvous = rendezvousManager.Select(id);
            ExaminationManager examinationManager = new ExaminationManager();
            foreach (Examination examination in
                examinationManager.Examinations(rendezvous.Date, rendezvous.DoctorId, null).Where(e => e.RendezvousId == id).ToList())
            {
                examinationManager.Delete(examination.Id);
            }

            switch (_rendezvousDal.Delete(id))
            {
                case DAL.Extensions.DataBaseResult.Success:
                    result.Errors.Add("Randevu silindi");
                    result.Result = Extensions.BLLResult.Success;
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    result.Errors.Add("Silinmeye çalışılan randevu muayene olduğundan randevu silinemedi.");
                    result.Result = Extensions.BLLResult.Referanced;
                    break;
                case DAL.Extensions.DataBaseResult.NotFound:
                    result.Errors.Add("Randevu bulunamadı");
                    result.Result = Extensions.BLLResult.NotFound;
                    break;
                case DAL.Extensions.DataBaseResult.Error:
                    result.Errors.Add("Randevu silinirken bir hata ile karşılaşıldı");
                    result.Result = Extensions.BLLResult.Error;
                    break;
                case DAL.Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return result;
        }

        public List<RendezvousInfo> RendezvousInfos()
        {
            List<RendezvousInfo> rendezvous = new List<RendezvousInfo>();

            RendezvousTimeManager timeManager = new RendezvousTimeManager();
            int times = timeManager.RendezvousTimes().Count;

            RendezvousManager rendezvousManager =new RendezvousManager();
            List<Rendezvous> savedRendezvous = rendezvousManager.Rendezvouses(DateTime.Today, null, null);

            DepartmentManager departmentManager = new DepartmentManager();
            List<Department> departments = departmentManager.Departments();

            foreach (Department department in departments)
            {
                RendezvousInfo info = new RendezvousInfo
                {
                    DepartmentName = department.Name, Max = times*department.Doctors.Count
                };

                foreach (Doctor doctor in department.Doctors)
                {
                    DoctorRenInfo doctorRenInfo = new DoctorRenInfo
                    {
                        DoctorName = String.Format("{0} {1}", doctor.Name, doctor.Surname)
                    };

                    int count = savedRendezvous.Count(r => r.DoctorId == doctor.Id);
                    doctorRenInfo.Limit = times - count;
                    info.Value += count;
                    info.DoctorRenInfos.Add(doctorRenInfo);
                }

                rendezvous.Add(info);
            }

            return rendezvous;
        }

        private ProcessResult IsExistOtherRendezvous(Rendezvous rendezvous)
        {
            ProcessResult result = new ProcessResult();

            DoctorManager doctorManager = new DoctorManager();
            Doctor doctor = doctorManager.Select(rendezvous.DoctorId);

            List<Doctor> doctors = doctorManager.Doctors();


            List<int> depDocList = doctors.Where(d => d.DepartmentId == doctor.DepartmentId).Select(d => d.Id).ToList();

            List<Rendezvous> rendezvouses = Rendezvouses(DateTime.Today, null, null);

            bool any = rendezvouses.Any(r => r.PatientId == rendezvous.PatientId && depDocList.Contains(r.DoctorId));
            if (any) result.Errors.Add("Hastanın aynı bölüme aynı güne zaten randevusu var");

            if (!any)
                foreach (Doctor _doctor in doctors)
                {
                    if (Rendezvouses(DateTime.Today, _doctor.Id, null).Any(p => p.PatientId == rendezvous.PatientId && p.RendezvousTimeId == rendezvous.RendezvousTimeId))
                    {
                        result.Errors.Add(String.Format("{0} {1} doktorunda aynı saatte randevu alınmış", _doctor.Name, _doctor.Surname));
                    }
                }

            result.Result = result.Errors.Count > 0 ? Extensions.BLLResult.AlreadyFound : Extensions.BLLResult.Success;
            return result;
        }

        private ProcessResult Verifyrendezvous(Rendezvous rendezvous)
        {
            ProcessResult result = new ProcessResult();
            DoctorManager doctorManager = new DoctorManager();
            Doctor doctor = doctorManager.Select(rendezvous.DoctorId);
            DepartmentManager departmentManager = new DepartmentManager();
            Department department = departmentManager.Select(doctor != null ? doctor.DepartmentId : 0);
            PatientManager patientManager = new PatientManager();
            Patient patient = patientManager.Select(rendezvous.PatientId);
            new RendezvousTimeManager();

            if (rendezvous.PatientId <= 0)
            {
                result.Errors.Add(String.Format("Hasta bilgisi olmadan randevu alınamaz"));
            }
            if (doctor == null || rendezvous.DoctorId <= 0)
            {
                result.Errors.Add(String.Format("Doktor bilgisi olmadan randevu alınamaz"));
            }
            if (rendezvous.RendezvousTimeId <= 0)
            {
                result.Errors.Add(String.Format("Randevu saati bilgisi olmadan randevu alınamaz"));
            }
            if (rendezvous.Date < DateTime.Today)
            {
                result.Errors.Add(String.Format("Geriye dönük tarihe randevu alınamaz"));
            }
            if (department != null)
            {
                if (patient != null)
                {
                    if (department.MinAge != null && department.MinAge > patient.GetAge())
                    {
                        result.Errors.Add(String.Format("{0} aylıktan küçükler {1} bölümüne gidemez. Hastanın yaşı {2} ay", department.MinAge, department.Name, patient.GetAge()));
                    }
                    if (department.MaxAge != null && department.MaxAge < patient.GetAge())
                    {
                        result.Errors.Add(String.Format("{0} aylıktan büyükler {1} bölümüne gidemez. Hastanın yaşı {2} ay", department.MaxAge, department.Name, patient.GetAge()));
                    }
                    if (department.Gender != null && department.Gender != patient.Gender)
                    {
                        result.Errors.Add(String.Format("{0} hastalar {1} bölümüne gidemez.", patient.Gender ? "Erkek" : "Kadın", department.Name));
                    }
                }
            }
            else
            {
                result.Errors.Add("Departman seçilmeden randevu alınamaz.");
            }

            result.Result = result.Errors.Count > 0 ? Extensions.BLLResult.NotVerified : Extensions.BLLResult.Verified;
            return result;
        }
    }
}