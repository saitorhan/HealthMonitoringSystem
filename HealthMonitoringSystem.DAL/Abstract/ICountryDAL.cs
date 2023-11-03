// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- ICountryDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface ICountryDAL
    {
        Country Select(int id);
        List<Country> Countries(int? cityId = null, bool? isActive = true);
        Extensions.DataBaseResult Insert(Country newCountry);
        Extensions.DataBaseResult Update(Country newInfoCountry);
        Extensions.DataBaseResult Delete(int id);
    }
}