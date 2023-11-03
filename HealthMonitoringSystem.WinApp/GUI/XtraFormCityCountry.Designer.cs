using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using HealthMonitoringSystem.Entity;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormCityCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormCityCountry));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAddNewCity = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditCity = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteCity = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAddNewCountry = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditCountry = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteCountry = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCity = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCity = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCountry = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCountry = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemAddNewCity,
            this.barButtonItemEditCity,
            this.barButtonItemDeleteCity,
            this.barButtonItemAddNewCountry,
            this.barButtonItemEditCountry,
            this.barButtonItemDeleteCountry,
            this.barButtonItemRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(816, 126);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemAddNewCity
            // 
            this.barButtonItemAddNewCity.Caption = "Yeni";
            this.barButtonItemAddNewCity.Id = 1;
            this.barButtonItemAddNewCity.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemAddNewCity.Name = "barButtonItemAddNewCity";
            this.barButtonItemAddNewCity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewCity_ItemClick);
            // 
            // barButtonItemEditCity
            // 
            this.barButtonItemEditCity.Caption = "Düzenle";
            this.barButtonItemEditCity.Id = 2;
            this.barButtonItemEditCity.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEditCity.Name = "barButtonItemEditCity";
            this.barButtonItemEditCity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditCity_ItemClick);
            // 
            // barButtonItemDeleteCity
            // 
            this.barButtonItemDeleteCity.Caption = "Sil";
            this.barButtonItemDeleteCity.Id = 3;
            this.barButtonItemDeleteCity.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDeleteCity.Name = "barButtonItemDeleteCity";
            this.barButtonItemDeleteCity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteCity_ItemClick);
            // 
            // barButtonItemAddNewCountry
            // 
            this.barButtonItemAddNewCountry.Caption = "Yeni";
            this.barButtonItemAddNewCountry.Id = 4;
            this.barButtonItemAddNewCountry.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemAddNewCountry.Name = "barButtonItemAddNewCountry";
            this.barButtonItemAddNewCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewCountry_ItemClick);
            // 
            // barButtonItemEditCountry
            // 
            this.barButtonItemEditCountry.Caption = "Düzenle";
            this.barButtonItemEditCountry.Id = 5;
            this.barButtonItemEditCountry.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEditCountry.Name = "barButtonItemEditCountry";
            this.barButtonItemEditCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditCountry_ItemClick);
            // 
            // barButtonItemDeleteCountry
            // 
            this.barButtonItemDeleteCountry.Caption = "Sil";
            this.barButtonItemDeleteCountry.Id = 6;
            this.barButtonItemDeleteCountry.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDeleteCountry.Name = "barButtonItemDeleteCountry";
            this.barButtonItemDeleteCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteCountry_ItemClick);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Yenile";
            this.barButtonItemRefresh.Id = 7;
            this.barButtonItemRefresh.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.refresh;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAddNewCity);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEditCity);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDeleteCity);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Şehir İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAddNewCountry);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemEditCountry);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemDeleteCountry);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "İlçe İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Yenile";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 126);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(816, 491);
            this.splitContainerControl1.SplitterPosition = 384;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlCity);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 491);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Şehirler";
            // 
            // gridControlCity
            // 
            this.gridControlCity.DataSource = this.bindingSourceCity;
            this.gridControlCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCity.Location = new System.Drawing.Point(2, 23);
            this.gridControlCity.MainView = this.gridView1;
            this.gridControlCity.MenuManager = this.ribbonControl1;
            this.gridControlCity.Name = "gridControlCity";
            this.gridControlCity.Size = new System.Drawing.Size(380, 466);
            this.gridControlCity.TabIndex = 0;
            this.gridControlCity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourceCity
            // 
            this.bindingSourceCity.DataSource = typeof(HealthMonitoringSystem.Entity.City);
            this.bindingSourceCity.CurrentChanged += new System.EventHandler(this.bindingSourceCity_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colIsActive});
            this.gridView1.GridControl = this.gridControlCity;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.SelectionChangedNewCity);
            // 
            // colName
            // 
            this.colName.Caption = "Şehir Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktiflik";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlCountry);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(422, 491);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "İlçeler";
            // 
            // gridControlCountry
            // 
            this.gridControlCountry.DataSource = this.bindingSourceCountry;
            this.gridControlCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCountry.Location = new System.Drawing.Point(2, 23);
            this.gridControlCountry.MainView = this.gridView2;
            this.gridControlCountry.MenuManager = this.ribbonControl1;
            this.gridControlCountry.Name = "gridControlCountry";
            this.gridControlCountry.Size = new System.Drawing.Size(418, 466);
            this.gridControlCountry.TabIndex = 0;
            this.gridControlCountry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bindingSourceCountry
            // 
            this.bindingSourceCountry.DataSource = typeof(HealthMonitoringSystem.Entity.Country);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCity,
            this.colIsActive1,
            this.colName1});
            this.gridView2.GridControl = this.gridControlCountry;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCity
            // 
            this.colCity.Caption = "Şehir";
            this.colCity.FieldName = "City.Name";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 1;
            this.colCity.Width = 146;
            // 
            // colIsActive1
            // 
            this.colIsActive1.Caption = "Aktiflik";
            this.colIsActive1.FieldName = "IsActive";
            this.colIsActive1.Name = "colIsActive1";
            this.colIsActive1.Visible = true;
            this.colIsActive1.VisibleIndex = 2;
            this.colIsActive1.Width = 65;
            // 
            // colName1
            // 
            this.colName1.Caption = "İlçe Adı";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 130;
            // 
            // XtraFormCityCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 617);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormCityCountry.IconOptions.Icon")));
            this.Name = "XtraFormCityCountry";
            this.Text = "Şehir ve İlçe İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraFormCityCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private RibbonPageGroup ribbonPageGroup2;
        private SplitContainerControl splitContainerControl1;
        private GroupControl groupControl1;
        private GridControl gridControlCity;
        private GridView gridView1;
        private GroupControl groupControl2;
        private GridControl gridControlCountry;
        private GridView gridView2;
        private BindingSource bindingSourceCity;
        private BindingSource bindingSourceCountry;
        private GridColumn colName;
        private GridColumn colIsActive;
        private GridColumn colCity;
        private GridColumn colIsActive1;
        private GridColumn colName1;
        private BarButtonItem barButtonItemAddNewCity;
        private BarButtonItem barButtonItemEditCity;
        private BarButtonItem barButtonItemDeleteCity;
        private BarButtonItem barButtonItemAddNewCountry;
        private BarButtonItem barButtonItemEditCountry;
        private BarButtonItem barButtonItemDeleteCountry;
        private BarButtonItem barButtonItemRefresh;
        private RibbonPageGroup ribbonPageGroup3;
    }
}