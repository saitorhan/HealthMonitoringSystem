// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IMessageSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IMessageSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Message))]
    [ServiceKnownType(typeof (Doctor))]
    [ServiceKnownType(typeof (Patient))]
    public interface IMessageSol
    {
        [OperationContract]
        Message Select(int id);

        [OperationContract]
        List<Message> Messages(int doctorId, int patientId, bool? isActive = true);

        [OperationContract]
        bool Insert(Message newMessage);

        [OperationContract]
        bool Update(Message newInfoMessage);

        [OperationContract]
        bool Delete(int id);
    }
}