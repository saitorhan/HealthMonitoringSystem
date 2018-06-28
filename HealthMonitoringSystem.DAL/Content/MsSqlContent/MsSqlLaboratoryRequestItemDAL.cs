// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfLaboratoryRequestItemDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlLaboratoryRequestItemDal : ILaboratoryRequestItemDAL
    {
        public LaboratoryRequestItem Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.LaboratoryRequestItems.Include("LaboratoryRequest")
                        .Include("LaboratoryRequestType")
                        .FirstOrDefault(d => d.Id == id);
            }
        }

        public List<LaboratoryRequestItem> LaboratoryRequestItems(int requestId)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
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
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                ctx.LaboratoryRequestItems.Add(newLaboratoryRequestItem);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(LaboratoryRequestItem newInfoLaboratoryRequestItem)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
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
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
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