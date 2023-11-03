// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- DoctorManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.DAL.Content.MsSqlContent;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class DoctorManager 
    {
        private IDoctorDAL _doctorDal;

        public DoctorManager()
        {
            _doctorDal = new MsSqlDoctorDal();
        }

        public Doctor Select(int id)
        {
            return _doctorDal.Select(id);
        }

        public Doctor Select(string tcNo)
        {
            return _doctorDal.Select(tcNo);
        }

        public List<Doctor> Doctors(bool? isActive = true)
        {
            return _doctorDal.Doctors();
        }

        public ProcessResult Delete(int id)
        {
            ProcessResult result = new ProcessResult();

            Extensions.DataBaseResult delete = _doctorDal.Delete(id);
            switch (delete)
            {
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.Referanced:
                    result.Result = Extensions.BLLResult.Referanced;
                    result.Errors.Add("Doktor başka tablolar üzerinde refere edildiğinden silinemedi");
                    break;
                case Extensions.DataBaseResult.NotFound:
                    result.Result = Extensions.BLLResult.NotFound;
                    result.Errors.Add(Extensions.NotFound);
                    break;
                case Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case Extensions.DataBaseResult.AlreadyFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public ProcessResult Update(Doctor newInfoDoctor)
        {
            ProcessResult result = VerifeyModel(newInfoDoctor, true);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            Extensions.DataBaseResult insert = _doctorDal.Update(newInfoDoctor);

            switch (insert)
            {
                //case DAL.Extensions.DataBaseResult.AlreadyFound:
                //    result.Result = Extensions.BLLResult.AlreadyFound;
                //    result.Errors.Add(Extensions.AlreadyFoundString(newInfoDoctor.Name));
                //    break;
                case Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case Extensions.DataBaseResult.AlreadyFound:
                    break;
                case Extensions.DataBaseResult.Referanced:
                    break;
                case Extensions.DataBaseResult.NotFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public ProcessResult Insert(Doctor newDoctor)
        {
            ProcessResult result = VerifeyModel(newDoctor, false);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            newDoctor.Password = Char.ToLower(newDoctor.MotherName[0]) + newDoctor.TcNo.Substring(8) + Char.ToLower(newDoctor.FatherName[0]) + newDoctor.BirthDay.Day;

            Extensions.DataBaseResult insert = _doctorDal.Insert(newDoctor);

            switch (insert)
            {
                case Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newDoctor.Name + newDoctor.Surname));
                    break;
                case Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case Extensions.DataBaseResult.Referanced:
                    break;
                case Extensions.DataBaseResult.NotFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        private ProcessResult VerifeyModel(Doctor d, bool upd)
        {
            ProcessResult result = new ProcessResult();

            if (!Extensions.VerifyTC(d.TcNo))
            {
                result.Errors.Add("Kimlik numarası doğrulanmadı");
            }
            if (d.Name.Length == 0)
            {
                result.Errors.Add("Ad kısmı boş bırakılamaz");
            }
            if (d.Surname.Length == 0)
            {
                result.Errors.Add("Soyad kısmı boş bırakılamaz");
            }
            if (d.TcNo.Length != 11)
            {
                result.Errors.Add("Tc numarası hatalı");
            }
            if (d.RegistrationNumber.Length == 0)
            {
                result.Errors.Add("Sicil numarası kısmı boş bırakılamaz");
            }
            if (d.MotherName.Length == 0)
            {
                result.Errors.Add("Anne adı kısmı boş bırakılamaz");
            }
            if (d.FatherName.Length == 0)
            {
                result.Errors.Add("Baba adı kısmı boş bırakılamaz");
            }
            if (d.BirthDay > DateTime.Today)
            {
                result.Errors.Add("Doğum tarihi bugünden büyük olamaz");
            }
            if (d.DepartmentId <= 0)
            {
                result.Errors.Add("Departman kısmı boş bırakılamaz");
            }
            if (d.DegreeId <= 0)
            {
                result.Errors.Add("Ünvan kısmı boş bırakılamaz");
            }
            if (upd && d.Password.Trim().Length == 0)
            {
                result.Errors.Add("Şifre kısmı boş bırakılamaz");
            }
            result.Result = result.Errors.Count == 0 ? Extensions.BLLResult.Verified : Extensions.BLLResult.NotVerified;

            return result;
        }
    }
}