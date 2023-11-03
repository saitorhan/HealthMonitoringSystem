// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- Program.cs

#region usings

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.GUI;
using HealthMonitoringSystem.WinApp.Properties;
using HealthMonitoringSystem.WinApp.Resources;

#endregion

namespace HealthMonitoringSystem.WinApp
{
    internal static class Program
    {
        private static bool firstRun = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Thread.CurrentThread.CurrentUICulture =
                Thread.CurrentThread.CurrentCulture =
                    new CultureInfo("tr-TR") {NumberFormat = {NumberDecimalSeparator = ",", NumberGroupSeparator = "."}};

            bool loggedin = Login();
            if (!loggedin) return;

            SplashScreenManager.ShowForm(typeof (SplashScreenStarting));

            GetDiagnosis();
            GetCities();
            GetCountries();
            GetBloodGroups();
            GetDepartments();
            GetHolidays();
            SplashScreenManager.CloseForm();

            Application.Run(new FormMain());
        }

        public static void GetHolidays(bool refresh = false)
        {
            if (GlobalVariables.Holidays.IsNotNull() && !refresh) return;

            HolidayManager client = new HolidayManager();
            GlobalVariables.Holidays = client.Holidays();
        }

        private static bool Login()
        {
            XtraFormLogin login = new XtraFormLogin();
            if (login.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            return login.LoggedIn;
        }

        public static void GetDepartments(bool refresh = false)
        {
            if (GlobalVariables.Departments.IsNotNull() && !refresh) return;

            DepartmentManager client = new DepartmentManager();
            GlobalVariables.Departments = client.Departments(true, true).ToList();
        }

        public static void GetCountries()
        {
            if (GlobalVariables.Countries.IsNotNull()) return;
            CountryManager client = new CountryManager();
            GlobalVariables.Countries = client.IsNull() ? null : client.Countries(true);
        }

        public static void GetCities()
        {
            if (GlobalVariables.Cities.IsNotNull()) return;
            CityManager citySolClient = new CityManager();
            GlobalVariables.Cities = citySolClient.IsNull() ? null : new List<City>(citySolClient.Cities(true));
        }

        public static void GetDiagnosis()
        {
            if (GlobalVariables.Doctor.IsNull() || GlobalVariables.Diagnoses.IsNotNull()) return;
            int departmentId = GlobalVariables.Doctor.DepartmentId;
            DiagnosisManager client = new DiagnosisManager();
            GlobalVariables.Diagnoses = client.IsNull() ? null : client.Diagnoses(departmentId, true).ToList();
        }

        public static void GetBloodGroups()
        {
            if (GlobalVariables.BloodGroups.IsNotNull()) return;
            BloodGroupManager client = new BloodGroupManager();
            GlobalVariables.BloodGroups = client.IsNull() ? null : client.BloodGroups(true).ToList();
        }
    }
}