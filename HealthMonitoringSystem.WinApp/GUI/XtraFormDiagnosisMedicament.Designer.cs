using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using HScrollBar = System.Windows.Forms.HScrollBar;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormDiagnosisMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDiagnosisMedicament));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemAddNewDiagnosis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditDiagnosis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteDiagnosis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAddNewMedicament = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditMedicament = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteMedicament = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefreshDiagnosis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefreshMed = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDiagnosis = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDiagnosis = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMedicament = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMerdicamentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicamentIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsePerDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemAddNewDiagnosis,
            this.barButtonItemEditDiagnosis,
            this.barButtonItemDeleteDiagnosis,
            this.barButtonItemAddNewMedicament,
            this.barButtonItemEditMedicament,
            this.barButtonItemDeleteMedicament,
            this.barButtonItemRefreshDiagnosis,
            this.barButtonItemRefreshMed});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(752, 96);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemAddNewDiagnosis
            // 
            this.barButtonItemAddNewDiagnosis.Caption = "Yeni";
            this.barButtonItemAddNewDiagnosis.Id = 1;
            this.barButtonItemAddNewDiagnosis.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemAddNewDiagnosis.Name = "barButtonItemAddNewDiagnosis";
            this.barButtonItemAddNewDiagnosis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewDiagnosis_ItemClick);
            // 
            // barButtonItemEditDiagnosis
            // 
            this.barButtonItemEditDiagnosis.Caption = "Düzenle";
            this.barButtonItemEditDiagnosis.Id = 2;
            this.barButtonItemEditDiagnosis.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEditDiagnosis.Name = "barButtonItemEditDiagnosis";
            this.barButtonItemEditDiagnosis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditDiagnosis_ItemClick);
            // 
            // barButtonItemDeleteDiagnosis
            // 
            this.barButtonItemDeleteDiagnosis.Caption = "Sil";
            this.barButtonItemDeleteDiagnosis.Id = 3;
            this.barButtonItemDeleteDiagnosis.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDeleteDiagnosis.Name = "barButtonItemDeleteDiagnosis";
            this.barButtonItemDeleteDiagnosis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteDiagnosis_ItemClick);
            // 
            // barButtonItemAddNewMedicament
            // 
            this.barButtonItemAddNewMedicament.Caption = "Yeni";
            this.barButtonItemAddNewMedicament.Id = 4;
            this.barButtonItemAddNewMedicament.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemAddNewMedicament.Name = "barButtonItemAddNewMedicament";
            this.barButtonItemAddNewMedicament.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddNewMedicament_ItemClick);
            // 
            // barButtonItemEditMedicament
            // 
            this.barButtonItemEditMedicament.Caption = "Düzenle";
            this.barButtonItemEditMedicament.Id = 5;
            this.barButtonItemEditMedicament.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEditMedicament.Name = "barButtonItemEditMedicament";
            this.barButtonItemEditMedicament.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditMedicament_ItemClick);
            // 
            // barButtonItemDeleteMedicament
            // 
            this.barButtonItemDeleteMedicament.Caption = "Sil";
            this.barButtonItemDeleteMedicament.Id = 6;
            this.barButtonItemDeleteMedicament.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDeleteMedicament.Name = "barButtonItemDeleteMedicament";
            this.barButtonItemDeleteMedicament.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteMedicament_ItemClick);
            // 
            // barButtonItemRefreshDiagnosis
            // 
            this.barButtonItemRefreshDiagnosis.Caption = "Yenile";
            this.barButtonItemRefreshDiagnosis.Id = 7;
            this.barButtonItemRefreshDiagnosis.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.refresh;
            this.barButtonItemRefreshDiagnosis.Name = "barButtonItemRefreshDiagnosis";
            this.barButtonItemRefreshDiagnosis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefreshDiagnosis_ItemClick);
            // 
            // barButtonItemRefreshMed
            // 
            this.barButtonItemRefreshMed.Caption = "Yenile";
            this.barButtonItemRefreshMed.Id = 8;
            this.barButtonItemRefreshMed.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.refresh;
            this.barButtonItemRefreshMed.Name = "barButtonItemRefreshMed";
            this.barButtonItemRefreshMed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefreshMed_ItemClick);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAddNewDiagnosis);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEditDiagnosis);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDeleteDiagnosis);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRefreshDiagnosis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tanı İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemAddNewMedicament);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemEditMedicament);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemDeleteMedicament);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemRefreshMed);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "İlaç İşlemleri";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 96);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Panel2.Controls.Add(this.hScrollBar1);
            this.splitContainer1.Size = new System.Drawing.Size(752, 363);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDiagnosis);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(374, 363);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Teşhisler";
            // 
            // gridControlDiagnosis
            // 
            this.gridControlDiagnosis.DataSource = this.bindingSourceDiagnosis;
            this.gridControlDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDiagnosis.Location = new System.Drawing.Point(2, 21);
            this.gridControlDiagnosis.MainView = this.gridView1;
            this.gridControlDiagnosis.MenuManager = this.ribbonControl1;
            this.gridControlDiagnosis.Name = "gridControlDiagnosis";
            this.gridControlDiagnosis.Size = new System.Drawing.Size(370, 340);
            this.gridControlDiagnosis.TabIndex = 0;
            this.gridControlDiagnosis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourceDiagnosis
            // 
            this.bindingSourceDiagnosis.DataSource = typeof(HealthMonitoringSystem.WinApp.DiagnosisService.Diagnosis);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnDepartment,
            this.gridColumnIsActive,
            this.colId,
            this.colIsActive});
            this.gridView1.GridControl = this.gridControlDiagnosis;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Ad";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 149;
            // 
            // gridColumnDepartment
            // 
            this.gridColumnDepartment.Caption = "Bölüm";
            this.gridColumnDepartment.FieldName = "Department.Name";
            this.gridColumnDepartment.Name = "gridColumnDepartment";
            this.gridColumnDepartment.Visible = true;
            this.gridColumnDepartment.VisibleIndex = 1;
            this.gridColumnDepartment.Width = 138;
            // 
            // gridColumnIsActive
            // 
            this.gridColumnIsActive.Caption = "Aktiflik";
            this.gridColumnIsActive.FieldName = "IsActive";
            this.gridColumnIsActive.Name = "gridColumnIsActive";
            this.gridColumnIsActive.Visible = true;
            this.gridColumnIsActive.VisibleIndex = 2;
            this.gridColumnIsActive.Width = 67;
            // 
            // colId
            // 
            this.colId.Caption = "Numarası";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktiflik";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlMedicament);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(374, 363);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "İlaçlar";
            // 
            // gridControlMedicament
            // 
            this.gridControlMedicament.DataSource = this.bindingSourceMedicament;
            this.gridControlMedicament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMedicament.Location = new System.Drawing.Point(2, 21);
            this.gridControlMedicament.MainView = this.gridView2;
            this.gridControlMedicament.MenuManager = this.ribbonControl1;
            this.gridControlMedicament.Name = "gridControlMedicament";
            this.gridControlMedicament.Size = new System.Drawing.Size(370, 340);
            this.gridControlMedicament.TabIndex = 0;
            this.gridControlMedicament.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bindingSourceMedicament
            // 
            this.bindingSourceMedicament.DataSource = typeof(HealthMonitoringSystem.WinApp.MedicamentService.Medicament);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMerdicamentName,
            this.colMedicamentIsActive,
            this.gridColumnUsePerDay,
            this.gridColumnNote});
            this.gridView2.GridControl = this.gridControlMedicament;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMerdicamentName
            // 
            this.colMerdicamentName.Caption = "İlaç Adı";
            this.colMerdicamentName.FieldName = "Name";
            this.colMerdicamentName.Name = "colMerdicamentName";
            this.colMerdicamentName.Visible = true;
            this.colMerdicamentName.VisibleIndex = 0;
            this.colMerdicamentName.Width = 94;
            // 
            // colMedicamentIsActive
            // 
            this.colMedicamentIsActive.Caption = "Aktiflik";
            this.colMedicamentIsActive.FieldName = "IsActive";
            this.colMedicamentIsActive.Name = "colMedicamentIsActive";
            this.colMedicamentIsActive.Visible = true;
            this.colMedicamentIsActive.VisibleIndex = 3;
            this.colMedicamentIsActive.Width = 78;
            // 
            // gridColumnUsePerDay
            // 
            this.gridColumnUsePerDay.Caption = "Kullanım(Gün.Adet)";
            this.gridColumnUsePerDay.FieldName = "UsePerDay";
            this.gridColumnUsePerDay.Name = "gridColumnUsePerDay";
            this.gridColumnUsePerDay.Visible = true;
            this.gridColumnUsePerDay.VisibleIndex = 1;
            this.gridColumnUsePerDay.Width = 107;
            // 
            // gridColumnNote
            // 
            this.gridColumnNote.Caption = "Not";
            this.gridColumnNote.FieldName = "Note";
            this.gridColumnNote.Name = "gridColumnNote";
            this.gridColumnNote.Visible = true;
            this.gridColumnNote.VisibleIndex = 2;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(41, 128);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar1.TabIndex = 1;
            // 
            // XtraFormDiagnosisMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 459);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormDiagnosisMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teşhisler ve İlaçlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraFormDiagnosisMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private RibbonPageGroup ribbonPageGroup2;
        private SplitContainer splitContainer1;
        private GridControl gridControlDiagnosis;
        private GridView gridView1;
        private GridControl gridControlMedicament;
        private GridView gridView2;
        private GridColumn gridColumnName;
        private GridColumn gridColumnDepartment;
        private GridColumn gridColumnIsActive;
        private BindingSource bindingSourceDiagnosis;
        private BindingSource bindingSourceMedicament;
        private GridColumn colMerdicamentName;
        private GridColumn colMedicamentIsActive;
        private BarButtonItem barButtonItemAddNewDiagnosis;
        private BarButtonItem barButtonItemEditDiagnosis;
        private HScrollBar hScrollBar1;
        private BarButtonItem barButtonItemDeleteDiagnosis;
        private BarButtonItem barButtonItemAddNewMedicament;
        private BarButtonItem barButtonItemEditMedicament;
        private BarButtonItem barButtonItemDeleteMedicament;
        private GroupControl groupControl1;
        private GroupControl groupControl2;
        private GridColumn gridColumnUsePerDay;
        private GridColumn gridColumnNote;
        private GridColumn colId;
        private GridColumn colIsActive;
        private BarButtonItem barButtonItemRefreshDiagnosis;
        private BarButtonItem barButtonItemRefreshMed;
    }
}