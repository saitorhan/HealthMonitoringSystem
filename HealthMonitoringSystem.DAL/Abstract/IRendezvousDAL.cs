// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IRendezvousDAL.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IRendezvousDAL
    {
        Rendezvous Select(int id);
        List<Rendezvous> Rendezvouses(DateTime time, int? doctorId, bool? isActive = true);
        Extensions.DataBaseResult Insert(ref Rendezvous newRendezvous);
        bool Update(Rendezvous newInfoRendezvous);
        Extensions.DataBaseResult Delete(int id);
    }
}