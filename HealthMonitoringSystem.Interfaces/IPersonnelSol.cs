// Sait ORHAN -- 02.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IPersonnelSol.cs

#region usings

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Personnel))]
    [ServiceKnownType(typeof (City))]
    [ServiceKnownType(typeof (Country))]
    public interface IPersonnelSol
    {
        [OperationContract]
        Personnel Select(int id);

        [OperationContract(Name = "PersonnelByTc")]
        Personnel Select(string Tc);

        [OperationContract]
        List<Personnel> Personnels(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Personnel newPatient);

        [OperationContract]
        bool Update(Personnel newInfoPersonnal);

        [OperationContract]
        bool Delete(int id);
    }
}