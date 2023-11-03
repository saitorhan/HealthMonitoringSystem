// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDiagnosisMedicament.cs

#region usings

using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;
using HealthMonitoringSystem.WinApp.Extensions;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormDiagnosisMedicament : XtraForm
    {
        public XtraFormDiagnosisMedicament()
        {
            InitializeComponent();
        }

        private void RefreshData(int i)
        {
            if (i == 0 || i == 1)
            {
                DiagnosisManager client = new DiagnosisManager();
                bindingSourceDiagnosis.DataSource = client.Diagnoses(null, true).ToList();
                
            }

            if (i == 0 || i == 2)
            {
                MedicamentManager client1 = new MedicamentManager();
                bindingSourceMedicament.DataSource = client1.Medicaments(true);

            }
        }

        private void XtraFormDiagnosisMedicament_Load(object sender, EventArgs e)
        {
            RefreshData(0);
        }

        private void barButtonItemAddNewDiagnosis_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormDiagnosis form = new XtraFormDiagnosis();
            form.ShowDialog();
            RefreshData(1);
        }

        private void barButtonItemEditDiagnosis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Diagnosis selectedDiagnosis = bindingSourceDiagnosis.Current as Diagnosis;
            if (selectedDiagnosis.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }
            XtraFormDiagnosis formDiagnosis = new XtraFormDiagnosis(selectedDiagnosis);
            formDiagnosis.ShowDialog();
        }

        private void barButtonItemDeleteDiagnosis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Diagnosis diagnosis = bindingSourceDiagnosis.Current as Diagnosis;
            if (diagnosis.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }

            if (Extensions.Extensions.DeletingAlert(diagnosis.Name) != DialogResult.Yes)
                return;
            Extensions.Extensions.ShowWaitForm(description: "İlaç siliniyor...");
            DiagnosisManager client = new DiagnosisManager();
            ProcessResult processResult = client.Delete(diagnosis.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                RefreshData(1);
        }

        private void barButtonItemAddNewMedicament_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormMedicament medicament = new XtraFormMedicament();
            medicament.ShowDialog();
            RefreshData(2);
        }

        private void barButtonItemEditMedicament_ItemClick(object sender, ItemClickEventArgs e)
        {
            Medicament medicament = bindingSourceMedicament.Current as Medicament;

            if (medicament.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }

            XtraFormMedicament xtraFormMedicament = new XtraFormMedicament(medicament);
            xtraFormMedicament.ShowDialog();
            RefreshData(2);
        }

        private void barButtonItemDeleteMedicament_ItemClick(object sender, ItemClickEventArgs e)
        {
            Medicament medicament = bindingSourceMedicament.Current as Medicament;
            if (medicament.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDelete();
                return;
            }

            if (Extensions.Extensions.DeletingAlert(medicament.Name) != DialogResult.Yes)
                return;
            Extensions.Extensions.ShowWaitForm(description: "Hastalık ismi siliniyor...");
            MedicamentManager client = new MedicamentManager();
            ProcessResult processResult = client.Delete(medicament.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                RefreshData(2);
        }

        private void barButtonItemRefreshDiagnosis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Hastalıklar listesi yenileniyor...");
            RefreshData(1);
            SplashScreenManager.CloseForm(false);
        }

        private void barButtonItemRefreshMed_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "İlaç listesi yenileniyor...");
            RefreshData(2);
            SplashScreenManager.CloseForm(false);
        }
    }
}