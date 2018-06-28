// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IDoctorSol.cs

#region usings

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Doctor))]
    [ServiceKnownType(typeof (Department))]
    [ServiceKnownType(typeof (Degree))]
    public interface IDoctorSol
    {
        [OperationContract]
        Doctor Select(int id);

        [OperationContract(Name = "SelectDoctorByTc")]
        Doctor Select(string tcNo);

        [OperationContract]
        List<Doctor> Doctors(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Doctor newDoctor);

        [OperationContract]
        ProcessResult Update(Doctor newInfoDoctor);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}