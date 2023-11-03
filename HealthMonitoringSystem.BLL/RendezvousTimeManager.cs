// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- RendezvousTimeManager.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using Ninject;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class RendezvousTimeManager 
    {
        private IRendezvousTimeDAL _rendezvousTimeDal;

        public RendezvousTimeManager()
        {
            _rendezvousTimeDal = new NinjectManager().CoreKernel.Get<IRendezvousTimeDAL>();
        }

        public RendezvousTime Select(int id)
        {
            return _rendezvousTimeDal.Select(id);
        }

        public List<RendezvousTime> RendezvousTimes(bool? isActive = true)
        {
            return _rendezvousTimeDal.RendezvousTimes();
        }

        public List<RendezvousTime> AvailableRendezvousTimes(DateTime time, int doctorId)
        {
            List<RendezvousTime> times = RendezvousTimes();
            RendezvousManager rendezvousManager = new RendezvousManager();
            List<int> rendezvous =
                rendezvousManager.Rendezvouses(time, doctorId, null).Select(t => t.RendezvousTimeId).ToList();
            List<RendezvousTime> rendezvousTimes = times.Where(t => !rendezvous.Contains(t.Id)).ToList();
            return rendezvousTimes;
        }

        public bool Insert(RendezvousTime newRendezvousTime)
        {
            return _rendezvousTimeDal.Insert(newRendezvousTime);
        }

        public bool Update(RendezvousTime newInfoRendezvousTime)
        {
            return _rendezvousTimeDal.Update(newInfoRendezvousTime);
        }

        public bool Delete(int id)
        {
            return _rendezvousTimeDal.Delete(id);
        }
    }
}