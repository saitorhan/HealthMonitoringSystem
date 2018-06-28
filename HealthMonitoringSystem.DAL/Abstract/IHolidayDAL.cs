// Sait ORHAN -- 11.01.2015 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IHolidayDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IHolidayDAL
    {
        Holiday Select(int id);
        List<Holiday> Holidays();
        Extensions.DataBaseResult Insert(Holiday newHoliday);
        Extensions.DataBaseResult Update(Holiday newInfoHoliday);
        Extensions.DataBaseResult Delete(int id);
    }
}