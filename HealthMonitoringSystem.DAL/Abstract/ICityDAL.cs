// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- ICityDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface ICityDAL
    {
        City Select(int id);
        List<City> Citys(bool? isActive = true);
        Extensions.DataBaseResult Insert(City newCity);
        Extensions.DataBaseResult Update(City newInfoCity);
        Extensions.DataBaseResult Delete(int id);
    }
}