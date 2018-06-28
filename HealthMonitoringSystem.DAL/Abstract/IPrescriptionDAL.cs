// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IPrescriptionDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IPrescriptionDAL
    {
        Prescription Select(int id);
        List<Prescription> Prescriptions(bool? isActive = true);
        bool Insert(Prescription newPrescription);
        bool Update(Prescription newInfoPresciption);
        bool Delete(int id);
    }
}