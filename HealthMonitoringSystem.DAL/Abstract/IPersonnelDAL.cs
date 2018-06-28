// Sait ORHAN -- 02.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IPersonnelDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IPersonnelDAL
    {
        Personnel Select(int id);
        Personnel Select(string tc);
        List<Personnel> Personnels(bool? isActive = true);
        bool Insert(Personnel newPersonnel);
        bool Update(Personnel newInfoPersonnel);
        bool Delete(int id);
    }
}