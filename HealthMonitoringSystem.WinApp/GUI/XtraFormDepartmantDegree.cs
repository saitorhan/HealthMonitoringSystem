// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDepartmantDegree.cs

#region usings

using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;
using HealthMonitoringSystem.WinApp.Extensions;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormDepartmantDegree : XtraForm
    {
        public XtraFormDepartmantDegree()
        {
            InitializeComponent();
        }

        private void RefreshData(int i)
        {
            if (i == 0 || i == 1)
            {
                DepartmentManager client = new DepartmentManager();
                bindingSourceDepartment.DataSource = client.Departments(true, false).ToList();
            }

            if (i == 0 || i == 2)
            {
                DegreeManager client1 = new DegreeManager();
                bindingSourceDegree.DataSource = client1.Degrees(true);
            }
        }

        private void XtraFormDepartmantDegree_Load(object sender, EventArgs e)
        {
            RefreshData(0);
        }

        private void barButtonItemAddNewDep_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormDepartment form = new XtraFormDepartment();
            form.ShowDialog();
            RefreshData(1);
        }

        private void barButtonItemEditDep_ItemClick(object sender, ItemClickEventArgs e)
        {
            Department selectedDepartment = bindingSourceDepartment.Current as Department;
            if (selectedDepartment.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }

            XtraFormDepartment formDepartment = new XtraFormDepartment(selectedDepartment);
            formDepartment.ShowDialog();
            RefreshData(1);
        }

        private void barButtonItemDeleteDep_ItemClick(object sender, ItemClickEventArgs e)
        {
            Department department = bindingSourceDepartment.Current as Department;
            if (department.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDelete();
                return;
            }

            if (Extensions.Extensions.DeletingAlert(department.Name) != DialogResult.Yes) return;

            Extensions.Extensions.ShowWaitForm(description: "Departman siliniyor...");
            DepartmentManager client = new DepartmentManager();
            ProcessResult processResult = client.Delete(department.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                RefreshData(1);
        }

        private void barButtonItemAddNewDeg_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraFormDegree degree = new XtraFormDegree();
            degree.ShowDialog();
            RefreshData(2);
        }

        private void barButtonItemEditDeg_ItemClick(object sender, ItemClickEventArgs e)
        {
            Degree degree = bindingSourceDegree.Current as Degree;

            if (degree.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForEdit();
                return;
            }

            XtraFormDegree xtraFormDegreedegree = new XtraFormDegree(degree);
            xtraFormDegreedegree.ShowDialog();
            RefreshData(2);
        }

        private void gridControlDeps_Click(object sender, EventArgs e)
        {
        }

        private void repositoryItemTextEdit1_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            bool? gender = e.Value as bool?;

            if (gender == null)
            {
                e.DisplayText = "Herkes";
            }
            else if (gender == true)
            {
                e.DisplayText = "Erkek";
            }
            else if (gender == false)
            {
                e.DisplayText = "Kadın";
            }
        }

        private void barButtonItemDeleteDeg_ItemClick(object sender, ItemClickEventArgs e)
        {
            Degree department = bindingSourceDegree.Current as Degree;
            if (department.IsNull())
            {
                Extensions.Extensions.ObjectNotSelectedForDelete();
                return;
            }

            if (Extensions.Extensions.DeletingAlert(department.Name) != DialogResult.Yes)
                return;

            Extensions.Extensions.ShowWaitForm(description: "Departman siliniyor...");
            DegreeManager client = new DegreeManager();
            ProcessResult processResult = client.Delete(department.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == Entity.Classes.Extensions.BLLResult.Success)
                RefreshData(2);
        }

        private void barButtonItemRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Departman listesi yenileniyor...");
            RefreshData(1);
            SplashScreenManager.CloseForm(false);
        }

        private void barButtonItemRefreshCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            Extensions.Extensions.ShowWaitForm(description: "Ünvan listesi yenileniyor...");
            RefreshData(2);
            SplashScreenManager.CloseForm(false);
        }
    }
}