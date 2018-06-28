// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IPrescriptionItemDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IPrescriptionItemDAL
    {
        PrescriptionItem Select(int id);
        List<PrescriptionItem> PrescriptionItems(int presId, bool? isActive = true);
        bool Insert(PrescriptionItem newPrescriptionItem);
        bool Update(PrescriptionItem newInfoPresciptionItem);
        bool Delete(int id);
    }
}