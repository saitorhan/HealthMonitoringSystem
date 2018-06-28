// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- ILaboratoryItemUnitDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface ILaboratoryItemUnitDAL
    {
        LaboratoryItemUnit Select(int id);
        List<LaboratoryItemUnit> LaboratoryItemUnits(bool? isActive = true);
        bool Insert(LaboratoryItemUnit newLaboratoryItemUnit);
        bool Update(LaboratoryItemUnit newInfoLaboratoryItemUnit);
        bool Delete(int id);
    }
}