// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDegree.cs

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
    public partial class XtraFormDegree : XtraForm
    {
        private Degree _degree;
        private bool update;

        public XtraFormDegree()
        {
            InitializeComponent();
        }

        public XtraFormDegree(Degree degree)
        {
            InitializeComponent();
            _degree = degree;
            update = true;
            textEditName.Text = degree.Name;
            textEditShortName.Text = degree.ShortName;
            checkEditActive.Checked = degree.IsActive;
            barButtonItemSave.Caption = "Güncelle";
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Ünvan kaydediliyor...");
            DegreeManager client = new DegreeManager();


            if (_degree == null)
            {
                _degree = new Degree
                {
                    Name = textEditName.Text,
                    ShortName = textEditShortName.Text,
                    IsActive = checkEditActive.Checked,
                    IsAdmin = checkEditAdmin.Checked
                };
            }
            else
            {
                _degree.Name = textEditName.Text;
                _degree.ShortName = textEditShortName.Text;
                _degree.IsActive = checkEditActive.Checked;
                _degree.IsAdmin = checkEditAdmin.Checked;
            }

            ProcessResult result = update ? client.Update(_degree) : client.Insert(_degree);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(result.Errors, (int) result.Result);

            if (result.Result == Entity.Classes.Extensions.BLLResult.Success)
                Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void checkEditAdmin_CheckedChanged(object sender, EventArgs e)
        {
            checkEditAdmin.Text = String.Format("Yönetici{0}", checkEditAdmin.Checked ? String.Empty : " Değil");
        }

        private void checkEditActive_CheckedChanged(object sender, EventArgs e)
        {
            checkEditActive.Text = String.Format("Aktif{0}", checkEditActive.Checked ? String.Empty : " Değil");
        }
    }
}