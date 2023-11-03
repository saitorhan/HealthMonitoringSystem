using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using HealthMonitoringSystem.Entity;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormPatientDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormPatientDetail));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDetail = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlPatients = new DevExpress.XtraGrid.GridControl();
            this.bindingSourcePatients = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBloodGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemNew,
            this.barButtonItemEdit,
            this.barButtonItemDelete,
            this.barButtonItemDetail,
            this.barButtonItemRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(787, 96);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemNew
            // 
            this.barButtonItemNew.Caption = "Yeni";
            this.barButtonItemNew.Id = 1;
            this.barButtonItemNew.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemNew.Name = "barButtonItemNew";
            this.barButtonItemNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNew_ItemClick);
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Düzenle";
            this.barButtonItemEdit.Id = 2;
            this.barButtonItemEdit.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Sil";
            this.barButtonItemDelete.Id = 3;
            this.barButtonItemDelete.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemDetail
            // 
            this.barButtonItemDetail.Caption = "Detay";
            this.barButtonItemDetail.Id = 4;
            this.barButtonItemDetail.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.note;
            this.barButtonItemDetail.Name = "barButtonItemDetail";
            this.barButtonItemDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDetail_ItemClick);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Yenile";
            this.barButtonItemRefresh.Id = 5;
            this.barButtonItemRefresh.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.refresh;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDetail);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Hasta İşlemleri";
            // 
            // gridControlPatients
            // 
            this.gridControlPatients.DataSource = this.bindingSourcePatients;
            this.gridControlPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPatients.Location = new System.Drawing.Point(0, 96);
            this.gridControlPatients.MainView = this.gridView1;
            this.gridControlPatients.MenuManager = this.ribbonControl1;
            this.gridControlPatients.Name = "gridControlPatients";
            this.gridControlPatients.Size = new System.Drawing.Size(787, 406);
            this.gridControlPatients.TabIndex = 1;
            this.gridControlPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourcePatients
            // 
            this.bindingSourcePatients.DataSource = typeof(Patient);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTcNo,
            this.gridColumn1,
            this.colBirthDay,
            this.colBloodGroup,
            this.colCity,
            this.colCountry,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControlPatients;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTcNo
            // 
            this.colTcNo.FieldName = "TcNo";
            this.colTcNo.Name = "colTcNo";
            this.colTcNo.Visible = true;
            this.colTcNo.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Adı Soyadı";
            this.gridColumn1.FieldName = "NameSurname";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // colBirthDay
            // 
            this.colBirthDay.Caption = "Doğum Günü";
            this.colBirthDay.DisplayFormat.FormatString = "dd MMMM yyyy";
            this.colBirthDay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBirthDay.FieldName = "BirthDay";
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.Visible = true;
            this.colBirthDay.VisibleIndex = 2;
            // 
            // colBloodGroup
            // 
            this.colBloodGroup.Caption = "Kan Grubu";
            this.colBloodGroup.FieldName = "BloodGroup.Name";
            this.colBloodGroup.Name = "colBloodGroup";
            this.colBloodGroup.Visible = true;
            this.colBloodGroup.VisibleIndex = 3;
            // 
            // colCity
            // 
            this.colCity.Caption = "Şehir";
            this.colCity.FieldName = "City.Name";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 4;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "İlçe";
            this.colCountry.FieldName = "Country.Name";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cinsiyet";
            this.gridColumn2.FieldName = "GenderS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // XtraFormPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 502);
            this.Controls.Add(this.gridControlPatients);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormPatientDetail";
            this.Text = "Kayıtlı Hastalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraFormPatientDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemNew;
        private BarButtonItem barButtonItemEdit;
        private BarButtonItem barButtonItemDelete;
        private BarButtonItem barButtonItemDetail;
        private GridControl gridControlPatients;
        private GridView gridView1;
        private BindingSource bindingSourcePatients;
        private GridColumn gridColumn1;
        private GridColumn colTcNo;
        private GridColumn colBirthDay;
        private GridColumn colBloodGroup;
        private GridColumn colCity;
        private GridColumn colCountry;
        private GridColumn gridColumn2;
        private BarButtonItem barButtonItemRefresh;

    }
}