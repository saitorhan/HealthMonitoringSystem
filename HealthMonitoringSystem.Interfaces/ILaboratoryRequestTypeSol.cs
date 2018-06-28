// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- ILaboratoryRequestTypeSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - ILaboratoryRequestTypeSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (LaboratoryRequestType))]
    [ServiceKnownType(typeof (ILaboratoryItemUnitSol))]
    public interface ILaboratoryRequestTypeSol
    {
        [OperationContract]
        LaboratoryRequestType Select(int id);

        [OperationContract]
        List<LaboratoryRequestType> LaboratoryRequestTypes(bool? isActive = true);

        [OperationContract]
        bool Insert(LaboratoryRequestType newLaboratoryRequestType);

        [OperationContract]
        bool Update(LaboratoryRequestType newInfoLaboratoryRequestType);

        [OperationContract]
        bool Delete(int id);
    }
}