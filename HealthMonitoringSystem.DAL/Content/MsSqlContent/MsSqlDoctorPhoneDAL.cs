// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfDoctorPhoneDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlDoctorPhoneDal : IDoctorPhoneDAL
    {
        public DoctorPhone Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.DoctorPhones.Include("Doctor").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<DoctorPhone> DoctorPhones(bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.DoctorPhones.Include("Doctor").ToList();
            }
        }


        public Extensions.DataBaseResult Insert(DoctorPhone newDoctorPhone)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                ctx.DoctorPhones.Add(newDoctorPhone);

                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(DoctorPhone newInfoDoctorPhone)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                DoctorPhone doctorPhone = ctx.DoctorPhones.FirstOrDefault(d => d.Id == newInfoDoctorPhone.Id);

                if (doctorPhone == null)
                    return Extensions.DataBaseResult.NotFound;

                doctorPhone.Phone = newInfoDoctorPhone.Phone;
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

                DoctorPhone doctorPhone = ctx.DoctorPhones.FirstOrDefault(d => d.Id == id);

                if (doctorPhone == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }
                ctx.DoctorPhones.Remove(doctorPhone);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}