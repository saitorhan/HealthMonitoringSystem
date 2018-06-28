// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IDepartmentSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IDepartmentSol.cs
// 28 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Department))]
    public interface IDepartmentSol
    {
        [OperationContract]
        Department Select(int id);

        [OperationContract(Name = "SelectByName")]
        Department Select(string Name);

        [OperationContract]
        List<Department> Departments(bool? isActive = true, bool includeDoctors = true);

        [OperationContract]
        ProcessResult Insert(Department newDepartment);

        [OperationContract]
        ProcessResult Update(Department newInfoDepartment);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}