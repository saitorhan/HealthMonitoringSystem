// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IPrescriptionItemSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IPrescriptionItemSol.cs
// 28 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (PrescriptionItem))]
    [ServiceKnownType(typeof (Prescription))]
    [ServiceKnownType(typeof (Medicament))]
    public interface IPrescriptionItemSol
    {
        [OperationContract]
        PrescriptionItem Select(int id);

        [OperationContract]
        List<PrescriptionItem> PrescriptionItems(int presId, bool? isActive = true);

        [OperationContract]
        bool Insert(PrescriptionItem newPrescriptionItem);

        [OperationContract]
        bool Update(PrescriptionItem newInfoPresciptionItem);

        [OperationContract]
        bool Delete(int id);
    }
}