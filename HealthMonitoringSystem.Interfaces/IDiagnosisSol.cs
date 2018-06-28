// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IDiagnosisSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IDiagnosisSol.cs
// 28 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Diagnosis))]
    [ServiceKnownType(typeof (Department))]
    public interface IDiagnosisSol
    {
        [OperationContract]
        Diagnosis Select(int id);

        [OperationContract(Name = "SelectByName")]
        Diagnosis Select(string Name);

        [OperationContract]
        List<Diagnosis> Diagnoses(int? departmentId, bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Diagnosis newDiagnosis);

        [OperationContract]
        ProcessResult Update(Diagnosis newInfoDiagnosis);

        [OperationContract]
        ProcessResult Delete(int id);

        [OperationContract]
        bool ActiveService();
    }
}