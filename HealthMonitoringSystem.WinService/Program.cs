// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinService -- Program.cs

#region usings

using System.ServiceProcess;

#endregion

namespace HealthMonitoringSystem.WinService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new HealthMonitoringSystemService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}