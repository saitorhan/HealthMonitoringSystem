// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlDiagnosisDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlDiagnosisDal : IDiagnosisDAL
    {
        public Diagnosis Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.Diagnoses.Include("Department").FirstOrDefault(d => d.Id == id);
            }
        }

        public Diagnosis Select(string name)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.Diagnoses.Include("Department").FirstOrDefault(d => d.Name == name);
            }
        }

        public List<Diagnosis> Diagnoses(int? departmentId, bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.Diagnoses.Include("Department")
                        .Where(
                            c =>
                                (isActive == null || c.IsActive == isActive) &&
                                (departmentId == null || c.DepartmentId == departmentId))
                        .ToList();
            }
        }

        public Extensions.DataBaseResult Insert(Diagnosis newDiagnosis)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Diagnoses.Any(d => d.Name == newDiagnosis.Name))
                    //  acaba name dışından kontrol edilmesi gereken bi sütun var mı?
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }

                ctx.Diagnoses.Add(newDiagnosis);

                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(Diagnosis newInfoDiagnosis)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Diagnoses.Any(d => d.Name == newInfoDiagnosis.Name && d.Id != newInfoDiagnosis.Id))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }

                Diagnosis diagnosis = ctx.Diagnoses.FirstOrDefault(d => d.Id == newInfoDiagnosis.Id);
                if (diagnosis == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                diagnosis.Name = newInfoDiagnosis.Name;
                diagnosis.IsActive = newInfoDiagnosis.IsActive;

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

                Diagnosis diagnosis = ctx.Diagnoses.FirstOrDefault(d => d.Id == id);

                if (diagnosis == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                bool b = ctx.Examinations.Any(d => d.DiagnosisId == id);

                if (b)
                {
                    return Extensions.DataBaseResult.Referanced;
                }

                ctx.Diagnoses.Remove(diagnosis);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}