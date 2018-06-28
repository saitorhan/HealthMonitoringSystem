// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlLaboratoryRequestItemDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlLaboratoryRequestItemDal : ILaboratoryRequestItemDAL
    {
        public LaboratoryRequestItem Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.LaboratoryRequestItems.Include("LaboratoryRequest")
                        .Include("LaboratoryRequestType")
                        .FirstOrDefault(d => d.Id == id);
            }
        }

        public List<LaboratoryRequestItem> LaboratoryRequestItems(int requestId)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.LaboratoryRequestItems.Include("LaboratoryRequest")
                        .Include("LaboratoryRequestType")
                        .Where(i => i.LaboratoryRequestId == requestId)
                        .ToList();
            }
        }

        public bool Insert(LaboratoryRequestItem newLaboratoryRequestItem)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                ctx.LaboratoryRequestItems.Add(newLaboratoryRequestItem);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(LaboratoryRequestItem newInfoLaboratoryRequestItem)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                LaboratoryRequestItem laboratoryRequestItem =
                    ctx.LaboratoryRequestItems.FirstOrDefault(d => d.Id == newInfoLaboratoryRequestItem.Id);
                if (laboratoryRequestItem == null)
                {
                    return false;
                }

                laboratoryRequestItem.LaboratoryRequestId = newInfoLaboratoryRequestItem.LaboratoryRequestId;
                laboratoryRequestItem.LaboratoryRequestTypeId = newInfoLaboratoryRequestItem.LaboratoryRequestTypeId;
                laboratoryRequestItem.Result = newInfoLaboratoryRequestItem.Result;

                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                LaboratoryRequestItem laboratoryRequestItem = ctx.LaboratoryRequestItems.FirstOrDefault(d => d.Id == id);
                if (laboratoryRequestItem == null)
                {
                    return false;
                }
                ctx.LaboratoryRequestItems.Remove(laboratoryRequestItem);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}