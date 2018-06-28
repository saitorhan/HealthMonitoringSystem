// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- ILaboratoryRequestSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - ILaboratoryRequestSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (LaboratoryRequest))]
    [ServiceKnownType(typeof (Examination))]
    public interface ILaboratoryRequestSol
    {
        [OperationContract]
        LaboratoryRequest Select(int id);

        [OperationContract]
        List<LaboratoryRequest> LaboratoryRequests(int examinationId, bool? isActive = true);

        [OperationContract]
        bool Insert(LaboratoryRequest newLaboratoryRequest);

        [OperationContract]
        bool Update(LaboratoryRequest newInfoLaboratoryRequest);

        [OperationContract]
        bool Delete(int id);

        [OperationContract]
        bool ActiveService();
    }
}