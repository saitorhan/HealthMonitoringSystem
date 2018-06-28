// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfRendezvousTimeDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlRendezvousTimeDal : IRendezvousTimeDAL
    {
        public RendezvousTime Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.RendezvousTimes.FirstOrDefault(d => d.Id == id);
            }
        }

        public List<RendezvousTime> RendezvousTimes(bool? isActive = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.RendezvousTimes.Where(c => isActive == null || c.IsActive == isActive).ToList();
            }
        }

        public bool Insert(RendezvousTime newRendezvousTime)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (ctx.RendezvousTimes.Any(d => d.StartTime == newRendezvousTime.StartTime) &&
                    ctx.RendezvousTimes.Any(d => d.FinishTime == newRendezvousTime.FinishTime))
                {
                    return false;
                }

                ctx.RendezvousTimes.Add(newRendezvousTime);

                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(RendezvousTime newInfoRendezvousTime)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (ctx.RendezvousTimes.Any(d => d.StartTime == newInfoRendezvousTime.StartTime) &&
                    ctx.RendezvousTimes.Any(d => d.FinishTime == newInfoRendezvousTime.FinishTime))
                {
                    return false;
                }

                RendezvousTime rendezvousTime = ctx.RendezvousTimes.FirstOrDefault(d => d.Id == newInfoRendezvousTime.Id);

                if (rendezvousTime == null)
                {
                    return false;
                }

                rendezvousTime.StartTime = newInfoRendezvousTime.StartTime;
                rendezvousTime.FinishTime = newInfoRendezvousTime.FinishTime;
                rendezvousTime.IsActive = newInfoRendezvousTime.IsActive;

                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                RendezvousTime rendezvousTime = ctx.RendezvousTimes.FirstOrDefault(d => d.Id == id);

                if (rendezvousTime == null)
                {
                    return false;
                }

                bool b = ctx.Rendezvouses.Any(d => d.RendezvousTimeId == id);
                if (b)
                {
                    return false;
                }

                ctx.RendezvousTimes.Remove(rendezvousTime);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}