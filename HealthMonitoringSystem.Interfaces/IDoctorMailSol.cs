// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IDoctorMailSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IDoctorMailSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (DoctorMail))]
    [ServiceKnownType(typeof (Doctor))]
    public interface IDoctorMailSol
    {
        [OperationContract]
        DoctorMail Select(int id);

        [OperationContract]
        List<DoctorMail> DoctorMails(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(DoctorMail newDoctorMail);

        [OperationContract]
        ProcessResult Update(DoctorMail newInfoDoctorMail);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}