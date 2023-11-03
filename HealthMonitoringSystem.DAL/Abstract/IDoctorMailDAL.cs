// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IDoctorMailDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IDoctorMailDAL
    {
        DoctorMail Select(int id);
        List<DoctorMail> DoctorMails(bool? isActive = true);
        Extensions.DataBaseResult Insert(DoctorMail newDoctorMail);
        Extensions.DataBaseResult Update(DoctorMail newInfoDoctorMail);
        Extensions.DataBaseResult Delete(int id);
    }
}