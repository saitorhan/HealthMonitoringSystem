// Sait ORHAN -- 11.01.2015 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- HolidayManager.cs

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
    public class HolidayManager 
    {
        private IHolidayDAL holidayDal;

        public HolidayManager()
        {
            holidayDal = new NinjectManager().CoreKernel.Get<IHolidayDAL>();
        }

        public Holiday Select(int id)
        {
            return holidayDal.Select(id);
        }

        public List<Holiday> Holidays()
        {
            return holidayDal.Holidays();
        }

        public ProcessResult Insert(Holiday newHoliday, int holidayLenght, bool everyYear)
        {
            newHoliday.Year = everyYear ? null : newHoliday.Year;
            newHoliday.Name = newHoliday.Name.Trim();
            ProcessResult result = VelidateModel(newHoliday);
            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }
            DAL.Extensions.DataBaseResult insert = DAL.Extensions.DataBaseResult.Error;

            if (holidayLenght == 1)
            {
                insert = holidayDal.Insert(newHoliday);
            }
            else
            {
                for (int i = 1; i <= holidayLenght; i++)
                {
                    DateTime time = new DateTime(newHoliday.Year ?? 1, newHoliday.Month, newHoliday.Day).AddDays(i - 1);
                    insert = holidayDal.Insert(new Holiday
                    {
                        Name = String.Format("{0} {1}. Gün", newHoliday.Name, i),
                        Year = newHoliday.Year == null ? (int?) null : time.Year,
                        Month = time.Month,
                        Day = time.Day
                    });
                }
            }

            switch (insert)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newHoliday.Name));
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

        private ProcessResult VelidateModel(Holiday holiday)
        {
            ProcessResult result = new ProcessResult();
            if (holiday.Name.Length == 0)
            {
                result.Errors.Add("Tatil ismi boş bırakılmaz");
            }
            try
            {
                DateTime time = new DateTime(holiday.Year ?? 1, holiday.Month, holiday.Day);
            }
            catch (Exception)
            {
                result.Errors.Add("Hatalı tarih girişi yapıldı");
            }
            result.Result = result.Errors.Count == 0 ? Extensions.BLLResult.Verified : Extensions.BLLResult.NotVerified;
            return result;
        }

        public ProcessResult Update(Holiday newInfoHoliday)
        {
            newInfoHoliday.Name = newInfoHoliday.Name.Trim();
            ProcessResult result = new ProcessResult();
            DAL.Extensions.DataBaseResult update = holidayDal.Update(newInfoHoliday);

            switch (update)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newInfoHoliday.Name));
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
            DAL.Extensions.DataBaseResult delete = holidayDal.Delete(id);

            ProcessResult result = new ProcessResult();
            switch (delete)
            {
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
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
                case DAL.Extensions.DataBaseResult.Referanced:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public bool IsHolidayDay(Holiday holiday)
        {
            List<Holiday> holidays = Holidays();
            return holidays.Any(h => h.Year == holiday.Year && h.Month == holiday.Month && h.Day == holiday.Day);
        }
    }
}