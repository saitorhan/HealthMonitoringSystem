// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinService -- HealthMonitoringSystemService.cs

#region usings

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceProcess;
using System.Timers;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.DAL.Content.MsSqlContent;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.WinService
{
    public partial class HealthMonitoringSystemService : ServiceBase
    {
        private Timer timer;

        public HealthMonitoringSystemService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string interval = ConfigurationManager.AppSettings["Interval"];
            int intervalS = interval == null ? 60000 : Convert.ToInt32(interval);

            if (timer == null)
            {
                timer = new Timer
                {
                    Interval = intervalS,
                    Enabled = true
                };
            }

            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
            RendezvousManager manager = new RendezvousManager();
            List<Rendezvous> rendezvouses = manager.Rendezvouses(DateTime.Today, null);

            foreach (Rendezvous rendezvous in from rendezvous in rendezvouses
                let result = (timeOfDay - rendezvous.RendezvousTime.StartTime).TotalMinutes
                where result <= 0
                select rendezvous)
            {
                manager.Delete(rendezvous.Id);
            }

            timer.Start();
        }

        protected override void OnStop()
        {
        }
    }
}