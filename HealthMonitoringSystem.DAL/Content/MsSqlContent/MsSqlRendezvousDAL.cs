// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfRendezvousDAL.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlRendezvousDal : IRendezvousDAL
    {
        public Rendezvous Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.Rendezvouses.Include("RendezvousTime")
                        .Include("Patient")
                        .Include("Doctor")
                        .FirstOrDefault(d => d.Id == id);
            }
        }

        public List<Rendezvous> Rendezvouses(DateTime time, int? doctorId, bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.Rendezvouses.Include("RendezvousTime")
                        .Include("Patient")
                        .Include("Doctor")
                        .Where(
                            c =>
                                (isActive == null || c.IsActive == isActive) &&
                                (doctorId == null || c.DoctorId == doctorId) && time.Day == c.Date.Day &&
                                time.Month == c.Date.Month && time.Year == c.Date.Year)
                        .OrderBy(r => r.Id)
                        .ToList();
            }
        }

        public Extensions.DataBaseResult Insert(ref Rendezvous newRendezvous)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                ctx.Rendezvouses.Add(newRendezvous);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public bool Update(Rendezvous newInfoRendezvous)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                Rendezvous rendezvous = ctx.Rendezvouses.FirstOrDefault(d => d.Id == newInfoRendezvous.Id);
                if (rendezvous == null)
                {
                    return false;
                }

                rendezvous.Date = newInfoRendezvous.Date;
                rendezvous.RendezvousTimeId = newInfoRendezvous.RendezvousTimeId;
                rendezvous.Patient = newInfoRendezvous.Patient;
                rendezvous.DoctorId = newInfoRendezvous.DoctorId;
                rendezvous.IsActive = newInfoRendezvous.IsActive;
                return ctx.SaveChanges() > -1;
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

                bool b = ctx.Examinations.Any(e => e.RendezvousId == id && !e.IsActive);
                if (b) return Extensions.DataBaseResult.Referanced;

                Rendezvous rendezvous = ctx.Rendezvouses.FirstOrDefault(d => d.Id == id);
                if (rendezvous == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }
                ctx.Rendezvouses.Remove(rendezvous);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}