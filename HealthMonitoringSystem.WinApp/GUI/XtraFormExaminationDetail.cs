// Sait ORHAN -- 11.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormExaminationDetail.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.ExaminationService;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.GUI;
using HealthMonitoringSystem.WinApp.LaboratoryRequestItemService;
using HealthMonitoringSystem.WinApp.LaboratoryRequestService;
using HealthMonitoringSystem.WinApp.MessageService;
using HealthMonitoringSystem.WinApp.PrescriptionService;
using HealthMonitoringSystem.WinApp.Resources;
using Examination = HealthMonitoringSystem.WinApp.ExaminationService.Examination;
using LaboratoryRequest = HealthMonitoringSystem.WinApp.LaboratoryRequestService.LaboratoryRequest;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormExaminationDetail : XtraForm
    {
        private bool open;
        public static Examination examination;
        private List<Examination> examinations;
        private List<Examination> Shownexaminations;
        private bool showClosed;

        public XtraFormExaminationDetail()
        {
            InitializeComponent();
        }

        private void timerGetPatients_Tick(object sender, EventArgs e)
        {
            timerGetPatients.Stop();
            GetPatients();
            timerGetPatients.Start();
        }

        private void GetPatients()
        {
            ExaminationSolClient client = Extensions.Extensions.GetExaminationService();
            if (client == null)
            {
                return;
            }

            int doctorid = GlobalVariables.Doctor.Id;

            examinations = client.Examinations(DateTime.Today, doctorid, null, null, false)
                .OrderByDescending(e => e.IsActive)
                .ThenBy(e => e.RendezvousId).ToList();

            ShowClosedOrHideClosed();

            client.Close();
        }

        private void XtraFormExaminationDetail_Load(object sender, EventArgs e)
        {
            // timerGetPatients.Start();
            GetPatients();
            GetDiagnosis();
            open = true;
        }

        private void GetDiagnosis()
        {
            bindingSourceDiagnosis.DataSource = GlobalVariables.Diagnoses;
        }

        private void checkEditCanSendMessage_CheckedChanged(object sender, EventArgs e)
        {
            checkEditCanSendMessage.Text = String.Format("Mesaj Göndere{0}",
                checkEditCanSendMessage.Checked ? "bilir" : "mez");
        }


        private void simpleButtonLabRequest_Click(object sender, EventArgs e)
        {
            if (examination.IsNull())
            {
                XtraMessageBox.Show("Laboratuvar isteği almak için herhangi bir hasta seçilmedi.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Extensions.Extensions.ShowWaitForm(description: "Tetkik listesi alınıyor...");
            XtraFormLaboratuvarRequest form = new XtraFormLaboratuvarRequest(examination.Id);
            form.ShowDialog();
            if (form.Result)
                bindingSourceExaminations_CurrentChanged(null, null);
        }

        private void bindingSourceExaminations_CurrentChanged(object sender, EventArgs e)
        {
            examination = bindingSourceExaminations.Current as Examination;

            if (examination.IsNull()) return;
            bindingSourceMessages.DataSource = null;
            bindingSourcePastExaminations.DataSource = null;
            if (open)
                Extensions.Extensions.ShowWaitForm(description: "Sayfa yenileniyor...");

            labelControlNameSurname.Text = examination.Patient.NameSurname;
            lookUpEditDiagnosis.EditValue = examination.DiagnosisId;
            textEditNextDay.Text = examination.NextTime.IsNull()
                ? String.Empty
                : (Convert.ToDateTime(examination.NextTime) - examination.Time).Days.ToString();
            checkEditCanSendMessage.Checked = examination.CanSendMessage;
            textBoxNote.Text = examination.DoctorNote;

            groupControlCurrentExamination.Text = String.Format("Şuanki Muayene Bilgisi ({0} Muayene)",
                examination.IsActive ? "Açık" : "Kapalı");

            LaboratoryRequestSolClient client = Extensions.Extensions.GetLaboratoryRequest();
            bindingSourceLabResult.DataSource = client.LaboratoryRequests(examination.Id, true);
            client.Close();
            if (open)
                SplashScreenManager.CloseForm(false);
        }

        private void bindingSourceLabResult_CurrentChanged(object sender, EventArgs e)
        {
            LaboratoryRequest laboratoryRequest =
                bindingSourceLabResult.Current as LaboratoryRequest;
            if (laboratoryRequest.IsNull())
            {
                bindingSourceItems.DataSource = null;
                return;
            }
            LaboratoryRequestItemSolClient client =
                Extensions.Extensions.GetLaboratoryRequestItem();
            bindingSourceItems.DataSource = client.LaboratoryRequestItems(laboratoryRequest.Id);
            client.Close();
        }

        private void barButtonItemWithoutPres_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!SetExaminationForClosing()) return;
            Extensions.Extensions.ShowWaitForm(description: "Muayene kapatılıyor");
            ExaminationSolClient client = Extensions.Extensions.GetExaminationService();

            if (client.IsNull()) return;

            bool update = client.Update(examination);
            Extensions.Extensions.ProcessResultMessage("Muayene kapatma", update);
            SplashScreenManager.CloseForm(false);
            if (!update) return;
            RefreshPage();
            GetPatients();
        }

        private void RefreshPage()
        {
            textEditNextDay.Text = String.Empty;
            textBoxNote.Text = String.Empty;
            bindingSourceDiagnosis.DataSource = null;
            lookUpEditDiagnosis.Refresh();
            bindingSourceDiagnosis.DataSource = GlobalVariables.Diagnoses;
            lookUpEditDiagnosis.Refresh();
        }

        private bool SetExaminationForClosing()
        {
            if (examination.IsNull()) return false;
            examination.IsActive = false;
            examination.CanSendMessage = checkEditCanSendMessage.Checked;
            examination.DoctorNote = textBoxNote.Text;

            object o = lookUpEditDiagnosis.EditValue;

            if (o.IsNull())
            {
                DialogResult result = XtraMessageBox.Show("Teşhis seçmediniz. Devam etmek istiyor musunuz?", "Uyarı!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return false;
                }
                examination.DiagnosisId = 0;
            }
            else
            {
                examination.DiagnosisId = (int) o;
            }

            if (textEditNextDay.Text.Length == 0)
            {
                examination.NextTime = null;
            }
            else
            {
                int next = Int32.Parse(textEditNextDay.Text);
                examination.NextTime = examination.Time.AddDays(next);
                if (examination.NextTime.Value.IsWeekend())
                {
                    examination.NextTime =
                        examination.NextTime.Value.AddDays(DayOfWeek.Monday - examination.NextTime.Value.DayOfWeek);
                }
            }
            return true;
        }

        private void simpleButtonPrintLabResult_Click(object sender, EventArgs e)
        {
            if (gridControlLabResults.IsPrintingAvailable)
            {
                gridControlLabResults.ShowPrintPreview();
            }
        }

        private void barButtonItemWithPres_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!SetExaminationForClosing()) return;
            Extensions.Extensions.ShowWaitForm(description: "İlaç listesi alınıyor...");
            XtraFormPrescription form = new XtraFormPrescription(examination);
            form.ShowDialog();
            if (form.result.Result != ExtensionsBLLResult.Success) return;
            GetPatients();
            RefreshPage();
        }

        private void simpleButtonLastExams_Click(object sender, EventArgs e)
        {
            if (examination.IsNull()) return;

            ExaminationSolClient client = Extensions.Extensions.GetExaminationService();
            if (client.IsNull()) return;
            MessageSolClient messageService = Extensions.Extensions.GetMessageService();

            Extensions.Extensions.ShowWaitForm(description: "Geçmiş muayene bilgileri sorgulanıyor");
            bindingSourcePastExaminations.DataSource = client.Examinations(null, GlobalVariables.Doctor.Id,
                examination.PatientId, false, true);
            gridControlPastExaminations.Refresh();
            bindingSourceMessages.DataSource = messageService.Messages(GlobalVariables.Doctor.Id, examination.PatientId,
                true);
            gridControlMessages.Refresh();
            SplashScreenManager.CloseForm(false);
        }

        private void gridControlPastExaminations_DoubleClick(object sender, EventArgs e)
        {
            if (bindingSourcePastExaminations.Current.IsNull()) return;

            Extensions.Extensions.ShowWaitForm(description: "Muayene bilgileri isteniyor...");

            Examination examination1 = bindingSourcePastExaminations.Current as Examination;
            XtraFormExamDetails examDetails = new XtraFormExamDetails(examination1);
            examDetails.ShowDialog();
        }

        private void XtraFormExaminationDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                GetPatients();
            }
        }

        private void muayeneOlmuslariGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showClosed = false;
            ShowClosedOrHideClosed();
        }

        private void muayeneOlmuslariGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showClosed = true;
            ShowClosedOrHideClosed();
        }

        private void ShowClosedOrHideClosed()
        {
            Shownexaminations = showClosed ? examinations : examinations.Where(e => e.IsActive).ToList();
            bindingSourceExaminations.DataSource = Shownexaminations;

            if (listBoxControlRandevozous.ItemCount != 0) return;

            bindingSourceLabResult.DataSource = null;
            bindingSourceItems.DataSource = null;
            labelControlNameSurname.Text = "";
        }
    }
}

namespace HealthMonitoringSystem.WinApp.ExaminationService
{
    public partial class Diagnosis
    {
        public string DisplayName
        {
            get { return Name == "DEFAULT" ? "TEŞHİS YOK" : Name; }
        }
    }
}

namespace HealthMonitoringSystem.WinApp.MessageService
{
    public partial class Message
    {
        public string From
        {
            get
            {
                return String.Format("{0} {1}",
                    FromDoctor ? GlobalVariables.Doctor.Name : XtraFormExaminationDetail.examination.Patient.Name,
                    FromDoctor ? GlobalVariables.Doctor.Surname : XtraFormExaminationDetail.examination.Patient.Surname);
            }
        }

        public string To
        {
            get
            {
                return String.Format("{0} {1}",
                    FromDoctor ? XtraFormExaminationDetail.examination.Patient.Name : GlobalVariables.Doctor.Name,
                    FromDoctor ? XtraFormExaminationDetail.examination.Patient.Surname : GlobalVariables.Doctor.Surname);
            }
        }

        public string SReaded
        {
            get { return Readed ? "OKUNDU" : "OKUNMADI"; }
        }
    }
}