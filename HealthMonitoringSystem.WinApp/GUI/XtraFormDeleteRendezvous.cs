// Sait ORHAN -- 15.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDeleteRendezvous.cs

#region usings

using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.RendezvousService;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormDeleteRendezvous : XtraForm
    {
        private Rendezvous rendezvous;

        public XtraFormDeleteRendezvous()
        {
            InitializeComponent();
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult alert =
                Extensions.Extensions.DeletingAlert(String.Format("{0} {1} kişisi {2} numaralı randevusu",
                    rendezvous.Patient.Name, rendezvous.Patient.Surname, rendezvous.Id));
            if (alert != DialogResult.Yes) return;

            RendezvousSolClient client = Extensions.Extensions.GetRendezvousService();
            ProcessResult result = client.Delete(rendezvous.Id);
            Extensions.Extensions.ProcessResultMessage(result.Errors, (int) result.Result);
            if (result.Result == ExtensionsBLLResult.Success) Close();
        }

        private void buttonEditFindRendezvous_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Randevu bilgisi isteniyor...");
            int id;
            object value = buttonEditFindRendezvous.EditValue;
            try
            {
                id = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Randevu numarası hatalı girildi.", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            RendezvousSolClient client = Extensions.Extensions.GetRendezvousService();
            rendezvous = client.Select(id);
            simpleButtonDelete.Enabled = rendezvous.IsNotNull();
            simpleButtonUpdate.Enabled = rendezvous.IsNotNull();
            if (rendezvous.IsNull())
            {
                XtraMessageBox.Show(String.Format("{0} numaralı bir randevu bulunamadı.", id), "Uyarı!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SplashScreenManager.CloseForm(false);
                return;
            }
            textEditPatientName.Text = String.Format("{0} {1}", rendezvous.Patient.Name, rendezvous.Patient.Surname);
            textEditDoctorName.Text = String.Format("{0} {1}", rendezvous.Doctor.Name, rendezvous.Doctor.Surname);
            textEditDate.Text = rendezvous.Date.ToString("D");
            textEditTime.Text = rendezvous.RendezvousTime.StartTime.ToString(@"hh\:mm");
            SplashScreenManager.CloseForm(false);
        }
    }
}