// Sait ORHAN -- 08.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormLogin.cs

#region usings

using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.Resources;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormLogin : XtraForm
    {
        public bool LoggedIn { get; set; }
        private bool clossingAfterError;

        public XtraFormLogin()
        {
            InitializeComponent();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            Extensions.Extensions.ShowWaitForm("Kullanıcı bilgileri sorgulanıyor", "Lütfen bekleyiniz");
            string tc = textEditTCNo.Text;
            string pass = textEditPassword.Text;
            if (comboBoxEditType.SelectedIndex == 0)
            {
                LoginDoctor(tc, pass);
            }
            else if (comboBoxEditType.SelectedIndex == 1)
            {
                LoginPersonnel(tc, pass, false);
            }
            else if (comboBoxEditType.SelectedIndex == 2)
            {
                LoginPersonnel(tc, pass, true);
            }
        }

        private void LoginPersonnel(string tc, string pass, bool isAdmin)
        {
            SystemManager client = new SystemManager();
            Personnel personnel = client.LoginPersonnel(tc, pass);
            if (personnel.IsNull())
            {
                LoggedIn = false;
                clossingAfterError = true;
                ErrorMessage();
            }
            else
            {
                if (personnel.Degree.IsAdmin != isAdmin)
                {
                    LoggedIn = false;
                    clossingAfterError = true;
                    ErrorMessage();
                    return;
                }
                GlobalVariables.Personnel = personnel;
                LoggedIn = true;
                SplashScreenManager.CloseForm(false);
            }
        }

        private void LoginDoctor(string tc, string pass)
        {
            SystemManager client = new SystemManager();
            Doctor doctor = client.LoginDoctor(tc, pass);
            if (doctor.IsNull())
            {
                LoggedIn = false;
                clossingAfterError = true;
                ErrorMessage();
            }
            else
            {
                GlobalVariables.Doctor = doctor;
                LoggedIn = true;
                SplashScreenManager.CloseForm(false);
            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            LoggedIn = false;
            clossingAfterError = false;
            Close();
        }

        private void XtraFormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = clossingAfterError;
            clossingAfterError = false;
        }

        private void ErrorMessage()
        {
            SplashScreenManager.CloseForm(false);
            XtraMessageBox.Show("Kimlik numarası veya şifre hatalı girdiniz.", "Hatalı Bilgi Girişi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void XtraFormLogin_Load(object sender, EventArgs e)
        {
        }
    }
}