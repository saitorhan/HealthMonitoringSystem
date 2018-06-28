// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlLaboratoryRequestDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlLaboratoryRequestDal : ILaboratoryRequestDAL
    {
        public LaboratoryRequest Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.LaboratoryRequests.Include("Examination")
                        .Include("LaboratoryRequestItems")
                        .FirstOrDefault(d => d.Id == id);
            }
        }

        public List<LaboratoryRequest> LaboratoryRequests(int examinationId, bool? isActive = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.LaboratoryRequests.Include("Examination")
                        .Include("LaboratoryRequestItems")
                        .Where(c => (isActive == null || c.IsActive == isActive) && (c.ExaminationId == examinationId))
                        .ToList();
            }
        }

        public bool Insert(LaboratoryRequest newLaboratoryRequest)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                newLaboratoryRequest.Examination =
                    ctx.Examinations.FirstOrDefault(e => e.Id == newLaboratoryRequest.ExaminationId);
                ctx.LaboratoryRequests.Add(newLaboratoryRequest);
                return ctx.SaveChanges() > -1;
            }
        }


        public bool Update(LaboratoryRequest newInfoLaboratoryRequest)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                LaboratoryRequest laboratoryRequest =
                    ctx.LaboratoryRequests.FirstOrDefault(d => d.Id == newInfoLaboratoryRequest.Id);
                if (laboratoryRequest == null)
                {
                    return false;
                }

                laboratoryRequest.ExaminationId = newInfoLaboratoryRequest.ExaminationId;
                laboratoryRequest.DateTime = newInfoLaboratoryRequest.DateTime;
                laboratoryRequest.Note = newInfoLaboratoryRequest.Note;
                laboratoryRequest.IsActive = newInfoLaboratoryRequest.IsActive;

                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                LaboratoryRequest laboratoryRequest = ctx.LaboratoryRequests.FirstOrDefault(d => d.Id == id);
                if (laboratoryRequest == null)
                {
                    return false;
                }
                ctx.LaboratoryRequests.Remove(laboratoryRequest);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}