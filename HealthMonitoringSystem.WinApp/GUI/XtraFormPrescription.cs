// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormPrescription.cs

#region usings

using System;
using System.Collections.Generic;
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
    public partial class XtraFormPrescription : XtraForm
    {
        public ProcessResult result;
        private Examination _examination;
        private Prescription prescription = new Prescription {IsActive = true};
        private List<PrescriptionItem> prescriptionItems = new List<PrescriptionItem>();

        public XtraFormPrescription(Examination examination)
        {
            _examination = examination;
            prescription.ExaminationId = _examination.Id;
            prescription.Examination = new Examination
            {
                Id = _examination.Id,
                PatientId = _examination.PatientId,
                DoctorId = _examination.DoctorId,
                Time = _examination.Time,
                DoctorNote = _examination.DoctorNote,
                CanSendMessage = _examination.CanSendMessage,
                NextTime = _examination.NextTime,
                RendezvousId = _examination.RendezvousId,
                IsActive = _examination.IsActive,
                DiagnosisId = _examination.DiagnosisId
            };

            InitializeComponent();
            Text = String.Format("Reçete Yaz: {0}", _examination.Patient.NameSurname);
            if (GlobalVariables.Medicaments.IsNull())
            {
                MedicamentManager client = new MedicamentManager();
                GlobalVariables.Medicaments = client.Medicaments(true).ToList();
                SplashScreenManager.CloseForm(false);
            }
            bindingSourceAllMedicaments.DataSource = GlobalVariables.Medicaments;
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void XtraFormPrescription_Load(object sender, EventArgs e)
        {
        }

        private void gridControlAllMedicaments_MouseClick(object sender, MouseEventArgs e)
        {
            int[] selectedRows = gridViewAllMedicament.GetSelectedRows();

            int[] ints = prescriptionItems.Select(p => p.MedicamentId).ToArray();

            ints = ints.Where(p => !selectedRows.Contains(p)).ToArray();

            foreach (int i in ints)
            {
                prescriptionItems.Remove(prescriptionItems.FirstOrDefault(p => p.MedicamentId == i));
            }

            foreach (int row in selectedRows)
            {
                Medicament medicament = gridViewAllMedicament.GetRow(row) as Medicament;
                if (medicament != null)
                {
                    if (prescriptionItems.All(p => p.MedicamentId != medicament.Id))
                    {
                        prescriptionItems.Add(new PrescriptionItem
                        {
                            Medicament =
                                new Medicament
                                {
                                    Id = medicament.Id,
                                    Name = medicament.Name,
                                    IsActive = medicament.IsActive,
                                    UsePerDay = medicament.UsePerDay,
                                    Note = medicament.Note
                                },
                            MedicamentId = medicament.Id,
                            IsActive = true
                        });
                    }
                }
            }

            bindingSourcePrescriptionItems.DataSource = prescriptionItems;
            gridControlPrescriptionItems.RefreshDataSource();
        }


        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            prescription.PrescriptionItems = prescriptionItems.Select(i => new PrescriptionItem
            {
                MedicamentId = i.MedicamentId,
                UsePerDay = i.UsePerDay,
                DoctorNote = i.DoctorNote,
                IsActive = true
            }).ToArray();

            Extensions.Extensions.ShowWaitForm(description: "Reçeye sisteme kaydediliyor...");

            PrescriptionManager client = new PrescriptionManager();
            if (client.IsNull())
            {
                return;
            }
            result = client.Insert(prescription);

            SplashScreenManager.CloseForm(false);

            Extensions.Extensions.ProcessResultMessage(result.Errors, (int) result.Result);
            if (result.Result == Entity.Classes.Extensions.BLLResult.Success)
                Close();
        }


        private void barButtonItemAddCommand_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormAddCommandToPres commandToPres = new XtraFormAddCommandToPres(prescription.DoctorNote);
            commandToPres.ShowDialog();
            prescription.DoctorNote = commandToPres.Command;
        }

        private void XtraFormPrescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (result == null)
            {
                result = new ProcessResult
                {
                    Result = Entity.Classes.Extensions.BLLResult.NotVerified
                };
            }
        }
    }
}