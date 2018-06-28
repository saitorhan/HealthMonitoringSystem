// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- Patient.cs

#region usings

using System;

#endregion

namespace HealthMonitoringSystem.WinApp.ExaminationService
{
    public partial class Patient
    {
        public string NameSurname
        {
            get { return String.Format("{0} {1}", Name, Surname); }
        }
    }
}