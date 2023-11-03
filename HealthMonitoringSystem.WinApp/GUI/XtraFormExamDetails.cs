// Sait ORHAN -- 27.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormExamDetails.cs

#region usings

using System;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.PrescriptionService;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormExamDetails : XtraForm
    {
        private bool opensplash;

        public XtraFormExamDetails(Examination examination)
        {
            InitializeComponent();
            labelControlDate.Text = examination.Time.ToString("D");
            if (examination.NextTime != null)
                labelControlNextDate.Text = examination.NextTime.IsNotNull()
                    ? examination.NextTime.Value.ToString("D")
                    : String.Empty;
            labelControlDiagnosis.Text = examination.Diagnosis.DisplayName;
            textBoxDoctorNote.Text = examination.DoctorNote;

            PrescriptionManager client = new PrescriptionManager();
            bindingSourcePrescription.DataSource = client.GetPrescriptionItems(examination.Id);

            LaboratoryRequestManager laboratoryRequest = new LaboratoryRequestManager();
            bindingSourceLabRequests.DataSource = laboratoryRequest.LaboratoryRequests(examination.Id, true);

            SplashScreenManager.CloseForm(false);
            opensplash = true;
        }

        private void bindingSourceLabRequests_CurrentChanged(object sender, EventArgs e)
        {
            if (opensplash)
                Extensions.Extensions.ShowWaitForm();
            LaboratoryRequest laboratoryRequest = bindingSourceLabRequests.Current as LaboratoryRequest;
            if (laboratoryRequest.IsNull())
            {
                bindingSourceResults.DataSource = null;
                return;
            }

            LaboratoryRequestItemManager client = new LaboratoryRequestItemManager();
            bindingSourceResults.DataSource = client.LaboratoryRequestItems(laboratoryRequest.Id);
            gridControlLabResults.Refresh();
            if (opensplash)
                SplashScreenManager.CloseForm(false);
        }
    }
}
