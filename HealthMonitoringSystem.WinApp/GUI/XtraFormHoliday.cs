// Sait ORHAN -- 11.01.2015 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormHoliday.cs

#region usings

using System;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.HolidayService;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormHoliday : XtraForm
    {
        public XtraFormHoliday()
        {
            InitializeComponent();
            dateEditFirstDay.EditValue = DateTime.Today;
            dateEditFirstDay.Properties.MinValue = DateTime.Today;
        }

        public ProcessResult result = new ProcessResult {Result = ExtensionsBLLResult.Error};
        private bool update;
        private Holiday holiday;

        public XtraFormHoliday(Holiday _holiday)
        {
            InitializeComponent();
            update = true;
            holiday = _holiday;
            textEditName.Text = holiday.Name;
            dateEditFirstDay.DateTime = new DateTime(holiday.Year ?? DateTime.Today.Year, holiday.Month, holiday.Day);
            checkEditEveryYear.Checked = holiday.Year.IsNull();
            textEditLenght.Visible = false;
            labelControlLenght.Visible = false;
        }

        private void XtraFormHoliday_Load(object sender, EventArgs e)
        {
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Tatil Kaydediliyor...");
            int lenght = Int32.TryParse(textEditLenght.Text, out lenght) ? Convert.ToInt32(textEditLenght.Text) : 0;
            DateTime dateTime = dateEditFirstDay.DateTime;

            if (!update)
                holiday = new Holiday();

            holiday.Name = textEditName.Text;
            holiday.Year = dateTime.Year;
            holiday.Month = dateTime.Month;
            holiday.Day = dateTime.Day;

            HolidaySolClient client = Extensions.Extensions.GetHolidaySolClient();
            result = update ? client.Update(holiday) : client.Insert(holiday, lenght, checkEditEveryYear.Checked);
            Extensions.Extensions.ProcessResultMessage(result.Errors, (int) result.Result);
            SplashScreenManager.CloseForm(false);
            if (result.Result == ExtensionsBLLResult.Success)
            {
                Close();
            }
        }
    }
}