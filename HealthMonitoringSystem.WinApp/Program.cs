// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- Program.cs

#region usings

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
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
            string thema = Settings.Default.Thema;
            UserLookAndFeel.Default.SetSkinStyle(thema);
            Thread.CurrentThread.CurrentUICulture =
                Thread.CurrentThread.CurrentCulture =
                    new CultureInfo("tr-TR") {NumberFormat = {NumberDecimalSeparator = ",", NumberGroupSeparator = "."}};

            bool loggedin = Login();
            if (!loggedin) return;

            SplashScreenManager.ShowForm(typeof (SplashScreenStarting));

            bool service = TestService();
            if (!service) return;
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

        public static bool TestService()
        {
            if (firstRun)
            {
                GlobalVariables.ServiceRoot = Settings.Default.ServiceRoot;
                firstRun = false;
            }


            bool result;
            string adress = GlobalVariables.ServiceRoot;

            string[] strings = adress.Split(new[] {"http://", ":"}, StringSplitOptions.RemoveEmptyEntries);
            adress = strings[0];
            int port = Convert.ToInt32(strings[1]);
            try
            {
                // ReSharper disable once UnusedVariable
                TcpClient client = new TcpClient(adress, port);
                result = true;
                GlobalVariables.ServiceRoot = String.Format("http://{0}:{1}", adress, port);
            }
            catch (Exception)
            {
                result = false;
            }

            if (result)
            {
                return true;
            }

            DialogResult dialogResult =
                XtraMessageBox.Show(
                    String.Format(
                        "{0}:{1} adresine bağlantı sağlanamadı. Servis adresi ayarlanmadan sistem açılmayacaktır. Şimdi ayarlamak ister misiniz?",
                        adress, port), "Hata",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult != DialogResult.Yes) return false;

            XtraFormService service = new XtraFormService();
            service.ShowDialog();
            bool testService = TestService();
            return testService;
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