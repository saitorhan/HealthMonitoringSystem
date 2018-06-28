// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IRendezvousSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IRendezvousSol.cs
// 30 / 09 / 2014

using System;
using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Rendezvous))]
    [ServiceKnownType(typeof (RendezvousTime))]
    [ServiceKnownType(typeof (Patient))]
    [ServiceKnownType(typeof (Doctor))]
    [ServiceKnownType(typeof (RendezvousInfo))]
    [ServiceKnownType(typeof (DoctorRenInfo))]
    public interface IRendezvousSol
    {
        [OperationContract]
        Rendezvous Select(int id);

        [OperationContract]
        List<Rendezvous> Rendezvouses(DateTime time, int? doctorId, bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Rendezvous newRendezvous, bool toExamination);

        [OperationContract]
        bool Update(Rendezvous newInfoRendezvous);

        [OperationContract]
        ProcessResult Delete(int id);

        [OperationContract]
        List<RendezvousInfo> RendezvousInfos();
    }
}