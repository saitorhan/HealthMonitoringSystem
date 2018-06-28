// Sait ORHAN -- 27.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormExamDetails.cs

#region usings

using System;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.LaboratoryRequestItemService;
using HealthMonitoringSystem.WinApp.LaboratoryRequestService;
using HealthMonitoringSystem.WinApp.PrescriptionService;
using Examination = HealthMonitoringSystem.WinApp.ExaminationService.Examination;
using LaboratoryRequest = HealthMonitoringSystem.WinApp.LaboratoryRequestService.LaboratoryRequest;

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

            PrescriptionSolClient client = Extensions.Extensions.GetPrescriptionService();
            bindingSourcePrescription.DataSource = client.GetPrescriptionItems(examination.Id);

            LaboratoryRequestSolClient laboratoryRequest = Extensions.Extensions.GetLaboratoryRequest();
            bindingSourceLabRequests.DataSource = laboratoryRequest.LaboratoryRequests(examination.Id, true);

            laboratoryRequest.Close();
            client.Close();
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
            LaboratoryRequestItemSolClient client =
                Extensions.Extensions.GetLaboratoryRequestItem();
            bindingSourceResults.DataSource = client.LaboratoryRequestItems(laboratoryRequest.Id);
            client.Close();
            gridControlLabResults.Refresh();
            if (opensplash)
                SplashScreenManager.CloseForm(false);
        }
    }
}

namespace HealthMonitoringSystem.WinApp.PrescriptionService
{
    public partial class PrescriptionItem
    {
        public string SUsePerDay
        {
            get
            {
                if (UsePerDay < 1) return "BELİRTİLMEDİ";
                string s = UsePerDay.ToString();
                string[] split = s.Split(',');
                int day;
                int use;

                if (split.Length != 2) return "BELİRTİLMEDİ";

                Int32.TryParse(split[0], out day);
                Int32.TryParse(split[1], out use);

                return String.Format("{0} {1} defa", day == 1 ? "Günde" : day + " günde", use);
            }
        }
    }
}