// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IDegreeDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IDegreeDAL
    {
        Degree Select(int id);
        List<Degree> Degrees(bool? isActive = true);
        Extensions.DataBaseResult Insert(Degree newDegree);
        Extensions.DataBaseResult Update(Degree newInfoDegree);
        Extensions.DataBaseResult Delete(int id);
    }
}