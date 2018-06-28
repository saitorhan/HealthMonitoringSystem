// Sait ORHAN -- 11.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlExaminationDAL.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlExaminationDal : IExaminationDAL
    {
        public Examination Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.Examinations.Include("Prescriptions")
                        .Include("LaboratoryRequests")
                        .Include("Diagnosis")
                        .Include("Patient")
                        .FirstOrDefault(d => d.Id == id);
            }
        }

        public List<Examination> Examinations(DateTime? time, int doctorId, int? patientId, bool? isActive = true,
            bool includeDiagnosis = false)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return includeDiagnosis
                    ? ctx.Examinations.Include("Patient")
                        .Include("Diagnosis")
                        .Where(
                            c =>
                                (time == null ||
                                 (c.Time.Year == time.Value.Year && c.Time.Month == time.Value.Month &&
                                  c.Time.Day == time.Value.Day)) && (isActive == null || c.IsActive == isActive) &&
                                (c.DoctorId == doctorId) && (patientId == null || c.PatientId == patientId))
                        .OrderBy(e => e.RendezvousId)
                        .ToList()
                    : ctx.Examinations.Include("Patient")
                        .Where(
                            c =>
                                (time == null ||
                                 (c.Time.Year == time.Value.Year && c.Time.Month == time.Value.Month &&
                                  c.Time.Day == time.Value.Day)) && (isActive == null || c.IsActive == isActive) &&
                                (c.DoctorId == doctorId) && (patientId == null || c.PatientId == patientId))
                        .OrderBy(e => e.RendezvousId)
                        .ToList();
            }
        }

        public bool Insert(Examination newExamination)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                ctx.Examinations.Add(newExamination);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(Examination newInfoExamination)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                Examination examination = ctx.Examinations.FirstOrDefault(d => d.Id == newInfoExamination.Id);
                if (examination == null)
                    return false;

                examination.Time = newInfoExamination.Time;
                examination.DoctorNote = newInfoExamination.DoctorNote;
                examination.CanSendMessage = newInfoExamination.CanSendMessage;
                examination.NextTime = newInfoExamination.NextTime;
                examination.IsActive = newInfoExamination.IsActive;
                examination.DiagnosisId = newInfoExamination.DiagnosisId;
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                Examination examination = ctx.Examinations.FirstOrDefault(d => d.Id == id);
                if (examination == null)
                {
                    return false;
                }
                ctx.Examinations.Remove(examination);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}