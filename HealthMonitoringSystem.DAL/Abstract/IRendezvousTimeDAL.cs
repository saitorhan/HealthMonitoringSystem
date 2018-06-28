// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IRendezvousTimeDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IRendezvousTimeDAL
    {
        RendezvousTime Select(int id);
        List<RendezvousTime> RendezvousTimes(bool? isActive = true);
        bool Insert(RendezvousTime newRendezvousTime);
        bool Update(RendezvousTime newInfoRendezvousTime);
        bool Delete(int id);
    }
}