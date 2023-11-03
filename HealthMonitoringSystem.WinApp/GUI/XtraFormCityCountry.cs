// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormCityCountry.cs

#region usings

using System;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;
using HealthMonitoringSystem.WinApp.Extensions;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormCityCountry : XtraForm
    {
        public XtraFormCityCountry()
        {
            InitializeComponent();
        }

        private void XtraFormCityCountry_Load(object sender, EventArgs e)
        {
            RefreshCity();
        }

        private void RefreshCity()
        {
            CityManager citySolClient = new CityManager();
            bindingSourceCity.DataSource = citySolClient.Cities(true);
        }


        private void barButtonItemAddNewCity_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormCity form = new XtraFormCity();
            form.ShowDialog();
            RefreshCity();
        }

        private void barButtonItemDeleteCity_ItemClick(object sender, ItemClickEventArgs e)
        {
            City city = bindingSourceCity.Current as City;
            if (city.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDelete();
                return;
            }

            if (Extensions.Extensions.DeletingAlert(city.Name) != DialogResult.Yes)
                return;
            Extensions.Extensions.ShowWaitForm(description: "Şehir siliniyor...");
            CityManager client = new CityManager();

            ProcessResult processResult = client.Delete(city.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                RefreshCity();
        }

        private void barButtonItemAddNewCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormCountry form = new XtraFormCountry();
            form.ShowDialog();
            bindingSourceCity_CurrentChanged(null, null);
        }

        private void barButtonItemEditCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            Country selectedCountry = bindingSourceCountry.Current as Country;
            if (selectedCountry.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }
            XtraFormCountry formCountry = new XtraFormCountry(selectedCountry);
            formCountry.ShowDialog();
            bindingSourceCity_CurrentChanged(null, null);
        }

        private void barButtonItemEditCity_ItemClick(object sender, ItemClickEventArgs e)
        {
            City selectedCity = bindingSourceCity.Current as City;

            if (selectedCity.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }
            XtraFormCity formCity = new XtraFormCity(selectedCity);
            formCity.ShowDialog();
        }


        private void SelectionChangedNewCity(object sender, SelectionChangedEventArgs e)
        {
            City selectedCity = bindingSourceCity.Current as City;
            if (selectedCity.IsNull()) return;

            CountryManager client1 = new CountryManager();
            bindingSourceCountry.DataSource = client1.Countries(selectedCity.Id, selectedCity.IsActive);
        }

        private void barButtonItemDeleteCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            Country country = bindingSourceCountry.Current as Country;
            if (country.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDelete();
                return;
            }
            if (Extensions.Extensions.DeletingAlert(country.Name) != DialogResult.Yes)
                return;

            Extensions.Extensions.ShowWaitForm(description: "İlçe siliniyor...");
            CountryManager client = new CountryManager();

            ProcessResult processResult = client.Delete(country.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            bindingSourceCity_CurrentChanged(null, null);
        }

        private void bindingSourceCity_CurrentChanged(object sender, EventArgs e)
        {
            CountryManager client = new CountryManager();


            City city = bindingSourceCity.Current as City;

            if (city == null) return;

            bindingSourceCountry.DataSource = client.Countries(city.Id, true);
        }

        private void barButtonItemRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Sayfa yenileniyor...");
            RefreshCity();
            SplashScreenManager.CloseForm(false);
        }
    }
}