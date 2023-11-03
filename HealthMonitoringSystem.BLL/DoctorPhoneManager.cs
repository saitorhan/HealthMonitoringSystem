// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- DoctorPhoneManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class DoctorPhoneManager 
    {
        private IDoctorPhoneDAL _doctorPhoneDal;

        public DoctorPhoneManager(IDoctorPhoneDAL doctorPhoneDal)
        {
            _doctorPhoneDal = doctorPhoneDal;
        }

        public DoctorPhone Select(int id)
        {
            return _doctorPhoneDal.Select(id);
        }

        public List<DoctorPhone> DoctorPhones(bool? isActive = true)
        {
            return _doctorPhoneDal.DoctorPhones();
        }

        public ProcessResult Insert(DoctorPhone newDoctorPhone)
        {
            ProcessResult result = VerifeyModel(newDoctorPhone);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            DAL.Extensions.DataBaseResult insert = _doctorPhoneDal.Insert(newDoctorPhone);

            switch (insert)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newDoctorPhone.Phone));
                    break;
                case DAL.Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case DAL.Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    break;
                case DAL.Extensions.DataBaseResult.NotFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public ProcessResult Update(DoctorPhone newInfoDoctorPhone)
        {
            ProcessResult result = VerifeyModel(newInfoDoctorPhone);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            DAL.Extensions.DataBaseResult insert = _doctorPhoneDal.Update(newInfoDoctorPhone);

            switch (insert)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newInfoDoctorPhone.Phone));
                    break;
                case DAL.Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case DAL.Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    break;
                case DAL.Extensions.DataBaseResult.NotFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public ProcessResult Delete(int id)
        {
            ProcessResult result = new ProcessResult();

            DAL.Extensions.DataBaseResult delete = _doctorPhoneDal.Delete(id);
            switch (delete)
            {
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    result.Result = Extensions.BLLResult.Referanced;
                    result.Errors.Add("DoktorPhone başka tablolar üzerinde refere edildiğinden silinemedi");
                    break;
                case DAL.Extensions.DataBaseResult.NotFound:
                    result.Result = Extensions.BLLResult.NotFound;
                    result.Errors.Add(Extensions.NotFound);
                    break;
                case DAL.Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
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

        private ProcessResult VerifeyModel(DoctorPhone d)
        {
            ProcessResult result = new ProcessResult();

            if (d.Phone.Length == 0)
            {
                result.Errors.Add("Telefon numarası kısmı boş bırakılamaz");
            }

            result.Result = result.Errors.Count == 0 ? Extensions.BLLResult.Verified : Extensions.BLLResult.NotVerified;

            return result;
        }
    }
}