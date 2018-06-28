// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDoctor.cs

#region usings

using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.DoctorMailService;
using HealthMonitoringSystem.WinApp.DoctorPhoneService;
using HealthMonitoringSystem.WinApp.DoctorService;
using HealthMonitoringSystem.WinApp.Extensions;
using Doctor = HealthMonitoringSystem.WinApp.DoctorService.Doctor;
using ExtensionsBLLResult = HealthMonitoringSystem.WinApp.DoctorService.ExtensionsBLLResult;
using ProcessResult = HealthMonitoringSystem.WinApp.DoctorService.ProcessResult;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormDoctor : XtraForm
    {
        public XtraFormDoctor()
        {
            InitializeComponent();
        }


        private void RefreshData()
        {
            DoctorSolClient doctorSolClient = Extensions.Extensions.GetDoctorSolClient();
            bindingSourceDoctor.DataSource = doctorSolClient.Doctors(true);
            doctorSolClient.Close();

            DoctorMailSolClient doctorMailSolClient = Extensions.Extensions.GetDoctorMailClient();
            bindingSourceMail.DataSource = doctorMailSolClient.DoctorMails(true);
            doctorMailSolClient.Close();


            DoctorPhoneSolClient doctorPhoneSolClient = Extensions.Extensions.GetDoctorPhoneSolClient();
            bindingSourcePhone.DataSource = doctorPhoneSolClient.DoctorPhones(true);

            doctorPhoneSolClient.Close();
        }

        private void barButtonItemNewDoctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormDoctorDetail form = new XtraFormDoctorDetail();
            form.ShowDialog();
            RefreshData();
        }

        private void barButtonItemEditDoctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Doctor selectedDoctor = bindingSourceDoctor.Current as Doctor;

            if (selectedDoctor.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }
            XtraFormDoctorDetail formDoctorDetail = new XtraFormDoctorDetail(selectedDoctor, true);
            formDoctorDetail.Text = "Doktor Düzenle";
            formDoctorDetail.ShowDialog();
        }

        private void XtraFormDoctor_Load_1(object sender, EventArgs e)
        {
            RefreshData();
        }


        private void barButtonItemDetailDoctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Doctor selectedDoctor = bindingSourceDoctor.Current as Doctor;


            if (selectedDoctor.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDetails();
                return;
            }
            XtraFormDoctorDetail formDoctorDetail = new XtraFormDoctorDetail(selectedDoctor, false);
            formDoctorDetail.Text = "Doktor Detay";
            formDoctorDetail.ShowDialog();
        }

        private void barButtonItemDeleteDoctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Doctor doctor = bindingSourceDoctor.Current as Doctor;
            if (doctor.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDelete();
                return;
            }

            if (Extensions.Extensions.DeletingAlert(doctor.Name + " " + doctor.Surname) != DialogResult.Yes)
                return;
            Extensions.Extensions.ShowWaitForm(description: "Doktor siliniyor...");
            DoctorSolClient client = Extensions.Extensions.GetDoctorSolClient();

            ProcessResult processResult = client.Delete(doctor.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == ExtensionsBLLResult.Success)
                RefreshData();
        }

        private void bindingSourceDoctor_CurrentChanged(object sender, EventArgs e)
        {
            Doctor doctor = bindingSourceDoctor.Current as Doctor;
            if (doctor == null) return;
            doctorPhonesBindingSource.DataSource = doctor.DoctorPhones;
            doctorMailsBindingSource.DataSource = doctor.DoctorMails;
        }

        private void barButtonItemRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Doktor listesi yenileniyor...");
            RefreshData();
            SplashScreenManager.CloseForm(false);
        }

        private void barButtonItemPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridControlDoctor.IsPrintingAvailable)
            {
                gridControlDoctor.ShowPrintPreview();
            }
        }
    }
}