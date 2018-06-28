// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlLaboratoryItemUnit.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlLaboratoryItemUnit : ILaboratoryItemUnitDAL
    {
        public LaboratoryItemUnit Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.LaboratoryItemUnits.FirstOrDefault(d => d.Id == id);
            }
        }

        public List<LaboratoryItemUnit> LaboratoryItemUnits(bool? isActive = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.LaboratoryItemUnits.Where(c => isActive == null || c.IsActive == isActive).ToList();
            }
        }

        public bool Insert(LaboratoryItemUnit newLaboratoryItemUnit)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                ctx.LaboratoryItemUnits.Add(newLaboratoryItemUnit);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(LaboratoryItemUnit newInfoLaboratoryItemUnit)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                LaboratoryItemUnit laboratoryItemUnit =
                    ctx.LaboratoryItemUnits.FirstOrDefault(d => d.Id == newInfoLaboratoryItemUnit.Id);
                if (laboratoryItemUnit == null)
                {
                    return false;
                }

                laboratoryItemUnit.Name = newInfoLaboratoryItemUnit.Name;
                laboratoryItemUnit.IsActive = newInfoLaboratoryItemUnit.IsActive;

                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                LaboratoryItemUnit laboratoryItemUnit = ctx.LaboratoryItemUnits.FirstOrDefault(d => d.Id == id);

                if (laboratoryItemUnit == null)
                {
                    return false;
                }
                ctx.LaboratoryItemUnits.Remove(laboratoryItemUnit);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}