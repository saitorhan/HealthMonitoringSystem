// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlMessageDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlMessageDal : IMessageDAL
    {
        public Message Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.Messages.Include("Doctor").Include("Patient").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<Message> Messages(int doctorId, int patientId, bool? isActive = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.Messages.Where(
                        c =>
                            c.DoctorId == doctorId && c.PatientId == patientId &&
                            (isActive == null || c.IsActive == isActive)).ToList();
            }
        }

        public bool Insert(Message newMessage)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                ctx.Messages.Add(newMessage);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(Message newInfoMessage)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                Message message = ctx.Messages.FirstOrDefault(d => d.Id == newInfoMessage.Id);
                if (message == null)
                {
                    return false;
                }

                message.DoctorId = newInfoMessage.DoctorId;
                message.PatientId = newInfoMessage.PatientId;
                message.DateTime = newInfoMessage.DateTime;
                message.Mesage = newInfoMessage.Mesage;
                message.FromDoctor = newInfoMessage.FromDoctor;
                message.Readed = newInfoMessage.Readed;
                message.Doctor = newInfoMessage.Doctor;
                message.Patient = newInfoMessage.Patient;
                message.IsActive = newInfoMessage.IsActive;
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                Message message = ctx.Messages.FirstOrDefault(d => d.Id == id);
                if (message == null)
                {
                    return false;
                }
                ctx.Messages.Remove(message);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}