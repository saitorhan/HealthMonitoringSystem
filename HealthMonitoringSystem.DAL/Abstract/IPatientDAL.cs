// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IPatientDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IPatientDAL
    {
        Patient Select(int id);
        List<Patient> Patients(bool? isActive = true);
        Extensions.DataBaseResult Insert(Patient newPatient);
        Extensions.DataBaseResult Update(Patient newInfoPatient);
        Extensions.DataBaseResult Delete(int id);
        Patient Select(string tc);
    }
}