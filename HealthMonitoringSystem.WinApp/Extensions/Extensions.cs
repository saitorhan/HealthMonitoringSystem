// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- Extensions.cs

#region usings

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.DepartmentService;
using HealthMonitoringSystem.WinApp.ExaminationService;
using HealthMonitoringSystem.WinApp.GUI;
using HealthMonitoringSystem.WinApp.MessageService;
using HealthMonitoringSystem.WinApp.PatientService;
using HealthMonitoringSystem.WinApp.PrescriptionService;
using HealthMonitoringSystem.WinApp.Resources;

#endregion

namespace HealthMonitoringSystem.WinApp.Extensions
{
    public static class Extensions
    {
        private static readonly BasicHttpBinding binding = new BasicHttpBinding
        {
            MaxReceivedMessageSize = 20000000,
            MaxBufferSize = 20000000,
            MaxBufferPoolSize = 20000000,
            OpenTimeout = new TimeSpan(0, 2, 0),
            CloseTimeout = new TimeSpan(0, 2, 0),
            ReceiveTimeout = new TimeSpan(0, 2, 0),
            SendTimeout = new TimeSpan(0, 2, 0)
        };


        public static void ProcessResultMessage(string process, bool result = true)
        {
            string text = String.Format("{0} işlemi başarı{1} oldu.", process, result ? "lı" : "sız");
            string title = String.Format("İşlem Başarı{0}", result ? "lı" : "sız");
            MessageBoxIcon icon = result ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            XtraMessageBox.Show(text, title, MessageBoxButtons.OK, icon);
        }

        public static void ProcessResultMessage(List<string> errorsList, int result)
        {
            StringBuilder builder = new StringBuilder();
            string title;
            MessageBoxIcon icon;

            foreach (string s in errorsList)
            {
                builder.AppendLine(s);
            }

            switch (result)
            {
                case (int)Entity.Classes.Extensions.BLLResult.Success:
                    icon = MessageBoxIcon.Information;
                    title = "Bilgi";
                    break;
                case (int)Entity.Classes.Extensions.BLLResult.NotVerified:
                    icon = MessageBoxIcon.Warning;
                    title = "Eksik veya Hatalı Giriş";
                    break;
                case (int)Entity.Classes.Extensions.BLLResult.InnerException:
                    icon = MessageBoxIcon.Error;
                    title = "Hata";
                    break;
                case (int)Entity.Classes.Extensions.BLLResult.Verified:
                    icon = MessageBoxIcon.Information;
                    title = "Bilgi";
                    break;
                case (int)Entity.Classes.Extensions.BLLResult.AlreadyFound:
                    icon = MessageBoxIcon.Hand;
                    title = "Hata!";
                    break;
                case (int)Entity.Classes.Extensions.BLLResult.Referanced:
                    icon = MessageBoxIcon.Stop;
                    title = "Uyarı!";
                    break;
                case (int)Entity.Classes.Extensions.BLLResult.NotFound:
                    icon = MessageBoxIcon.None;
                    title = "Hata!";
                    break;
                case (int)Entity.Classes.Extensions.BLLResult.ServerDisable:
                    icon = MessageBoxIcon.Stop;
                    title = "Sistem Hatası!";
                    break;
                default:
                    icon = MessageBoxIcon.Information;
                    title = "Bilgi!";
                    break;
            }

            XtraMessageBox.Show(builder.ToString(), title, MessageBoxButtons.OK, icon);
        }

        public static DialogResult DeletingAlert(string name)
        {
            return XtraMessageBox.Show(String.Format("{0} silinecek onaylıyor musunuz?", name), "Uyarı!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        public static void ObjectNotSelectedForEdit()
        {
            XtraMessageBox.Show("Düzenlemek için herhangi bir seçim yapmadınız.", "Uyarı!", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void ObjectNotSelectedForDetails()
        {
            XtraMessageBox.Show("Görüntülemek için herhangi bir seçim yapmadınız.", "Uyarı!", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void ObjectNotSelectedForDelete()
        {
            XtraMessageBox.Show("Silmek için herhangi bir seçim yapmadınız.", "Uyarı!", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }



        public static DialogResult AccepttoResetApp()
        {
            return
                XtraMessageBox.Show(
                    "Yeni yüklenen özelliklerin etkinleştirilebilmesi için programı yeniden başlatılması gerekmektir.\nŞimdi yeniden başlatılsın mı?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }



        public static void ShowWaitForm(string caption = "Lütfen işlem yapılırken bekleyiniz",
            string description = "Yükleniyor...")
        {
            try
            {
                SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            }
            catch (Exception)
            {
                SplashScreenManager.CloseForm(false);
                SplashScreenManager.ShowForm(typeof (WaitFormLoading));
            }
            SplashScreenManager.Default.SetWaitFormCaption(caption);
            SplashScreenManager.Default.SetWaitFormDescription(description);
        }



        public static void ResetApplication()
        {
            Application.Restart();
        }

        public static void ShowDisableServer()
        {
            XtraMessageBox.Show("Sunucu ile bağlantı kurulamadı. Sistem yöneticiniz ile iletişime geçiniz.",
                "Sistem Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}