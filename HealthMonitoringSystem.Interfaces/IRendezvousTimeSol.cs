// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IRendezvousTimeSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IRendezvousTimeSol.cs
// 30 / 09 / 2014

using System;
using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (RendezvousTime))]
    public interface IRendezvousTimeSol
    {
        [OperationContract]
        RendezvousTime Select(int id);

        [OperationContract]
        List<RendezvousTime> RendezvousTimes(bool? isActive = true);

        [OperationContract]
        List<RendezvousTime> AvailableRendezvousTimes(DateTime time, int doctorId);

        [OperationContract]
        bool Insert(RendezvousTime newRendezvousTime);

        [OperationContract]
        bool Update(RendezvousTime newInfoRendezvousTime);

        [OperationContract]
        bool Delete(int id);
    }
}