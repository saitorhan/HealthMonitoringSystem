// Sait ORHAN -- 28.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormPatient.cs

#region usings

using System;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.Resources;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;
using Patient = HealthMonitoringSystem.Entity.Patient;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormPatient : XtraForm
    {
        public Patient patient;
        public bool Result;
        private bool update;
        private bool getPatientId;

        private void GetSources()
        {
            bindingSourceBloodGroups.DataSource = GlobalVariables.BloodGroups;
            bindingSourceCities.DataSource = GlobalVariables.Cities;
        }

        public XtraFormPatient(Patient _patient, bool isEditing)
        {
            InitializeComponent();
            this.patient = _patient;
            update = true;
            GetSources();
            barButtonItemSave.Enabled = isEditing;
            if (!isEditing) barButtonItemCancel.Caption = "Kapat";

            textEditTCNumber.Text = patient.TcNo;
            textEditTCNumber.Properties.ReadOnly = !isEditing;
            textEditName.Text = patient.Name;
            textEditName.Properties.ReadOnly = !isEditing;
            textEditSurname.Text = patient.Surname;
            textEditSurname.Properties.ReadOnly = !isEditing;
            memoEditAdress.Text = patient.Address;
            memoEditAdress.Properties.ReadOnly = !isEditing;
            lookUpEditCity.EditValue = patient.CityId;
            lookUpEditCity.Properties.ReadOnly = !isEditing;
            lookUpEditCountry.EditValue = patient.CountryId;
            lookUpEditCountry.Properties.ReadOnly = !isEditing;
            textEditPhone.Text = patient.Phone;
            textEditPhone.Properties.ReadOnly = !isEditing;
            textEditMail.Text = patient.Mail;
            textEditMail.Properties.ReadOnly = !isEditing;
            dateEditBirthDay.DateTime = patient.BirthDay;
            dateEditBirthDay.Properties.ReadOnly = !isEditing;
            comboBoxEditGender.SelectedIndex = Convert.ToInt32(patient.Gender);
            comboBoxEditGender.Properties.ReadOnly = !isEditing;
            lookUpEditBloodGroup.EditValue = patient.BloodGroupId;
            lookUpEditBloodGroup.Properties.ReadOnly = !isEditing;
            checkEditIsActive.Checked = patient.IsActive;
            checkEditIsActive.Properties.ReadOnly = !isEditing;
            textEditFather.Text = patient.FatherName;
            textEditFather.Properties.ReadOnly = !isEditing;
            textEditMother.Text = patient.MotherName;
            textEditMother.Properties.ReadOnly = !isEditing;
        }

        public XtraFormPatient(bool getPatient = false)
        {
            InitializeComponent();
            GetSources();
            getPatientId = getPatient;
        }

        private void lookUpEditCity_EditValueChanged(object sender, EventArgs e)
        {
            int? city = lookUpEditCity.EditValue as int?;
            if (city.IsNull()) return;

            bindingSourceCountries.DataSource = GlobalVariables.Countries.Where(c => c.CityId == city).ToList();
            lookUpEditCountry.Refresh();
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!GetPatientValues()) return;
            Extensions.Extensions.ShowWaitForm(description: "Hasta kaydediliyor...");
            PatientManager client = new PatientManager();
            ProcessResult processResult = update ? client.Update(patient) : client.Insert(patient);
            if (getPatientId)
            {
                patient = client.Select(patient.TcNo);
            }
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result != Entity.Classes.Extensions.BLLResult.Success) return;
            Result = true;
            Close();
        }

        private bool GetPatientValues()
        {
            if (patient.IsNull())
                patient = new Patient();
            patient.TcNo = textEditTCNumber.Text;
            patient.Name = textEditName.Text;
            patient.Surname = textEditSurname.Text;
            patient.Address = memoEditAdress.Text;
            patient.CityId = (int) (lookUpEditCity.EditValue.IsNotNull() ? lookUpEditCity.EditValue : 0);
            patient.CountryId = (int) (lookUpEditCountry.EditValue.IsNotNull() ? lookUpEditCountry.EditValue : 0);
            patient.Phone = textEditPhone.Text;
            patient.Mail = textEditMail.Text;
            patient.BirthDay = dateEditBirthDay.DateTime;
            patient.Gender = Convert.ToBoolean(comboBoxEditGender.SelectedIndex);
            patient.BloodGroupId =
                (int) (lookUpEditBloodGroup.EditValue.IsNotNull() ? lookUpEditBloodGroup.EditValue : 0);
            patient.IsActive = checkEditIsActive.Checked;
            patient.FatherName = textEditFather.Text;
            patient.MotherName = textEditMother.Text;

            return true;
        }

        private void checkEditIsActive_CheckedChanged(object sender, EventArgs e)
        {
            checkEditIsActive.Text = String.Format("Aktif {0}", checkEditIsActive.Checked ? String.Empty : "Değil");
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}