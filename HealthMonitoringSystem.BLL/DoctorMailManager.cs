// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- DoctorMailManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class DoctorMailManager : IDoctorMailSol
    {
        private IDoctorMailDAL _doctorMailDal;

        public DoctorMailManager(IDoctorMailDAL doctorMailDal)
        {
            _doctorMailDal = doctorMailDal;
        }

        public DoctorMail Select(int id)
        {
            return _doctorMailDal.Select(id);
        }

        public List<DoctorMail> DoctorMails(bool? isActive = true)
        {
            return _doctorMailDal.DoctorMails();
        }

        public ProcessResult Insert(DoctorMail newDoctorMail)
        {
            ProcessResult result = VerifeyModel(newDoctorMail);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            DAL.Extensions.DataBaseResult insert = _doctorMailDal.Insert(newDoctorMail);

            switch (insert)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newDoctorMail.Mail));
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

        public ProcessResult Update(DoctorMail newInfoDoctorMail)
        {
            ProcessResult result = VerifeyModel(newInfoDoctorMail);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            DAL.Extensions.DataBaseResult insert = _doctorMailDal.Update(newInfoDoctorMail);

            switch (insert)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newInfoDoctorMail.Mail));
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

            DAL.Extensions.DataBaseResult delete = _doctorMailDal.Delete(id);
            switch (delete)
            {
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    result.Result = Extensions.BLLResult.Referanced;
                    result.Errors.Add("DoktorMail başka tablolar üzerinde refere edildiğinden silinemedi");
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

        private ProcessResult VerifeyModel(DoctorMail d)
        {
            ProcessResult result = new ProcessResult();

            if (d.Mail.Length == 0)
            {
                result.Errors.Add("Mail kısmı boş bırakılamaz");
            }

            result.Result = result.Errors.Count == 0 ? Extensions.BLLResult.Verified : Extensions.BLLResult.NotVerified;

            return result;
        }
    }
}