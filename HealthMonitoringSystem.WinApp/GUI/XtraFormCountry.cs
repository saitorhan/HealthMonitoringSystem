// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormCountry.cs

#region usings

using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.CityService;
using HealthMonitoringSystem.WinApp.CounrtyService;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.Resources;
using City = HealthMonitoringSystem.WinApp.CityService.City;
using Country = HealthMonitoringSystem.WinApp.CounrtyService.Country;
using ProcessResult = HealthMonitoringSystem.WinApp.CounrtyService.ProcessResult;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormCountry : XtraForm
    {
        private Country _country;
        private bool update;

        public XtraFormCountry()
        {
            InitializeComponent();
        }

        public XtraFormCountry(Country country)
        {
            InitializeComponent();

            this._country = country;
            lookUpEditCities.EditValue = _country.City;
            textEditCountryName.Text = _country.Name;
            checkEditIsActive.Checked = _country.IsActive;
            barButtonItemCountrySave.Caption = "Güncelle";
            update = true;
        }

        private void XtraFormCountry_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.Cities.IsNull())
            {
                CitySolClient client = Extensions.Extensions.GetCityServiceSol();
                GlobalVariables.Cities = client.IsNull() ? null : new List<City>(client.Cities(true));
            }
            cityBindingSource.DataSource = GlobalVariables.Cities;
        }


        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItemCountrySave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "İlçe kaydediliyor");
            CountrySolClient client = Extensions.Extensions.GetCountrySolService();
            if (client == null)
            {
                return;
            }

            if (_country == null)
            {
                _country = new Country
                {
                    CityId = Convert.ToInt32(lookUpEditCities.EditValue),
                    Name = textEditCountryName.Text,
                    IsActive = checkEditIsActive.Checked
                };
            }
            else
            {
                _country.CityId = Convert.ToInt32(lookUpEditCities.EditValue);
                _country.Name = textEditCountryName.Text;
                _country.IsActive = checkEditIsActive.Checked;
            }

            ProcessResult processResult = update ? client.Update(_country) : client.Insert(_country);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            Close();
        }
    }
}