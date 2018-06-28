// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IDoctorPhoneSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IDoctorPhoneSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (DoctorPhone))]
    [ServiceKnownType(typeof (Doctor))]
    public interface IDoctorPhoneSol
    {
        [OperationContract]
        DoctorPhone Select(int id);

        [OperationContract]
        List<DoctorPhone> DoctorPhones(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(DoctorPhone newDoctorPhone);

        [OperationContract]
        ProcessResult Update(DoctorPhone newInfoDoctorPhone);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}