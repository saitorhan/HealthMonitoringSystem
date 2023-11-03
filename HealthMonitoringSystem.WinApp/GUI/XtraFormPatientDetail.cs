// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormPatientDetail.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.PatientService;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;
using Patient = HealthMonitoringSystem.Entity.Patient;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormPatientDetail : XtraForm
    {
        public XtraFormPatientDetail()
        {
            InitializeComponent();
        }

        private void XtraFormPatientDetail_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            PatientManager client = new PatientManager();
            if (client.IsNull())
            {
                DialogResult result =
                    XtraMessageBox.Show("Servise bağlantı kurmada hata oluştu. Lütfen daha sonra tekrar deneyinizi.",
                        "Hata",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    RefreshData();
                }
            }
            List<Patient> patients = client.Patients(true).ToList();
            bindingSourcePatients.DataSource = patients;
        }

        private void barButtonItemNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormPatient formPatient = new XtraFormPatient();
            formPatient.ShowDialog();
            RefreshData();
        }

        private void barButtonItemEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Patient selectedPatient = bindingSourcePatients.Current as Patient;
            if (selectedPatient.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }

            XtraFormPatient formPatient = new XtraFormPatient(selectedPatient, true) {Text = "Hasta Düzenle"};
            formPatient.ShowDialog();
        }

        private void barButtonItemDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            Patient patient = bindingSourcePatients.Current as Patient;

            if (patient.IsNotNull() &&
                Extensions.Extensions.DeletingAlert(patient.Name + " " + patient.Surname) != DialogResult.Yes)
            {
                if (patient.IsNull())
                {
                    Extensions.Extensions.ObjectNotSelectedForDelete();
                    return;
                }
            }

            Extensions.Extensions.ShowWaitForm(description: "Hasta siliniyor...");
            PatientManager client = new PatientManager();

            ProcessResult processResult = client.Delete(patient.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                RefreshData();
        }

        private void barButtonItemDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            Patient selectedPatient = bindingSourcePatients.Current as Patient;
            if (selectedPatient.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDetails();
                return;
            }


            XtraFormPatient formPatient = new XtraFormPatient(selectedPatient, false) {Text = "Hasta Bilgileri"};
            formPatient.ShowDialog();
        }

        private void barButtonItemRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Hasta listesi yenileniyor...");
            RefreshData();
            SplashScreenManager.CloseForm(false);
        }
    }
}
