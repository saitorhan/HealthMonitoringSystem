// Sait ORHAN -- 08.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- ISystemSol.cs

#region usings

using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Doctor))]
    [ServiceKnownType(typeof (Personnel))]
    [ServiceKnownType(typeof (Department))]
    [ServiceKnownType(typeof (Degree))]
    [ServiceKnownType(typeof (City))]
    [ServiceKnownType(typeof (Country))]
    public interface ISystemSol
    {
        [OperationContract]
        Doctor LoginDoctor(string tc, string password);

        [OperationContract]
        Personnel LoginPersonnel(string tc, string password);

        [OperationContract]
        Patient LoginPatient(string tc, string password);

        [OperationContract]
        bool Test();
    }
}