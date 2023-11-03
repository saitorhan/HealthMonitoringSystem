// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfDoctorMailDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlDoctorMailDal : IDoctorMailDAL
    {
        public DoctorMail Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.DoctorMails.Include("Doctor").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<DoctorMail> DoctorMails(bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.DoctorMails.Include("Doctor").Where(c => isActive == null || c.IsActive == isActive).ToList();
            }
        }


        public Extensions.DataBaseResult Insert(DoctorMail newDoctorMail)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                ctx.DoctorMails.Add(newDoctorMail);

                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(DoctorMail newInfoDoctorMail)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                DoctorMail doctorMail = ctx.DoctorMails.FirstOrDefault(d => d.Id == newInfoDoctorMail.Id);


                if (doctorMail == null)
                    return Extensions.DataBaseResult.NotFound;

                doctorMail.Mail = newInfoDoctorMail.Mail;
                doctorMail.IsActive = newInfoDoctorMail.IsActive;

                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Delete(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                DoctorMail doctorMail = ctx.DoctorMails.FirstOrDefault(d => d.Id == id);

                if (doctorMail == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }
                ctx.DoctorMails.Remove(doctorMail);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}