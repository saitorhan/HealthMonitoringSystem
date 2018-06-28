// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlBloodGroupDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlBloodGroupDal : IBloodGroupDAL
    {
        public BloodGroup Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.BloodGroups.Include("Patient").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<BloodGroup> BloodGroups(bool? isActive = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.BloodGroups.Where(b => isActive == null || b.IsActive == isActive).ToList();
            }
        }

        public bool Insert(BloodGroup newBloodGroup)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                ctx.BloodGroups.Add(newBloodGroup);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(BloodGroup newInfoBloodGroup)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
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
            using (MySqlHealthContext ctx = new MySqlHealthContext())
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