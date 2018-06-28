// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- ICountrySol.cs

#region usings

// HealthMonitoringSystem.Interfaces - ICountrySol.cs
// 28 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Country))]
    [ServiceKnownType(typeof (City))]
    public interface ICountrySol
    {
        [OperationContract]
        Country Select(int id);

        [OperationContract]
        List<Country> Countries(int? cityId = null, bool? isActive = true);

        [OperationContract(Name = "AllCountries")]
        List<Country> Countries(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Country newCountry);

        [OperationContract]
        ProcessResult Update(Country newInfoCountry);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}