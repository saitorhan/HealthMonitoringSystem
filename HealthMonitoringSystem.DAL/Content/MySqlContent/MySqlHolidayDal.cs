// Sait ORHAN -- 11.01.2015 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlHolidayDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlHolidayDal : IHolidayDAL
    {
        public Holiday Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.Holidays.FirstOrDefault(d => d.Id == id);
            }
        }

        public List<Holiday> Holidays()
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.Holidays.ToList();
            }
        }

        public Extensions.DataBaseResult Insert(Holiday newHoliday)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Holidays.Any(d => d.Name == newHoliday.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }

                ctx.Holidays.Add(newHoliday);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(Holiday newInfoHoliday)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Holidays.Any(d => d.Name == newInfoHoliday.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }

                Holiday holiday = ctx.Holidays.FirstOrDefault(b => b.Id == newInfoHoliday.Id);

                if (holiday == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                holiday.Name = newInfoHoliday.Name;
                holiday.Year = newInfoHoliday.Year;
                holiday.Month = newInfoHoliday.Month;
                holiday.Day = newInfoHoliday.Day;
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                Holiday holiday = ctx.Holidays.FirstOrDefault(c => c.Id == id);
                if (holiday == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                ctx.Holidays.Remove(holiday);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}