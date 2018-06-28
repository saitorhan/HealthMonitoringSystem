// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IDegreeSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IDegreeSol.cs
// 28 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Degree))]
    public interface IDegreeSol
    {
        [OperationContract]
        Degree Select(int id);

        [OperationContract]
        List<Degree> Degrees(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Degree newDegree);

        [OperationContract]
        ProcessResult Update(Degree newInfoDegree);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}