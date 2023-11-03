// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDiagnosis.cs

#region usings

using System;
using System.Collections.Generic;
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
    public partial class XtraFormDiagnosis : XtraForm
    {
        private Diagnosis _diagnosis;
        private bool update;

        public XtraFormDiagnosis()
        {
            InitializeComponent();
        }

        public XtraFormDiagnosis(Diagnosis diagnosis)
        {
            InitializeComponent();
            this._diagnosis = diagnosis;
            textEditName.Text = _diagnosis.Name;
            checkEditIsAktive.Checked = _diagnosis.IsActive;
            barButtonItemSave.Caption = "Güncelle";
            update = true;
        }

        private void XtraFormDiagnosis_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.Departments.IsNull())
            {
                DepartmentManager client = new DepartmentManager();
                GlobalVariables.Departments = new List<Department>(client.Departments(true, false));
            }
            departmentBindingSource.DataSource = GlobalVariables.Departments;
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_diagnosis == null)
            {
                _diagnosis = new Diagnosis
                {
                    Name = textEditName.Text,
                    DepartmentId = (int) (gridLookUpEditDep.EditValue.IsNull() ? 0 : gridLookUpEditDep.EditValue),
                    IsActive = checkEditIsAktive.Checked
                };
            }
            else
            {
                _diagnosis.Name = textEditName.Text;
                _diagnosis.DepartmentId = (int) (gridLookUpEditDep.EditValue.IsNull() ? 0 : gridLookUpEditDep.EditValue);
                _diagnosis.IsActive = checkEditIsAktive.Checked;
            }

            Extensions.Extensions.ShowWaitForm(description: "Hastalık ismi kaydediliyor...");

            DiagnosisManager client = new DiagnosisManager();
            ProcessResult processResult = update ? client.Update(_diagnosis) : client.Insert(_diagnosis);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                Close();
        }

        private void checkEditAktive_CheckedChanged(object sender, EventArgs e)
        {
            checkEditIsAktive.Text = String.Format("Aktif{0}", checkEditIsAktive.Checked ? "" : " Değil");
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}