// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IBloodGroupDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IBloodGroupDAL
    {
        BloodGroup Select(int id);
        List<BloodGroup> BloodGroups(bool? isActive = true);
        bool Insert(BloodGroup newBloodGroup);
        bool Update(BloodGroup newInfoBloodGroup);
        bool Delete(int id);
    }
}