// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfLaboratoryRequestTypeDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlLaboratoryRequestTypeDal : ILaboratoryRequestTypeDAL
    {
        public LaboratoryRequestType Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.LaboratoryRequestTypes.Include("LaboratoryItemUnit").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<LaboratoryRequestType> LaboratoryRequestTypes(bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.LaboratoryRequestTypes.Include("LaboratoryItemUnit")
                        .Where(c => isActive == null || c.IsActive == isActive)
                        .ToList();
            }
        }

        public bool Insert(LaboratoryRequestType newLaboratoryRequestType)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                ctx.LaboratoryRequestTypes.Add(newLaboratoryRequestType);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(LaboratoryRequestType newInfoLaboratoryRequestType)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                LaboratoryRequestType laboratoryRequestType =
                    ctx.LaboratoryRequestTypes.FirstOrDefault(d => d.Id == newInfoLaboratoryRequestType.Id);
                if (laboratoryRequestType == null)
                {
                    return false;
                }

                laboratoryRequestType.Name = newInfoLaboratoryRequestType.Name;
                laboratoryRequestType.Min = newInfoLaboratoryRequestType.Min;
                laboratoryRequestType.Max = newInfoLaboratoryRequestType.Max;
                laboratoryRequestType.LaboratoryItemUnitId = newInfoLaboratoryRequestType.LaboratoryItemUnitId;
                laboratoryRequestType.IsActive = newInfoLaboratoryRequestType.IsActive;
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                LaboratoryRequestType laboratoryRequestType = ctx.LaboratoryRequestTypes.FirstOrDefault(d => d.Id == id);
                if (laboratoryRequestType == null)
                {
                    return false;
                }
                ctx.LaboratoryRequestTypes.Remove(laboratoryRequestType);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}