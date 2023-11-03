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
    partial class XtraFormHolidayDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormHolidayDetails));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemNewHoliday = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditHoliday = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteHoliday = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlHoliday = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceHolidays = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHolidays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemNewHoliday,
            this.barButtonItemEditHoliday,
            this.barButtonItemDeleteHoliday,
            this.barButtonItemRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(771, 96);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemNewHoliday
            // 
            this.barButtonItemNewHoliday.Caption = "Yeni";
            this.barButtonItemNewHoliday.Id = 1;
            this.barButtonItemNewHoliday.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemNewHoliday.Name = "barButtonItemNewHoliday";
            this.barButtonItemNewHoliday.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewHoliday_ItemClick);
            // 
            // barButtonItemEditHoliday
            // 
            this.barButtonItemEditHoliday.Caption = "Düzenle";
            this.barButtonItemEditHoliday.Id = 2;
            this.barButtonItemEditHoliday.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEditHoliday.Name = "barButtonItemEditHoliday";
            this.barButtonItemEditHoliday.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditHoliday_ItemClick);
            // 
            // barButtonItemDeleteHoliday
            // 
            this.barButtonItemDeleteHoliday.Caption = "Sil";
            this.barButtonItemDeleteHoliday.Id = 3;
            this.barButtonItemDeleteHoliday.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDeleteHoliday.Name = "barButtonItemDeleteHoliday";
            this.barButtonItemDeleteHoliday.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteHoliday_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemNewHoliday);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEditHoliday);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDeleteHoliday);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tatil İşlemleri";
            // 
            // barButtonItemPrint
            // 
            this.barButtonItemPrint.Caption = "Doktor Listesini Yazdır";
            this.barButtonItemPrint.Id = 6;
            this.barButtonItemPrint.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.printer;
            this.barButtonItemPrint.Name = "barButtonItemPrint";
            // 
            // gridControlHoliday
            // 
            this.gridControlHoliday.DataSource = this.bindingSourceHolidays;
            this.gridControlHoliday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHoliday.Location = new System.Drawing.Point(0, 96);
            this.gridControlHoliday.MainView = this.gridView1;
            this.gridControlHoliday.MenuManager = this.ribbonControl1;
            this.gridControlHoliday.Name = "gridControlHoliday";
            this.gridControlHoliday.Size = new System.Drawing.Size(771, 330);
            this.gridControlHoliday.TabIndex = 1;
            this.gridControlHoliday.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // bindingSourceHolidays
            // 
            this.bindingSourceHolidays.DataSource = typeof(Holiday);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDay,
            this.colMonth,
            this.colYear});
            this.gridView1.DefaultRelationIndex = 1;
            this.gridView1.GridControl = this.gridControlHoliday;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridView1.OptionsDetail.AutoZoomDetail = true;
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Tatil Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDay
            // 
            this.colDay.Caption = "Gün";
            this.colDay.FieldName = "Day";
            this.colDay.Name = "colDay";
            this.colDay.Visible = true;
            this.colDay.VisibleIndex = 1;
            // 
            // colMonth
            // 
            this.colMonth.Caption = "Ay";
            this.colMonth.FieldName = "MonthS";
            this.colMonth.Name = "colMonth";
            this.colMonth.Visible = true;
            this.colMonth.VisibleIndex = 2;
            // 
            // colYear
            // 
            this.colYear.Caption = "Yıl";
            this.colYear.FieldName = "YearS";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 3;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControlHoliday;
            this.gridView2.Name = "gridView2";
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // XtraFormHolidayDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 426);
            this.Controls.Add(this.gridControlHoliday);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormHolidayDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tatil İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHolidays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemNewHoliday;
        private BarButtonItem barButtonItemEditHoliday;
        private BarButtonItem barButtonItemDeleteHoliday;
        private GridControl gridControlHoliday;
        private BarButtonItem barButtonItemRefresh;
        private GridView gridView1;
        private BarButtonItem barButtonItemPrint;
        private GridView gridView2;
        private GridColumn gridColumn1;
        private BindingSource bindingSourceHolidays;
        private GridColumn colName;
        private GridColumn colDay;
        private GridColumn colMonth;
        private GridColumn colYear;
    }
}