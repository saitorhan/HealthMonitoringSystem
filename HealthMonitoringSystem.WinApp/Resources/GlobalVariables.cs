// Sait ORHAN -- 28.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- GlobalVariables.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.WinApp.Extensions;

#endregion

namespace HealthMonitoringSystem.WinApp.Resources
{
    public static class GlobalVariables
    {
        public static List<Medicament> Medicaments { get; set; }
        public static List<City> Cities { get; set; }
        public static List<Country> Countries { get; set; }
        public static List<Diagnosis> Diagnoses { get; set; }
        public static List<BloodGroup> BloodGroups { get; set; }
        public static List<Department> Departments { get; set; }
        public static List<Holiday> Holidays { get; set; }
        public static List<LaboratoryRequestType> LaboratoryRequestTypes { get; set; }
        public static string ServiceRoot { get; set; }

        public static LogginType LoggedType
        {
            get
            {
                if (Doctor.IsNotNull())
                {
                    return LogginType.Doctor;
                }
                return Personnel.Degree.IsAdmin ? LogginType.Admin : LogginType.Personnel;
            }
        }

        public static Doctor Doctor { get; set; }
        public static Personnel Personnel { get; set; }

        public enum LogginType
        {
            Doctor,
            Personnel,
            Admin
        }
    }
}