// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormCity.cs

#region usings

using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormCity : XtraForm
    {
        private City _city;
        private bool update;

        public XtraFormCity()
        {
            InitializeComponent();
        }

        public XtraFormCity(City city)
        {
            InitializeComponent();
            this._city = city;
            textEditCityName.Text = _city.Name;
            checkEditIsActive.Checked = _city.IsActive;
            barButtonItemSave.Caption = "Güncelle";
            update = true;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void XtraFormCity_Load(object sender, EventArgs e)
        {
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Şehir kaydediliyor");
            CityManager client = new CityManager();

            if (_city == null)
            {
                _city = new City
                {
                    Name = textEditCityName.Text,
                    IsActive = checkEditIsActive.Checked
                };
            }
            else
            {
                _city.Name = textEditCityName.Text;
                _city.IsActive = checkEditIsActive.Checked;
            }

            ProcessResult processResult = update ? client.Update(_city) : client.Insert(_city);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            Close();
        }
    }
}