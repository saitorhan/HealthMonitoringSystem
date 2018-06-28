// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IDoctorDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IDoctorDAL
    {
        Doctor Select(int id);
        Doctor Select(string tcNo);
        List<Doctor> Doctors(bool? isActive = true, bool includeDetails = true);
        Extensions.DataBaseResult Insert(Doctor newDoctor);
        Extensions.DataBaseResult Update(Doctor newInfoDoctor);
        Extensions.DataBaseResult Delete(int id);
    }
}