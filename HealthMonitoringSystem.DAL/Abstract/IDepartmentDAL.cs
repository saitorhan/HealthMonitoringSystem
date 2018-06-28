// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IDepartmentDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IDepartmentDAL
    {
        Department Select(int id);
        Department Select(string name);
        List<Department> Departments(bool? isActive = true, bool includeDoctors = true);
        Extensions.DataBaseResult Insert(Department newDepartment);
        Extensions.DataBaseResult Update(Department newInfoDepartment);
        Extensions.DataBaseResult Delete(int id);
    }
}