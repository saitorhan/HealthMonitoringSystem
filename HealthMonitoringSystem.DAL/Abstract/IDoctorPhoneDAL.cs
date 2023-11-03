// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IDoctorPhoneDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IDoctorPhoneDAL
    {
        DoctorPhone Select(int id);
        List<DoctorPhone> DoctorPhones(bool? isActive = true);
        Extensions.DataBaseResult Insert(DoctorPhone newDoctorPhone);
        Extensions.DataBaseResult Update(DoctorPhone newInfoDoctorPhone);
        Extensions.DataBaseResult Delete(int id);
    }
}