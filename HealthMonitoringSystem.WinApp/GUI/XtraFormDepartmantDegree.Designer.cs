using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormDepartmantDegree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDepartmantDegree));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAddNewDep = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditDep = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteDep = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAddNewDeg = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditDeg = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteDeg = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDeps = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDegrees = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDegree = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefreshCountry = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemAddNewDep,
            this.barButtonItemEditDep,
            this.barButtonItemDeleteDep,
            this.barButtonItemAddNewDeg,
            this.barButtonItemEditDeg,
            this.barButtonItemDeleteDeg,
            this.barButtonItemRefresh,
            this.barButtonItemRefreshCountry});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(813, 96);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemAddNewDep
            // 
            this.barButtonItemAddNewDep.Caption = "Yeni";
            this.barButtonItemAddNewDep.Id = 1;
            this.barButtonItemAddNewDep.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemAddNewDep.Name = "barButtonItemAddNewDep";
            this.barButtonItemAddNewDep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewDep_ItemClick);
            // 
            // barButtonItemEditDep
            // 
            this.barButtonItemEditDep.Caption = "Düzenle";
            this.barButtonItemEditDep.Id = 2;
            this.barButtonItemEditDep.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEditDep.Name = "barButtonItemEditDep";
            this.barButtonItemEditDep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditDep_ItemClick);
            // 
            // barButtonItemDeleteDep
            // 
            this.barButtonItemDeleteDep.Caption = "Sil";
            this.barButtonItemDeleteDep.Id = 3;
            this.barButtonItemDeleteDep.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDeleteDep.Name = "barButtonItemDeleteDep";
            this.barButtonItemDeleteDep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteDep_ItemClick);
            // 
            // barButtonItemAddNewDeg
            // 
            this.barButtonItemAddNewDeg.Caption = "Yeni";
            this.barButtonItemAddNewDeg.Id = 4;
            this.barButtonItemAddNewDeg.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemAddNewDeg.Name = "barButtonItemAddNewDeg";
            this.barButtonItemAddNewDeg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewDeg_ItemClick);
            // 
            // barButtonItemEditDeg
            // 
            this.barButtonItemEditDeg.Caption = "Düzenle";
            this.barButtonItemEditDeg.Id = 5;
            this.barButtonItemEditDeg.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEditDeg.Name = "barButtonItemEditDeg";
            this.barButtonItemEditDeg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditDeg_ItemClick);
            // 
            // barButtonItemDeleteDeg
            // 
            this.barButtonItemDeleteDeg.Caption = "Sil";
            this.barButtonItemDeleteDeg.Id = 6;
            this.barButtonItemDeleteDeg.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDeleteDeg.Name = "barButtonItemDeleteDeg";
            this.barButtonItemDeleteDeg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteDeg_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAddNewDep);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEditDep);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDeleteDep);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Departman İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAddNewDeg);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemEditDeg);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemDeleteDeg);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemRefreshCountry);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Ünvan İşlemleri";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 96);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(813, 407);
            this.splitContainerControl1.SplitterPosition = 388;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDeps);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(388, 407);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Departmanlar";
            // 
            // gridControlDeps
            // 
            this.gridControlDeps.DataSource = this.bindingSourceDepartment;
            this.gridControlDeps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDeps.Location = new System.Drawing.Point(2, 21);
            this.gridControlDeps.MainView = this.gridView1;
            this.gridControlDeps.MenuManager = this.ribbonControl1;
            this.gridControlDeps.Name = "gridControlDeps";
            this.gridControlDeps.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlDeps.Size = new System.Drawing.Size(384, 384);
            this.gridControlDeps.TabIndex = 0;
            this.gridControlDeps.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlDeps.Click += new System.EventHandler(this.gridControlDeps_Click);
            // 
            // bindingSourceDepartment
            // 
            this.bindingSourceDepartment.DataSource = typeof(HealthMonitoringSystem.WinApp.DepartmentService.Department);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControlDeps;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Departman Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 286;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Alt Yaş";
            this.gridColumn5.FieldName = "MinAge";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Üst Yaş";
            this.gridColumn4.FieldName = "MaxAge";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cinsiyet";
            this.gridColumn3.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn3.FieldName = "Gender";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.ReadOnly = true;
            this.repositoryItemTextEdit1.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.repositoryItemTextEdit1_CustomDisplayText);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Aktiflik";
            this.gridColumn1.FieldName = "IsActive";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlDegrees);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(420, 407);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Ünvanlar";
            // 
            // gridControlDegrees
            // 
            this.gridControlDegrees.DataSource = this.bindingSourceDegree;
            this.gridControlDegrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDegrees.Location = new System.Drawing.Point(2, 21);
            this.gridControlDegrees.MainView = this.gridView2;
            this.gridControlDegrees.MenuManager = this.ribbonControl1;
            this.gridControlDegrees.Name = "gridControlDegrees";
            this.gridControlDegrees.Size = new System.Drawing.Size(416, 384);
            this.gridControlDegrees.TabIndex = 0;
            this.gridControlDegrees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bindingSourceDegree
            // 
            this.bindingSourceDegree.DataSource = typeof(HealthMonitoringSystem.WinApp.DegreeService.Degree);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colShortName,
            this.gridColumn2});
            this.gridView2.GridControl = this.gridControlDegrees;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colName1
            // 
            this.colName1.Caption = "Adı";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 210;
            // 
            // colShortName
            // 
            this.colShortName.Caption = "Kısa Adı";
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 1;
            this.colShortName.Width = 93;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Aktiflik";
            this.gridColumn2.FieldName = "IsActive";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 97;
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Yenile";
            this.barButtonItemRefresh.Id = 7;
            this.barButtonItemRefresh.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.refresh;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // barButtonItemRefreshCountry
            // 
            this.barButtonItemRefreshCountry.Caption = "Yenile";
            this.barButtonItemRefreshCountry.Id = 8;
            this.barButtonItemRefreshCountry.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.refresh;
            this.barButtonItemRefreshCountry.Name = "barButtonItemRefreshCountry";
            this.barButtonItemRefreshCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefreshCountry_ItemClick);
            // 
            // XtraFormDepartmantDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 503);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormDepartmantDegree";
            this.Text = "Departman ve Ünvan İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraFormDepartmantDegree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDeps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbonControl1;
        private BarButtonItem barButtonItemAddNewDep;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemEditDep;
        private BarButtonItem barButtonItemDeleteDep;
        private SplitContainerControl splitContainerControl1;
        private GroupControl groupControl1;
        private GroupControl groupControl2;
        private BarButtonItem barButtonItemAddNewDeg;
        private BarButtonItem barButtonItemEditDeg;
        private BarButtonItem barButtonItemDeleteDeg;
        private RibbonPageGroup ribbonPageGroup2;
        private GridControl gridControlDeps;
        private GridView gridView1;
        private GridColumn colName;
        private GridControl gridControlDegrees;
        private GridView gridView2;
        private GridColumn colName1;
        private GridColumn colShortName;
        private BindingSource bindingSourceDepartment;
        private GridColumn gridColumn1;
        private BindingSource bindingSourceDegree;
        private GridColumn gridColumn2;
        private GridColumn gridColumn5;
        private GridColumn gridColumn4;
        private GridColumn gridColumn3;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private BackgroundWorker backgroundWorker1;
        private BarButtonItem barButtonItemRefresh;
        private BarButtonItem barButtonItemRefreshCountry;
    }
}