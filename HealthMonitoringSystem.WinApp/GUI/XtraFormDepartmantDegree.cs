// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDepartmantDegree.cs

#region usings

using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.DegreeService;
using HealthMonitoringSystem.WinApp.DepartmentService;
using HealthMonitoringSystem.WinApp.Extensions;
using Degree = HealthMonitoringSystem.WinApp.DegreeService.Degree;
using ExtensionsBLLResult = HealthMonitoringSystem.WinApp.DepartmentService.ExtensionsBLLResult;
using ProcessResult = HealthMonitoringSystem.WinApp.DepartmentService.ProcessResult;

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
                DepartmentSolClient client = Extensions.Extensions.getDepartmentSolClient();
                bindingSourceDepartment.DataSource = client.Departments(true, false).ToList();
                client.Close();
            }

            if (i == 0 || i == 2)
            {
                DegreeSolClient client1 = Extensions.Extensions.GetDegreeSolClient();
                bindingSourceDegree.DataSource = client1.Degrees(true);

                client1.Close();
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
            DepartmentSolClient client = Extensions.Extensions.getDepartmentSolClient();
            ProcessResult processResult = client.Delete(department.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == ExtensionsBLLResult.Success)
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
            DegreeSolClient client = Extensions.Extensions.GetDegreeSolClient();
            DegreeService.ProcessResult processResult = client.Delete(department.Id);
            SplashScreenManager.CloseForm(false);
            Extensions.Extensions.ProcessResultMessage(processResult.Errors, (int) processResult.Result);
            if (processResult.Result == DegreeService.ExtensionsBLLResult.Success)
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