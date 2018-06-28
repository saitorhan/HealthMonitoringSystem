// Sait ORHAN -- 04.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormService.cs

#region usings

using System;
using System.Net.Sockets;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HealthMonitoringSystem.WinApp.Properties;
using HealthMonitoringSystem.WinApp.Resources;

#endregion

namespace HealthMonitoringSystem.WinApp
{
    public partial class XtraFormService : XtraForm
    {
        public XtraFormService()
        {
            InitializeComponent();
            string[] split = GlobalVariables.ServiceRoot.Split(new[] {"http://", ":"},
                StringSplitOptions.RemoveEmptyEntries);
            AdresstextEdit.Text = split[0];
            PorttextEdit.Text = split[1];
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            closingAfterError = false;
            Close();
        }

        private bool closingAfterError;

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            string adress = AdresstextEdit.Text.Trim();
            int port = Int32.TryParse(PorttextEdit.Text, out port) ? Convert.ToInt32(PorttextEdit.Text) : 80;

            try
            {
                TcpClient client = new TcpClient(adress, port);
                closingAfterError = false;
            }
            catch (Exception)
            {
                closingAfterError = true;
            }
            XtraMessageBox.Show(
                String.Format("{0}:{1} adresine bağlantı sağlan{2}dı.", adress, port,
                    closingAfterError ? "ama" : String.Empty), closingAfterError ? "Hata" : "Bilgi",
                MessageBoxButtons.OK, closingAfterError ? MessageBoxIcon.Error : MessageBoxIcon.Information);

            adress = String.Format("http://{0}:{1}", adress, port);
            if (closingAfterError) return;
            GlobalVariables.ServiceRoot = adress;
            Settings.Default.ServiceRoot = adress;
            Settings.Default.Save();
        }


        private void XtraFormService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                closingAfterError = false;
            }
            e.Cancel = closingAfterError;
        }
    }
}