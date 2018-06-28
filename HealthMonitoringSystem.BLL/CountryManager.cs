// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- CountryManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class CountryManager : ICountrySol
    {
        private ICountryDAL _countryDal;

        public CountryManager(ICountryDAL countryDal)
        {
            _countryDal = countryDal;
        }

        public Country Select(int id)
        {
            return _countryDal.Select(id);
        }

        public List<Country> Countries(int? cityId = null, bool? isActive = true)
        {
            return _countryDal.Countries(cityId, isActive);
        }

        public List<Country> Countries(bool? isActive)
        {
            return Countries(null, isActive);
        }

        public ProcessResult Insert(Country newCountry)
        {
            ProcessResult result = VerifeyModel(newCountry);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            DAL.Extensions.DataBaseResult insert = _countryDal.Insert(newCountry);

            switch (insert)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newCountry.Name));
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

        public ProcessResult Update(Country newInfoCountry)
        {
            ProcessResult result = VerifeyModel(newInfoCountry);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            DAL.Extensions.DataBaseResult insert = _countryDal.Update(newInfoCountry);

            switch (insert)
            {
                //case DAL.Extensions.DataBaseResult.AlreadyFound:
                //    result.Result = Extensions.BLLResult.AlreadyFound;
                //    result.Errors.Add(Extensions.AlreadyFoundString(newInfoCountry.Name));
                //    break;
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
                case DAL.Extensions.DataBaseResult.AlreadyFound:
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
            DAL.Extensions.DataBaseResult delete = _countryDal.Delete(id);
            switch (delete)
            {
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    result.Result = Extensions.BLLResult.Referanced;
                    result.Errors.Add("İlçe başka tablolar üzerinde refere edildiğinden silinemedi");
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


        private ProcessResult VerifeyModel(Country c)
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