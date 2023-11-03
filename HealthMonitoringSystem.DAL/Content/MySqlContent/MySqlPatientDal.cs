// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlPatientDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlPatientDal : IPatientDAL
    {
        public Patient Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.Patients.Include("City")
                        .Include("Country")
                        .Include("BloodGroup")
                        .FirstOrDefault(d => d.Id == id);
            }
        }

        public Patient Select(string tc)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.Patients.FirstOrDefault(p => p.TcNo == tc);
            }
        }

        public List<Patient> Patients(bool? isActive = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.Patients.Include("City")
                        .Include("Country")
                        .Include("BloodGroup")
                       .Where(c => isActive == null || c.IsActive == isActive)
                        .ToList();
            }
        }

        public Extensions.DataBaseResult Insert(Patient newPatient)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                Patient patient = Select(newPatient.TcNo);
                if (patient != null)
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                ctx.Patients.Add(newPatient);
                bool b = ctx.SaveChanges() > -1;
                return b ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(Patient newInfoPatient)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                Patient patient = ctx.Patients.FirstOrDefault(d => d.Id == newInfoPatient.Id);
                if (patient == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                patient.TcNo = newInfoPatient.TcNo;
                patient.Name = newInfoPatient.Name;
                patient.Surname = newInfoPatient.Surname;
                patient.MotherName = newInfoPatient.MotherName;
                patient.FatherName = newInfoPatient.FatherName;
                patient.Address = newInfoPatient.Address;
                patient.CityId = newInfoPatient.CityId;
                patient.CountryId = newInfoPatient.CountryId;
                patient.Phone = newInfoPatient.Phone;
                patient.Mail = newInfoPatient.Mail;
                patient.BirthDay = newInfoPatient.BirthDay;
                patient.Gender = newInfoPatient.Gender;
                patient.BloodGroupId = newInfoPatient.BloodGroupId;
                patient.IsActive = newInfoPatient.IsActive;
                patient.Password = newInfoPatient.Password;
                bool b = ctx.SaveChanges() > -1;
                return b ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
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

                Patient patient = ctx.Patients.FirstOrDefault(d => d.Id == id);
                if (patient == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                bool b = ctx.Consultations.Any(d => d.PatientId == id) || ctx.Examinations.Any(d => d.PatientId == id) ||
                         ctx.Messages.Any(d => d.PatientId == id) || ctx.Rendezvouses.Any(d => d.PatientId == id);

                if (b)
                {
                    return Extensions.DataBaseResult.Referanced;
                }

                ctx.Patients.Remove(patient);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}