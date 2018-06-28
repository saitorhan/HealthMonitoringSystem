// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormLaboratuvarRequest.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.LaboratoryRequestService;
using HealthMonitoringSystem.WinApp.LaboratoryRequestTypeService;
using HealthMonitoringSystem.WinApp.Resources;
using LaboratoryRequest = HealthMonitoringSystem.WinApp.LaboratoryRequestService.LaboratoryRequest;
using LaboratoryRequestItem = HealthMonitoringSystem.WinApp.LaboratoryRequestService.LaboratoryRequestItem;
using LaboratoryRequestType = HealthMonitoringSystem.WinApp.LaboratoryRequestTypeService.LaboratoryRequestType;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormLaboratuvarRequest : XtraForm
    {
        private int examinationId;
        public bool Result;

        public XtraFormLaboratuvarRequest(int examinationId)
        {
            this.examinationId = examinationId;
            InitializeComponent();
        }

        private void XtraFormLaboratuvarRequest_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.LaboratoryRequestTypes.IsNull())
            {
                LaboratoryRequestTypeSolClient client =
                    Extensions.Extensions.GetLaboratoryRequestType();
                GlobalVariables.LaboratoryRequestTypes = client.LaboratoryRequestTypes(true).ToList();
                client.Close();
            }


            bindingSourceItems.DataSource = GlobalVariables.LaboratoryRequestTypes;
            SplashScreenManager.CloseForm(false);
        }

        private void barButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();

            List<int> selectedItems =
                selectedRows.Select(i => (gridView1.GetRow(i) as LaboratoryRequestType).Id).ToList();

            LaboratoryRequestItem[] requestItems = selectedItems.Select(item => new LaboratoryRequestItem
            {
                LaboratoryRequestId = 0,
                LaboratoryRequestTypeId = item
            }).ToArray();

            Extensions.Extensions.ShowWaitForm(description: "Laboratuvar isteği kaydediliyor...");

            LaboratoryRequestSolClient client = Extensions.Extensions.GetLaboratoryRequest();
            LaboratoryRequest request = new LaboratoryRequest
            {
                ExaminationId = examinationId,
                IsActive = true,
                LaboratoryRequestItems = requestItems
            };

            Result = client.Insert(request);

            SplashScreenManager.CloseForm(false);

            Extensions.Extensions.ProcessResultMessage("Laboratuvar isteği oluşturma", Result);
            Close();
        }
    }
}