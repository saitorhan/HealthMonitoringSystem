// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- DegreeManager.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class DegreeManager
    {
        private IDegreeDAL _degreeDal;

        public DegreeManager(IDegreeDAL degreeDal)
        {
            _degreeDal = degreeDal;
        }

        public Degree Select(int id)
        {
            return _degreeDal.Select(id);
        }

        public List<Degree> Degrees(bool? isActive = true)
        {
            return _degreeDal.Degrees();
        }

        public ProcessResult Insert(Degree newDegree)
        {
            ProcessResult result = ValidateModel(newDegree);
            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            result.Errors.Clear();

            Extensions.DataBaseResult insert = _degreeDal.Insert(newDegree);

            switch (insert)
            {
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newDegree.Name));
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

        public ProcessResult Update(Degree newInfoDegree)
        {
            ProcessResult result = ValidateModel(newInfoDegree);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            Extensions.DataBaseResult insert = _degreeDal.Update(newInfoDegree);

            switch (insert)
            {
                case Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newInfoDegree.Name));
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

        public ProcessResult Delete(int id)
        {
            ProcessResult result = new ProcessResult();
            Extensions.DataBaseResult delete = _degreeDal.Delete(id);
            switch (delete)
            {
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.Referanced:
                    result.Result = Extensions.BLLResult.Referanced;
                    result.Errors.Add("Ünvan başka tablolar üzerinde refere edildiğinden silinemedi");
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

        private ProcessResult ValidateModel(Degree degree)
        {
            ProcessResult result = new ProcessResult();

            if (String.IsNullOrEmpty(degree.Name))
            {
                result.Errors.Add("İsim boş bırakılamaz.");
            }
            if (String.IsNullOrEmpty(degree.ShortName))
            {
                result.Errors.Add("Kısa adı boş bırakılamaz.");
            }
            if (degree.Name.Length > 30)
            {
                result.Errors.Add("İsim alanı 30 karakterden uzun olamaz");
            }
            if (degree.ShortName.Length > 10)
            {
                result.Errors.Add("İsim alanı 10 karakterden uzun olamaz");
            }
            result.Result = !result.Errors.Any() ? Extensions.BLLResult.Verified : Extensions.BLLResult.NotVerified;
            return result;
        }
    }
}