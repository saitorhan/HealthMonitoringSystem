// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- ICitySol.cs

#region usings

// HealthMonitoringSystem.Interfaces - ICitySol.cs
// 28 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (City))]
    public interface ICitySol
    {
        [OperationContract]
        City Select(int id);

        [OperationContract]
        List<City> Cities(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(City newCity);

        [OperationContract]
        ProcessResult Update(City newInfoCity);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}