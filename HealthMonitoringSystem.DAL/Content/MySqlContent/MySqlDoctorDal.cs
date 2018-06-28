// Sait ORHAN -- 07.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlDoctorDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlDoctorDal : IDoctorDAL
    {
        public Doctor Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.Doctors.Include("Department")
                        .Include("Degree")
                        .Include("DoctorPhones")
                        .Include("DoctorMails")
                        .FirstOrDefault(d => d.Id == id);
            }
        }

        public Doctor Select(string tcNo)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.Doctors.Include("Department")
                        .Include("Degree")
                        .Include("DoctorPhones")
                        .Include("DoctorMails")
                        .FirstOrDefault(d => d.TcNo == tcNo);
            }
        }

        public List<Doctor> Doctors(bool? isActive = true, bool includeDetails = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return includeDetails
                    ? ctx.Doctors.Include("Department")
                        .Include("Degree")
                        .Include("DoctorPhones")
                        .Include("DoctorMails")
                        .Where(c => isActive == null || c.IsActive == isActive)
                        .ToList()
                    : ctx.Doctors.Where(c => isActive == null || c.IsActive == isActive).ToList();
            }
        }

        public Extensions.DataBaseResult Insert(Doctor newDoctor)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Doctors.Any(d => d.TcNo == newDoctor.TcNo && d.Id == newDoctor.Id))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                ctx.Doctors.Add(newDoctor);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(Doctor newInfoDoctor)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Doctors.Any(d => d.TcNo == newInfoDoctor.TcNo && d.Id != newInfoDoctor.Id))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                Doctor doctor = ctx.Doctors.FirstOrDefault(d => d.Id == newInfoDoctor.Id);
                if (doctor == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                doctor.Name = newInfoDoctor.Name;
                doctor.Surname = newInfoDoctor.Surname;
                doctor.BirthDay = newInfoDoctor.BirthDay;
                doctor.TcNo = newInfoDoctor.TcNo;
                doctor.RegistrationNumber = newInfoDoctor.RegistrationNumber;
                doctor.DepartmentId = newInfoDoctor.DepartmentId;
                doctor.DegreeId = newInfoDoctor.DegreeId;
                doctor.MotherName = newInfoDoctor.MotherName;
                doctor.FatherName = newInfoDoctor.FatherName;
                doctor.IsActive = newInfoDoctor.IsActive;
                doctor.Password = newInfoDoctor.Password;
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                Doctor doctor = ctx.Doctors.FirstOrDefault(d => d.Id == id && d.IsActive);
                if (doctor == null) return Extensions.DataBaseResult.NotFound;

                bool b = ctx.Rendezvouses.Any(r => r.DoctorId == id && r.IsActive) ||
                         ctx.Examinations.Any(e => e.DoctorId == id && e.IsActive);
                if (b) return Extensions.DataBaseResult.Referanced;


                doctor.IsActive = false;
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}