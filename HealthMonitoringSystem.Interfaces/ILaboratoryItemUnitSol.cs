// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- ILaboratoryItemUnitSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - ILaboratoryItemUnitSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (LaboratoryItemUnit))]
    public interface ILaboratoryItemUnitSol
    {
        [OperationContract]
        LaboratoryItemUnit Select(int id);

        [OperationContract]
        List<LaboratoryItemUnit> LaboratoryItemUnits(bool? isActive = true);

        [OperationContract]
        bool Insert(LaboratoryItemUnit newLaboratoryItemUnit);

        [OperationContract]
        bool Update(LaboratoryItemUnit newInfoLaboratoryItemUnit);

        [OperationContract]
        bool Delete(int id);
    }
}