// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- ILaboratoryRequestDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface ILaboratoryRequestDAL
    {
        LaboratoryRequest Select(int id);
        List<LaboratoryRequest> LaboratoryRequests(int examinationId, bool? isActive = true);
        bool Insert(LaboratoryRequest newLaboratoryRequest);
        bool Update(LaboratoryRequest newInfoLaboratoryRequest);
        bool Delete(int id);
    }
}