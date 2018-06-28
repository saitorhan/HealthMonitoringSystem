// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- ILaboratoryRequestTypeDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface ILaboratoryRequestTypeDAL
    {
        LaboratoryRequestType Select(int id);
        List<LaboratoryRequestType> LaboratoryRequestTypes(bool? isActive = true);
        bool Insert(LaboratoryRequestType newLaboratoryRequestType);
        bool Update(LaboratoryRequestType newInfoLaboratoryRequestType);
        bool Delete(int id);
    }
}