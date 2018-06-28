// Sait ORHAN -- 28.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- GlobalVariables.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.WinApp.CityService;
using HealthMonitoringSystem.WinApp.Extensions;
using Country = HealthMonitoringSystem.WinApp.CounrtyService.Country;
using Doctor = HealthMonitoringSystem.WinApp.SystemService.Doctor;
using Personnel = HealthMonitoringSystem.WinApp.SystemService.Personnel;

#endregion

namespace HealthMonitoringSystem.WinApp.Resources
{
    public static class GlobalVariables
    {
        public static List<MedicamentService.Medicament> Medicaments { get; set; }
        public static List<City> Cities { get; set; }
        public static List<Country> Countries { get; set; }
        public static List<DiagnosisService.Diagnosis> Diagnoses { get; set; }
        public static List<BloodGroupService.BloodGroup> BloodGroups { get; set; }
        public static List<DepartmentService.Department> Departments { get; set; }
        public static List<HolidayService.Holiday> Holidays { get; set; }
        public static List<LaboratoryRequestTypeService.LaboratoryRequestType> LaboratoryRequestTypes { get; set; }
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