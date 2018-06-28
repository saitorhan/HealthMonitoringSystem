// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinService -- ProjectInstaller.cs

#region usings

using System.ComponentModel;
using System.Configuration.Install;

#endregion

namespace HealthMonitoringSystem.WinService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}