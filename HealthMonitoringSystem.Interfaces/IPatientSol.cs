// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IPatientSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IPatientSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Patient))]
    [ServiceKnownType(typeof (City))]
    [ServiceKnownType(typeof (Country))]
    [ServiceKnownType(typeof (BloodGroup))]
    public interface IPatientSol
    {
        [OperationContract]
        Patient Select(int id);

        [OperationContract(Name = "PatientByTc")]
        Patient Select(string Tc);

        [OperationContract]
        List<Patient> Patients(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Patient newPatient);

        [OperationContract]
        ProcessResult Update(Patient newInfoPatient);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}