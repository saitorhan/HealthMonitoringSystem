// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDepartment.cs

#region usings

using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;
using HealthMonitoringSystem.WinApp.DepartmentService;
using HealthMonitoringSystem.WinApp.Extensions;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormDepartment : XtraForm
    {
        private Department _department;
        private bool update;

        public XtraFormDepartment()
        {
            InitializeComponent();
        }

        public XtraFormDepartment(Department department)
        {
            InitializeComponent();
            this._department = department;
            textEditName.Text = _department.Name;
            checkEditIsActive.Checked = _department.IsActive;
            barButtonItemSave.Caption = "Güncelle";
            update = true;
        }


        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Departman kaydediliyor...");
            DepartmentManager client = new DepartmentManager();

            if (_department == null)
            {
                _department = new Department
                {
                    Name = textEditName.Text,
                    IsActive = checkEditIsActive.Checked,
                    MinAge = textEditMin.Text.ToNullableInt32(),
                    MaxAge = Text.ToNullableInt32(),
                    Gender = lookUpEditGender.EditValue as bool?
                };
            }
            else
            {
                _department.Name = textEditName.Text;
                _department.IsActive = checkEditIsActive.Checked;
                _department.MinAge = textEditMin.Text.ToNullableInt32();
                _department.MaxAge = textEditMax.Text.ToNullableInt32();
                _department.Gender = lookUpEditGender.EditValue as bool?;
            }

            ProcessResult processResult = update ? client.Update(_department) : client.Insert(_department);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                Close();
        }

        private void checkEditIsActive_CheckedChanged(object sender, EventArgs e)
        {
            checkEditIsActive.Text = String.Format("Aktif{0}", checkEditIsActive.Checked ? "" : " Değil");
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void XtraFormDepartment_Load(object sender, EventArgs e)
        {
            Dictionary<string, bool?> genderDictionary = new Dictionary<string, bool?>
            {
                {"Herkes", null},
                {"Erkek", true},
                {"Kadın", false}
            };

            lookUpEditGender.Properties.DataSource = genderDictionary;
        }
    }
}