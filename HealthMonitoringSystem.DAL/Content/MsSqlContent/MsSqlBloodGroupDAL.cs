// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfBloodGroupDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlBloodGroupDal : IBloodGroupDAL
    {
        public BloodGroup Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.BloodGroups.Include("Patients").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<BloodGroup> BloodGroups(bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.BloodGroups.Where(b => isActive == null || b.IsActive == isActive).ToList();
            }
        }

        public bool Insert(BloodGroup newBloodGroup)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                ctx.BloodGroups.Add(newBloodGroup);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(BloodGroup newInfoBloodGroup)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                BloodGroup bloodGroup = ctx.BloodGroups.FirstOrDefault(b => b.Id == newInfoBloodGroup.Id);

                if (bloodGroup == null)
                    return false;

                bloodGroup.Name = newInfoBloodGroup.Name;
                bloodGroup.IsActive = newInfoBloodGroup.IsActive;
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                BloodGroup bloodGroup = ctx.BloodGroups.FirstOrDefault(b => b.Id == id);
                if (bloodGroup == null)
                {
                    return false;
                }
                ctx.BloodGroups.Remove(bloodGroup);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}