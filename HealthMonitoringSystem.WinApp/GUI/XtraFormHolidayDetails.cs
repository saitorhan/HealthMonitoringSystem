// Sait ORHAN -- 11.01.2015 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormHolidayDetails.cs

#region usings

using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.HolidayService;
using HealthMonitoringSystem.WinApp.Resources;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormHolidayDetails : XtraForm
    {
        public XtraFormHolidayDetails()
        {
            InitializeComponent();
            bindingSourceHolidays.DataSource = GlobalVariables.Holidays;
            SplashScreenManager.CloseForm(false);
        }

        private void barButtonItemNewHoliday_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormHoliday holiday = new XtraFormHoliday();
            holiday.ShowDialog();
            if (holiday.result.Result != ExtensionsBLLResult.Success) return;
            RefreshData();
        }

        private void barButtonItemEditHoliday_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Holiday selectedHoliday = bindingSourceHolidays.Current as Holiday;

            if (selectedHoliday.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }

            XtraFormHoliday formDoctorDetail = new XtraFormHoliday(selectedHoliday);
            formDoctorDetail.Text = "Tatil Düzenle";
            formDoctorDetail.ShowDialog();
            if (formDoctorDetail.result.Result != ExtensionsBLLResult.Success) return;
            RefreshData();
        }

        private void barButtonItemDeleteHoliday_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Holiday holiday = bindingSourceHolidays.Current as Holiday;
            if (holiday.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDelete();
                return;
            }

            if (Extensions.Extensions.DeletingAlert(holiday.Name) != DialogResult.Yes)
                return;
            Extensions.Extensions.ShowWaitForm(description: "Tatil siliniyor...");
            HolidaySolClient client = Extensions.Extensions.GetHolidaySolClient();

            ProcessResult processResult = client.Delete(holiday.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == ExtensionsBLLResult.Success)
                RefreshData();
        }

        private void RefreshData()
        {
            Program.GetHolidays(true);
            bindingSourceHolidays.DataSource = GlobalVariables.Holidays;
            gridControlHoliday.Refresh();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Tatil Listesi Yenileniyor...");
            RefreshData();
            SplashScreenManager.CloseForm(false);
        }
    }
}

namespace HealthMonitoringSystem.WinApp.HolidayService
{
    public partial class Holiday
    {
        public string MonthS
        {
            get
            {
                List<string> months = new List<string>
                {
                    "Ocak",
                    "Şubat",
                    "Mart",
                    "Nisan",
                    "Mayıs",
                    "Haziran",
                    "Temmuz",
                    "Ağustos",
                    "Eylül",
                    "Ekim",
                    "Kasım",
                    "Aralık"
                };
                return months[Month - 1];
            }
        }

        public string YearS
        {
            get { return Year == null ? "Her Yıl" : Year.Value.ToString(); }
        }
    }
}