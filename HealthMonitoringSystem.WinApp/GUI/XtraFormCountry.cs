// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormCountry.cs

#region usings

using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.Resources;

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
                CityManager client = new CityManager();
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
            CountryManager client = new CountryManager();
            

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