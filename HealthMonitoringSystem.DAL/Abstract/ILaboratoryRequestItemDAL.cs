// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- ILaboratoryRequestItemDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface ILaboratoryRequestItemDAL
    {
        LaboratoryRequestItem Select(int id);
        List<LaboratoryRequestItem> LaboratoryRequestItems(int requestId);
        bool Insert(LaboratoryRequestItem newLaboratoryRequestItem);
        bool Update(LaboratoryRequestItem newInfoLaboratoryRequestItem);
        bool Delete(int id);
    }
}