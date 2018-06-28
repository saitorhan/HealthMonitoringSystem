using System.ComponentModel;
using System.ServiceProcess;

namespace HealthMonitoringSystem.WinService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.HealthMonitoringSystem = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // HealthMonitoringSystem
            // 
            this.HealthMonitoringSystem.DelayedAutoStart = true;
            this.HealthMonitoringSystem.Description = "Hastane Bilgi Yönetim Sistemi";
            this.HealthMonitoringSystem.DisplayName = "SAFER HBYS";
            this.HealthMonitoringSystem.ServiceName = "HealthMonitoringSystemService";
            this.HealthMonitoringSystem.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1,
            this.HealthMonitoringSystem});

        }

        #endregion

        private ServiceProcessInstaller serviceProcessInstaller1;
        private ServiceInstaller HealthMonitoringSystem;
    }
}