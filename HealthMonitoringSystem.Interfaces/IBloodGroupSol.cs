// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IBloodGroupSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IBloodGroupSol.cs
// 28 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (BloodGroup))]
    public interface IBloodGroupSol
    {
        [OperationContract]
        BloodGroup Select(int id);

        [OperationContract]
        List<BloodGroup> BloodGroups(bool? isActive = true);

        [OperationContract]
        bool Insert(BloodGroup newBloodGroup);

        [OperationContract]
        bool Update(BloodGroup newInfoBloodGroup);

        [OperationContract]
        bool Delete(int id);
    }
}