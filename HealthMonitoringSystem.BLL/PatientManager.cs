// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- PatientManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;
using Ninject;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class PatientManager 
    {
        private IPatientDAL _patientDal;

        public PatientManager()
        {
            _patientDal = new NinjectManager().CoreKernel.Get<IPatientDAL>();
        }

        public Patient Select(int id)
        {
            return _patientDal.Select(id);
        }

        public Patient Select(string Tc)
        {
            return _patientDal.Select(Tc);
        }

        public List<Patient> Patients(bool? isActive = true)
        {
            return _patientDal.Patients();
        }

        public ProcessResult Insert(Patient newPatient)
        {
            ProcessResult result = ValidateModel(newPatient, false);
            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            newPatient.Password = Char.ToLower(newPatient.MotherName[0]) + newPatient.TcNo.Substring(8) +
                                  Char.ToLower(newPatient.FatherName[0]) +
                                  newPatient.BirthDay.Day;

            Extensions.DataBaseResult insert = _patientDal.Insert(newPatient);
            switch (insert)
            {
                case Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(
                        Extensions.AlreadyFoundString(String.Format("{0} kimlik numaralı {1} {2}", newPatient.TcNo,
                            newPatient.Name, newPatient.Surname)));
                    break;
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
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

        public ProcessResult Update(Patient newInfoPatient)
        {
            ProcessResult processResult = ValidateModel(newInfoPatient, true);
            if (processResult.Result != Extensions.BLLResult.Verified)
                return processResult;
            Patient patient = Select(newInfoPatient.TcNo);
            if (patient != null && patient.Id != newInfoPatient.Id)
            {
                processResult.Errors.Add("Girilen kimlik numarasıyla başka bir hasta kaydı zaten bulunmaktadır");
                processResult.Result = Extensions.BLLResult.AlreadyFound;
                return processResult;
            }
            Extensions.DataBaseResult result = _patientDal.Update(newInfoPatient);

            switch (result)
            {
                case Extensions.DataBaseResult.Success:
                    processResult.Result = Extensions.BLLResult.Success;
                    processResult.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.Error:
                    processResult.Errors.Add(Extensions.InnerException);
                    processResult.Result = Extensions.BLLResult.Error;
                    break;
                case Extensions.DataBaseResult.NotFound:
                    processResult.Errors.Add(Extensions.NotFound);
                    processResult.Result = Extensions.BLLResult.NotFound;
                    break;
                case Extensions.DataBaseResult.ServerDisable:
                    processResult.Result = Extensions.BLLResult.ServerDisable;
                    processResult.Errors.Add(Extensions.ServerDisable);
                    break;
                case Extensions.DataBaseResult.AlreadyFound:
                    break;
                case Extensions.DataBaseResult.Referanced:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return processResult;
        }

        public ProcessResult Delete(int id)
        {
            ProcessResult processResult = new ProcessResult();
            Extensions.DataBaseResult result = _patientDal.Delete(id);
            switch (result)
            {
                case Extensions.DataBaseResult.Success:
                    processResult.Result = Extensions.BLLResult.Success;
                    processResult.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.Referanced:
                    processResult.Result = Extensions.BLLResult.Referanced;
                    processResult.Errors.Add("Silinmeye çalışılan hasta başka işlemlerle ilişkili olduğundan silinemedi");
                    break;
                case Extensions.DataBaseResult.NotFound:
                    processResult.Result = Extensions.BLLResult.NotFound;
                    processResult.Errors.Add(Extensions.NotFound);
                    break;
                case Extensions.DataBaseResult.Error:
                    processResult.Result = Extensions.BLLResult.InnerException;
                    processResult.Errors.Add(Extensions.InnerException);
                    break;
                case Extensions.DataBaseResult.ServerDisable:
                    processResult.Result = Extensions.BLLResult.ServerDisable;
                    processResult.Errors.Add(Extensions.ServerDisable);
                    break;
                case Extensions.DataBaseResult.AlreadyFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return processResult;
        }

        private ProcessResult ValidateModel(Patient patient, bool upd)
        {
            ProcessResult processResult = new ProcessResult();

            if (patient.Name.Trim().Length > 50)
            {
                processResult.Errors.Add("İsim alanı 50 karakterden uzun olamaz");
            }
            if (!Extensions.VerifyTC(patient.TcNo))
            {
                processResult.Errors.Add("Kimlik numarası doğrulanmadı");
            }
            if (patient.Name.Trim().Length == 0)
            {
                processResult.Errors.Add("İsim alanı boş bırakılamaz");
            }
            if (patient.Surname.Trim().Length == 0)
            {
                processResult.Errors.Add("Soyadı alanı boş bırakılamaz");
            }
            if (patient.FatherName.Trim().Length == 0)
            {
                processResult.Errors.Add("Baba adı alanı boş bırakılamaz");
            }
            if (patient.MotherName.Trim().Length == 0)
            {
                processResult.Errors.Add("Anne alanı boş bırakılamaz");
            }
            if (patient.Address.Trim().Length == 0)
            {
                processResult.Errors.Add("Adres alanı boş bırakılamaz");
            }
            if (patient.CityId <= 0)
            {
                processResult.Errors.Add("Şehir alanı boş bırakılamaz");
            }
            if (patient.CountryId <= 0)
            {
                processResult.Errors.Add("İlçe alanı boş bırakılamaz");
            }
            if (patient.Phone.Length == 0)
            {
                processResult.Errors.Add("Telefon alanı boş bırakılamaz");
            }
            if (patient.Mail.Length == 0)
            {
                processResult.Errors.Add("Mail alanı boş bırakılamaz");
            }
            if (patient.BirthDay > DateTime.Today)
            {
                processResult.Errors.Add("Doğum tarihi bugünün tarihinden sonra olamaz");
            }
            if (patient.BloodGroupId <= 0)
            {
                processResult.Errors.Add("Kan grubu alanı boş bırakılamaz");
            }
            if (upd && patient.Password.Length == 0)
            {
                processResult.Errors.Add("Şifre alanı boş bırakılamaz");
            }

            processResult.Result = processResult.Errors.Count == 0 ? Extensions.BLLResult.Verified : Extensions.BLLResult.NotVerified;
            return processResult;
        }
    }
}