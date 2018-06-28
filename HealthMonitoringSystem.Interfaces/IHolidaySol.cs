// Sait ORHAN -- 11.01.2015 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IHolidaySol.cs

#region usings

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Holiday))]
    public interface IHolidaySol
    {
        [OperationContract]
        Holiday Select(int id);

        [OperationContract]
        List<Holiday> Holidays();

        [OperationContract]
        ProcessResult Insert(Holiday newHoliday, int holidayLenght, bool everyYear);

        [OperationContract]
        ProcessResult Update(Holiday newInfoHoliday);

        [OperationContract]
        ProcessResult Delete(int id);

        [OperationContract]
        bool IsHolidayDay(Holiday holiday);
    }
}