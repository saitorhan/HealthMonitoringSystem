// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfCountryDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlCountryDal : ICountryDAL
    {
        public Country Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.Countries.Include("City").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<Country> Countries(int? cityId = null, bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                return
                    ctx.Countries.Include("City")
                        .Where(
                            c => (isActive == null || c.IsActive == isActive) && (cityId == null || c.CityId == cityId))
                        .ToList();
            }
        }

        public Extensions.DataBaseResult Insert(Country newCountry)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Countries.Any(d => d.Name == newCountry.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                ctx.Countries.Add(newCountry);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(Country newInfoCountry)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Countries.Any(d => d.Name == newInfoCountry.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                Country country = ctx.Countries.FirstOrDefault(c => c.Id == newInfoCountry.Id);

                if (country == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                country.Name = newInfoCountry.Name;
                country.CityId = newInfoCountry.CityId;
                country.IsActive = newInfoCountry.IsActive;
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Delete(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                Country country = ctx.Countries.FirstOrDefault(c => c.Id == id);
                if (country == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                bool b = ctx.Patients.Any(d => d.CountryId == id);

                if (b)
                {
                    return Extensions.DataBaseResult.Referanced;
                }
                ctx.Countries.Remove(country);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}