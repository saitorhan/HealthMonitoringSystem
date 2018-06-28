// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IPrescriptionSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IPrescriptionSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Prescription))]
    [ServiceKnownType(typeof (Examination))]
    public interface IPrescriptionSol
    {
        [OperationContract]
        Prescription Select(int id);

        [OperationContract]
        List<PrescriptionItem> GetPrescriptionItems(int examId);

        [OperationContract]
        List<Prescription> Prescriptions(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Prescription newPrescription);

        [OperationContract]
        bool Update(Prescription newInfoPresciption);

        [OperationContract]
        bool Delete(int id);
    }
}