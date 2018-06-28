// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- FormMain.cs

#region usings

using System;
using System.Deployment.Application;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.Resources;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class FormMain : XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
            switch (GlobalVariables.LoggedType)
            {
                case GlobalVariables.LogginType.Doctor:
                    navBarGroupRegistration.Visible = false;
                    navBarGroupManagament.Visible = false;
                    break;

                case GlobalVariables.LogginType.Personnel:
                    navBarGroupOffice.Visible = false;
                    navBarGroupManagament.Visible = false;
                    break;

                case GlobalVariables.LogginType.Admin:
                    navBarGroupOffice.Visible = false;
                    navBarGroupRegistration.Visible = false;
                    break;
                default:
                    navBarControl1.Visible = false;
                    break;
            }
        }

        private void OpenForm(ref XtraForm form)
        {
            XtraForm fo = form;

            XtraForm from = MdiChildren.FirstOrDefault(f => f.Text == fo.Text) as XtraForm;
            if (from != null)
            {
                from.BringToFront();
            }
            else
            {
                form.MdiParent = this;
                form.Show();
            }
            SplashScreenManager.CloseForm(false);
        }

        private void navBarItemDegreeDepartment_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            XtraForm departmantDegree = new XtraFormDepartmantDegree();
            OpenForm(ref departmantDegree);
        }

        private void navBarItem1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            XtraForm form = new XtraFormCityCountry();
            OpenForm(ref form);
        }

        private void navBarItem3_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            XtraForm form = new XtraFormDoctor();
            OpenForm(ref form);
        }

        private void navBarItem4_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Hasta listesi alınıyor...");
            XtraForm form = new XtraFormExaminationDetail();
            OpenForm(ref form);
        }

        private void navBarItemDiagnosisMedicament_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            XtraForm diagnosisMedicament = new XtraFormDiagnosisMedicament();
            OpenForm(ref diagnosisMedicament);
        }

        private void navBarItem5_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            XtraFormThema thema = new XtraFormThema();
            thema.ShowDialog();
            SplashScreenManager.CloseForm(false);
        }

        private void navBarItemPatient_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            XtraForm form = new XtraFormPatientDetail();
            OpenForm(ref form);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment deployment = ApplicationDeployment.CurrentDeployment;
                if (deployment.IsFirstRun)
                {
                    DialogResult result = XtraMessageBox.Show(
                        "Arayüz ileri özellikleri için Türkçe dil dosyaları mevcut. Şimdi indirmek ister misiniz?",
                        "Dil Dosyası Yükle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        XtraFormDownloadLanguages languages = new XtraFormDownloadLanguages("Türkçe", "tr");
                        languages.ShowDialog();
                        result = Extensions.Extensions.AccepttoResetApp();
                        if (result == DialogResult.Yes)
                            Application.Restart();
                    }
                }
            }
        }

        private void LanguagenavBarItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            XtraFormDownloadLanguages languages = new XtraFormDownloadLanguages("Türkçe", "tr");
            languages.ShowDialog();
            if (Extensions.Extensions.AccepttoResetApp() == DialogResult.Yes)
            {
                Extensions.Extensions.ResetApplication();
            }
        }

        private void navBarItemCoonection_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string old = GlobalVariables.ServiceRoot;
            XtraFormService form = new XtraFormService();
            form.ShowDialog();
            if (String.CompareOrdinal(old, GlobalVariables.ServiceRoot) != 0)
            {
                if (Extensions.Extensions.AccepttoResetApp() == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void navBarItemRendezvous_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Sistemden randevu bilgileri sorgulanıyor");
            XtraForm form = new XtraFormRendezvous();
            OpenForm(ref form);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.Doctor.IsNotNull())
            {
                Text = String.Format("Safer Hastane Yönetim Sistemi (Mevcut Kullanıcı:{1} {0})",
                    GlobalVariables.Doctor.Name + " " + GlobalVariables.Doctor.Surname,
                    GlobalVariables.Doctor.Degree.ShortName);
            }
            else if (GlobalVariables.Personnel.IsNotNull())
            {
                Text = String.Format("Safer Hastane Yönetim Sistemi (Mevcut Kullanıcı: {0})",
                    GlobalVariables.Personnel.Name + " " + GlobalVariables.Personnel.Surname);
            }
        }

        private void navBarItemHoliday_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            XtraForm form = new XtraFormHolidayDetails();
            OpenForm(ref form);
        }
    }
}