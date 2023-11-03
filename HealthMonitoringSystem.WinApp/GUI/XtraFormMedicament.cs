// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormMedicament.cs

#region usings

using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormMedicament : XtraForm
    {
        private Medicament _medicament;
        private bool update;

        public XtraFormMedicament()
        {
            InitializeComponent();
        }

        public XtraFormMedicament(Medicament medicament)
        {
            InitializeComponent();
            this._medicament = medicament;

            if (medicament.UsePerDay != null)
            {
                string[] split = medicament.UsePerDay.ToString().Split(',');

                textEditName.Text = medicament.Name;
                textBoxUseDay.Text = split[0]; // UsePerDay - Gün
                textBoxUsePer.Text = split[1]; // UsePerDay - Adet
            }
            textEditNote.Text = medicament.Note;
            checkEditIsActive.Checked = medicament.IsActive;
            barButtonItemSave.Caption = "Güncelle";
            update = true;
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_medicament == null)
            {
                _medicament = new Medicament
                {
                    Name = textEditName.Text,
                    Note = textEditNote.Text,
                    UsePerDay =
                        Convert.ToDouble(String.Format("{0},{1}", textBoxUseDay.Text.Trim(), textBoxUsePer.Text.Trim())),
                    IsActive = checkEditIsActive.Checked
                };
            }
            else
            {
                _medicament.Name = textEditName.Text;
                _medicament.Note = textEditNote.Text;
                _medicament.UsePerDay =
                    Convert.ToDouble(String.Format("{0},{1}", textBoxUseDay.Text.Trim(), textBoxUsePer.Text.Trim()));
                _medicament.IsActive = checkEditIsActive.Checked;
            }
            Extensions.Extensions.ShowWaitForm(description: "İlaç kaydediliyor...");
            MedicamentManager client = new MedicamentManager();
            ProcessResult processResult = update ? client.Update(_medicament) : client.Insert(_medicament);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                Close();
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void checkEditActive_CheckedChanged(object sender, EventArgs e)
        {
            checkEditIsActive.Text = String.Format("Aktif{0}", checkEditIsActive.Checked ? "" : " Değil");
        }
    }
}