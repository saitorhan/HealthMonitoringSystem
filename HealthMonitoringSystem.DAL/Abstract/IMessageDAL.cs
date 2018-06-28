// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IMessageDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IMessageDAL
    {
        Message Select(int id);
        List<Message> Messages(int doctorId, int patientId, bool? isActive = true);
        bool Insert(Message newMessage);
        bool Update(Message newInfoMessage);
        bool Delete(int id);
    }
}