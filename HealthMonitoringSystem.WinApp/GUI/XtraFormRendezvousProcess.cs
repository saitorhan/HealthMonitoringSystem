// Sait ORHAN -- 06.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormRendezvousProcess.cs

#region usings

using System;
using System.Linq;
using System.Windows.Forms;
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
    public partial class XtraFormRendezvousProcess : XtraForm
    {
        private Patient patient;
        public ProcessResult result;

        public XtraFormRendezvousProcess()
        {
            InitializeComponent();
        }

        private void lookUpEditDepartment_EditValueChanged(object sender, EventArgs e)
        {
            int id = (int) lookUpEditDepartment.EditValue;
            Department department = GlobalVariables.Departments.FirstOrDefault(d => d.Id == id);
            if (department != null)
                bindingSourceDoctor.DataSource = department.Doctors;
        }

        private void XtraFormRendezvousProcess_Load(object sender, EventArgs e)
        {
            bindingSourceDepartment.DataSource = GlobalVariables.Departments;
        }

        private void lookUpEditDoctor_EditValueChanged(object sender, EventArgs e)
        {
            int id = (int) lookUpEditDoctor.EditValue;
            Extensions.Extensions.ShowWaitForm("Uygun muayene saatleri sorgulanıyor...");
            RendezvousTimeManager client = new RendezvousTimeManager();
            bindingSourceTimes.DataSource = client.AvailableRendezvousTimes(DateTime.Today, id).ToList();
            SplashScreenManager.CloseForm(false);
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void simpleButtonPatientInfos_Click(object sender, EventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Hasta bilgisi sorgulanıyor...");
            PatientManager client = new PatientManager();
            patient = client.Select(textEditTCNO.Text.Trim());
            SplashScreenManager.CloseForm(false);
            if (patient.IsNotNull())
                labelControlPatientName.Text = patient.NameSurname;
            else
                XtraMessageBox.Show("Girilen kimlik numarası ile kişi bulunamadı", "Kişi Bulunamadı",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void simpleButtonNewPatient_Click(object sender, EventArgs e)
        {
            XtraFormPatient patientForm = new XtraFormPatient(true);
            patientForm.ShowDialog();
            if (!patientForm.Result) return;
            patient = patientForm.patient;
            labelControlPatientName.Text = patient.NameSurname;
            textEditTCNO.Text = patient.TcNo;
            simpleButtonNewPatient.Enabled = false;
            simpleButtonPatientInfos.Enabled = false;
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rendezvous rendezvous = new Rendezvous();

            rendezvous.Date = DateTime.Today;
            rendezvous.RendezvousTimeId = bindingSourceTimes.Current.IsNull()
                ? 0
                : (bindingSourceTimes.Current as RendezvousTime).Id;
            rendezvous.PatientId = patient.IsNull() ? 0 : patient.Id;
            rendezvous.DoctorId = (int) (lookUpEditDoctor.EditValue.IsNull() ? 0 : lookUpEditDoctor.EditValue);

            Extensions.Extensions.ShowWaitForm(description: "Randevu kaydediliyor...");
            RendezvousManager client = new RendezvousManager();
            result = client.Insert(rendezvous, true);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(result.Errors, (int) result.Result);
            if (result.Result == Entity.Classes.Extensions.BLLResult.Success) Close();
        }

        private void barButtonItemRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Bölüm ve doktor listesi yenileniyor...");
            Program.GetDepartments(true);
            bindingSourceDepartment.DataSource = GlobalVariables.Departments;
            lookUpEditDepartment.Refresh();
            SplashScreenManager.CloseForm(false);
        }
    }
}
