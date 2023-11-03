// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- CityManager.cs

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
    public class CityManager
    {
        private ICityDAL _cityDal;

        public CityManager()
        {
            _cityDal = new MsSqlCityDal();
        }

        public City Select(int id)
        {
            return _cityDal.Select(id);
        }

        public List<City> Cities(bool? isActive = true)
        {
            return _cityDal.Citys();
        }

        public ProcessResult Insert(City newCity)
        {
            ProcessResult result = VerifeyModel(newCity);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            Extensions.DataBaseResult insert = _cityDal.Insert(newCity);

            switch (insert)
            {
                case Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newCity.Name));
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

        public ProcessResult Update(City newInfoCity)
        {
            ProcessResult result = VerifeyModel(newInfoCity);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            Extensions.DataBaseResult update = _cityDal.Update(newInfoCity);

            switch (update)
            {
                case Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newInfoCity.Name));
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
            Extensions.DataBaseResult delete = _cityDal.Delete(id);
            switch (delete)
            {
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.Referanced:
                    result.Result = Extensions.BLLResult.Referanced;
                    result.Errors.Add("İl başka tablolar üzerinde refere edildiğinden silinemedi");
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


        private ProcessResult VerifeyModel(City c)
        {
            ProcessResult result = new ProcessResult();

            if (c.Name.Length == 0)
            {
                result.Errors.Add("Ad kısmı boş bırakılamaz");
            }

            result.Result = result.Errors.Count == 0 ? Extensions.BLLResult.Verified : Extensions.BLLResult.NotVerified;

            return result;
        }
    }
}