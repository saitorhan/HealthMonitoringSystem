// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- Extensions.cs

#region usings

using System;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.BloodGroupService;
using HealthMonitoringSystem.WinApp.CityService;
using HealthMonitoringSystem.WinApp.CounrtyService;
using HealthMonitoringSystem.WinApp.DegreeService;
using HealthMonitoringSystem.WinApp.DepartmentService;
using HealthMonitoringSystem.WinApp.DiagnosisService;
using HealthMonitoringSystem.WinApp.DoctorMailService;
using HealthMonitoringSystem.WinApp.DoctorPhoneService;
using HealthMonitoringSystem.WinApp.DoctorService;
using HealthMonitoringSystem.WinApp.ExaminationService;
using HealthMonitoringSystem.WinApp.GUI;
using HealthMonitoringSystem.WinApp.LaboratoryRequestItemService;
using HealthMonitoringSystem.WinApp.LaboratoryRequestService;
using HealthMonitoringSystem.WinApp.LaboratoryRequestTypeService;
using HealthMonitoringSystem.WinApp.MedicamentService;
using HealthMonitoringSystem.WinApp.MessageService;
using HealthMonitoringSystem.WinApp.PatientService;
using HealthMonitoringSystem.WinApp.PrescriptionItemService;
using HealthMonitoringSystem.WinApp.PrescriptionService;
using HealthMonitoringSystem.WinApp.RendezvousService;
using HealthMonitoringSystem.WinApp.RendezvousTimeService;
using HealthMonitoringSystem.WinApp.Resources;
using HealthMonitoringSystem.WinApp.SystemService;
using ExtensionsBLLResult = HealthMonitoringSystem.WinApp.CityService.ExtensionsBLLResult;

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

        public static DepartmentSolClient getDepartmentSolClient()
        {
            DepartmentSolClient client;
            try
            {
                client = new DepartmentSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DepartmentService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new DepartmentSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DepartmentService.svc")));
            }

            return client;
        }

        public static DegreeSolClient GetDegreeSolClient()
        {
            DegreeSolClient client;
            try
            {
                client = new DegreeSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DegreeService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new DegreeSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DegreeService.svc")));
            }

            return client;
        }

        public static HolidayService.HolidaySolClient GetHolidaySolClient()
        {
            HolidayService.HolidaySolClient client;
            try
            {
                client = new HolidayService.HolidaySolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "HolidayService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new HolidayService.HolidaySolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "HolidayService.svc")));
            }

            return client;
        }

        public static void ProcessResultMessage(string process, bool result = true)
        {
            string text = String.Format("{0} işlemi başarı{1} oldu.", process, result ? "lı" : "sız");
            string title = String.Format("İşlem Başarı{0}", result ? "lı" : "sız");
            MessageBoxIcon icon = result ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            XtraMessageBox.Show(text, title, MessageBoxButtons.OK, icon);
        }

        public static void ProcessResultMessage(string[] errorsList, int result)
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
                case (int) ExtensionsBLLResult.Success:
                    icon = MessageBoxIcon.Information;
                    title = "Bilgi";
                    break;
                case (int) ExtensionsBLLResult.NotVerified:
                    icon = MessageBoxIcon.Warning;
                    title = "Eksik veya Hatalı Giriş";
                    break;
                case (int) ExtensionsBLLResult.InnerException:
                    icon = MessageBoxIcon.Error;
                    title = "Hata";
                    break;
                case (int) ExtensionsBLLResult.Verified:
                    icon = MessageBoxIcon.Information;
                    title = "Bilgi";
                    break;
                case (int) ExtensionsBLLResult.AlreadyFound:
                    icon = MessageBoxIcon.Hand;
                    title = "Hata!";
                    break;
                case (int) ExtensionsBLLResult.Referanced:
                    icon = MessageBoxIcon.Stop;
                    title = "Uyarı!";
                    break;
                case (int) ExtensionsBLLResult.NotFound:
                    icon = MessageBoxIcon.None;
                    title = "Hata!";
                    break;
                case (int) ExtensionsBLLResult.ServerDisable:
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

        public static CitySolClient GetCityServiceSol()
        {
            CitySolClient client;
            try
            {
                client = new CitySolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "CityService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new CitySolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "CityService.svc")));
            }

            return client;
        }

        public static CountrySolClient GetCountrySolService()
        {
            CountrySolClient client;
            try
            {
                client = new CountrySolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "CountryService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new CountrySolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "CountryService.svc")));
            }

            return client;
        }

        public static DoctorSolClient GetDoctorSolClient()
        {
            DoctorSolClient client;
            try
            {
                client = new DoctorSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DoctorService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new DoctorSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DoctorService.svc")));
            }

            return client;
        }

        public static DoctorMailSolClient GetDoctorMailClient()
        {
            DoctorMailSolClient client;
            try
            {
                client = new DoctorMailSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DoctorMailService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new DoctorMailSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DoctorMailService.svc")));
            }

            return client;
        }

        public static DoctorPhoneSolClient GetDoctorPhoneSolClient()
        {
            DoctorPhoneSolClient client;
            try
            {
                client = new DoctorPhoneSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DoctorPhoneService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new DoctorPhoneSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "DoctorPhoneService.svc")));
            }

            return client;
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


        internal static DiagnosisSolClient GetDiagnosisSolClient()
        {
            DiagnosisSolClient client;
            try
            {
                client = new DiagnosisSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "diagnosisservice.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new DiagnosisSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "diagnosisservice.svc")));
            }

            return client;
        }

        internal static MedicamentSolClient GetMedicamentSolClient()
        {
            MedicamentSolClient client;
            try
            {
                client = new MedicamentSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "medicamentservice.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new MedicamentSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "medicamentservice.svc")));
            }

            return client;
        }

        public static LaboratoryRequestTypeSolClient GetLaboratoryRequestType()
        {
            LaboratoryRequestTypeSolClient client;
            try
            {
                client = new LaboratoryRequestTypeSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}",
                        "LaboratoryRequestTypeService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new LaboratoryRequestTypeSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}",
                        "LaboratoryRequestTypeService.svc")));
            }

            return client;
        }

        public static ExaminationSolClient GetExaminationService()
        {
            ExaminationSolClient client;
            try
            {
                client = new ExaminationSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "ExaminationService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new ExaminationSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "ExaminationService.svc")));
            }

            return client;
        }

        public static LaboratoryRequestSolClient GetLaboratoryRequest()
        {
            LaboratoryRequestSolClient client;
            try
            {
                client = new LaboratoryRequestSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "LaboratoryRequest.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new LaboratoryRequestSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "LaboratoryRequest.svc")));
            }

            return client;
        }

        public static LaboratoryRequestItemSolClient GetLaboratoryRequestItem()
        {
            LaboratoryRequestItemSolClient client;
            try
            {
                client = new LaboratoryRequestItemSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}",
                        "LaboratoryRequestItemService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new LaboratoryRequestItemSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}",
                        "LaboratoryRequestItemService.svc")));
            }

            return client;
        }

        public static PrescriptionSolClient GetPrescriptionService()
        {
            PrescriptionSolClient client;
            try
            {
                client = new PrescriptionSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "PrescriptionService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new PrescriptionSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "PrescriptionService.svc")));
            }

            return client;
        }

        public static PatientSolClient GetPatientClient()
        {
            PatientSolClient client;
            try
            {
                client = new PatientSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "PatientService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new PatientSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "PatientService.svc")));
            }

            return client;
        }

        public static DialogResult AccepttoResetApp()
        {
            return
                XtraMessageBox.Show(
                    "Yeni yüklenen özelliklerin etkinleştirilebilmesi için programı yeniden başlatılması gerekmektir.\nŞimdi yeniden başlatılsın mı?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static BloodGroupSolClient GetBloodGroups()
        {
            BloodGroupSolClient client;
            try
            {
                client = new BloodGroupSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "BloodGroupService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new BloodGroupSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "BloodGroupService.svc")));
            }

            return client;
        }

        public static RendezvousTimeSolClient GetRendezvousTimeService()
        {
            RendezvousTimeSolClient client;
            try
            {
                client = new RendezvousTimeSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "RendezvousTimeService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new RendezvousTimeSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "RendezvousTimeService.svc")));
            }

            return client;
        }

        public static RendezvousSolClient GetRendezvousService()
        {
            RendezvousSolClient client;
            try
            {
                client = new RendezvousSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "RendezvousService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new RendezvousSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "RendezvousService.svc")));
            }

            return client;
        }

        public static SystemSolClient GetSystemManager()
        {
            SystemSolClient client;
            try
            {
                client = new SystemSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "systemservice.svc")));
                client.Test();
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new SystemSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "systemservice.svc")));
            }

            return client;
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

        public static MessageSolClient GetMessageService()
        {
            MessageSolClient client;
            try
            {
                client = new MessageSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "messageservice.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new MessageSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}", "messageservice.svc")));
            }

            return client;
        }

        public static PrescriptionItemSolClient GetPresItemsService()
        {
            PrescriptionItemSolClient client;
            try
            {
                client = new PrescriptionItemSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}",
                        "PrescriptionItemService.svc")));
                client.Select(-1);
            }
            catch (Exception)
            {
                bool b = Program.TestService();
                if (!b)
                    Application.Exit();
                client = new PrescriptionItemSolClient(binding,
                    new EndpointAddress(String.Format(GlobalVariables.ServiceRoot + "/{0}",
                        "PrescriptionItemService.svc")));
            }

            return client;
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