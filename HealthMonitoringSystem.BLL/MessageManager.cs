// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- MessageManager.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class MessageManager : IMessageSol
    {
        private IMessageDAL _messageDal;

        public MessageManager(IMessageDAL messageDal)
        {
            _messageDal = messageDal;
        }

        public Message Select(int id)
        {
            return _messageDal.Select(id);
        }

        public List<Message> Messages(int doctorId, int patientId, bool? isActive = true)
        {
            return _messageDal.Messages(doctorId, patientId, isActive);
        }

        public bool Insert(Message newMessage)
        {
            return _messageDal.Insert(newMessage);
        }

        public bool Update(Message newInfoMessage)
        {
            return _messageDal.Update(newInfoMessage);
        }

        public bool Delete(int id)
        {
            return _messageDal.Delete(id);
        }
    }
}