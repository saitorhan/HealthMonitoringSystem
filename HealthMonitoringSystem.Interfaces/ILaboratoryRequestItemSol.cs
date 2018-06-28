// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- ILaboratoryRequestItemSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - ILaboratoryRequestItemSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (LaboratoryRequestItem))]
    [ServiceKnownType(typeof (LaboratoryRequest))]
    [ServiceKnownType(typeof (LaboratoryRequestType))]
    public interface ILaboratoryRequestItemSol
    {
        [OperationContract]
        LaboratoryRequestItem Select(int id);

        [OperationContract]
        List<LaboratoryRequestItem> LaboratoryRequestItems(int requestId);

        [OperationContract]
        bool Insert(LaboratoryRequestItem newLaboratoryRequestItem);

        [OperationContract]
        bool Update(LaboratoryRequestItem newInfoLaboratoryRequestItem);

        [OperationContract]
        bool Delete(int id);

        [OperationContract]
        bool ActiveService();
    }
}