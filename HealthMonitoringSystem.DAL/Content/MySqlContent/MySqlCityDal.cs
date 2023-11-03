﻿// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlCityDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlCityDal : ICityDAL
    {
        public City Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.Cities.FirstOrDefault(d => d.Id == id);
            }
        }

        public List<City> Citys(bool? isActive = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.Cities.Where(c => isActive == null || c.IsActive == isActive).ToList();
            }
        }

        public Extensions.DataBaseResult Insert(City newCity)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Cities.Any(d => d.Name == newCity.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                ctx.Cities.Add(newCity);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(City newInfoCity)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Cities.Any(d => d.Name == newInfoCity.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                City city = ctx.Cities.FirstOrDefault(b => b.Id == newInfoCity.Id);

                if (city == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                city.Name = newInfoCity.Name;
                city.IsActive = newInfoCity.IsActive;
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

                City city = ctx.Cities.FirstOrDefault(c => c.Id == id);
                if (city == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                bool b = ctx.Countries.Any(d => d.CityId == id) || ctx.Patients.Any(d => d.CityId == id);
                if (b)
                {
                    return Extensions.DataBaseResult.Referanced;
                }
                ctx.Cities.Remove(city);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}