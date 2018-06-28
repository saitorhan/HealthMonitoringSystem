// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- SplashScreenStarting.cs

#region usings

using System;
using DevExpress.XtraSplashScreen;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class SplashScreenStarting : SplashScreen
    {
        public SplashScreenStarting()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}