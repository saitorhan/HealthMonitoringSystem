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
    partial class XtraFormPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormPrescription));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAddCommand = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlAllMedicaments = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceAllMedicaments = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAllMedicament = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsePerDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlPrescriptionItems = new DevExpress.XtraGrid.GridControl();
            this.bindingSourcePrescriptionItems = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPrescriptionItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsePerDay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAllMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrescriptionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePrescriptionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrescriptionItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barButtonItemCancel,
            this.barButtonItemAddCommand});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(754, 96);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Kaydet";
            this.barButtonItemSave.Id = 1;
            this.barButtonItemSave.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.save;
            this.barButtonItemSave.Name = "barButtonItemSave";
            this.barButtonItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSave_ItemClick);
            // 
            // barButtonItemCancel
            // 
            this.barButtonItemCancel.Caption = "İptal";
            this.barButtonItemCancel.Id = 2;
            this.barButtonItemCancel.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.remove;
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancel_ItemClick);
            // 
            // barButtonItemAddCommand
            // 
            this.barButtonItemAddCommand.Caption = "Reçeteye Not Ekle";
            this.barButtonItemAddCommand.Id = 3;
            this.barButtonItemAddCommand.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.add_comment;
            this.barButtonItemAddCommand.Name = "barButtonItemAddCommand";
            this.barButtonItemAddCommand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddCommand_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemAddCommand);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 396);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlAllMedicaments);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(371, 390);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tüm İlaçlar";
            // 
            // gridControlAllMedicaments
            // 
            this.gridControlAllMedicaments.DataSource = this.bindingSourceAllMedicaments;
            this.gridControlAllMedicaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAllMedicaments.Location = new System.Drawing.Point(2, 21);
            this.gridControlAllMedicaments.MainView = this.gridViewAllMedicament;
            this.gridControlAllMedicaments.MenuManager = this.ribbonControl1;
            this.gridControlAllMedicaments.Name = "gridControlAllMedicaments";
            this.gridControlAllMedicaments.Size = new System.Drawing.Size(367, 367);
            this.gridControlAllMedicaments.TabIndex = 0;
            this.gridControlAllMedicaments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAllMedicament});
            this.gridControlAllMedicaments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControlAllMedicaments_MouseClick);
            // 
            // bindingSourceAllMedicaments
            // 
            this.bindingSourceAllMedicaments.DataSource = typeof(HealthMonitoringSystem.WinApp.MedicamentService.Medicament);
            // 
            // gridViewAllMedicament
            // 
            this.gridViewAllMedicament.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colUsePerDay});
            this.gridViewAllMedicament.GridControl = this.gridControlAllMedicaments;
            this.gridViewAllMedicament.Name = "gridViewAllMedicament";
            this.gridViewAllMedicament.OptionsBehavior.Editable = false;
            this.gridViewAllMedicament.OptionsFind.AlwaysVisible = true;
            this.gridViewAllMedicament.OptionsSelection.MultiSelect = true;
            this.gridViewAllMedicament.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewAllMedicament.OptionsView.ShowFooter = true;
            this.gridViewAllMedicament.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 258;
            // 
            // colUsePerDay
            // 
            this.colUsePerDay.Caption = "Kullanım Dozajı";
            this.colUsePerDay.FieldName = "UsePerDay";
            this.colUsePerDay.Name = "colUsePerDay";
            this.colUsePerDay.Visible = true;
            this.colUsePerDay.VisibleIndex = 2;
            this.colUsePerDay.Width = 93;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlPrescriptionItems);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(380, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(371, 390);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Reçeteye Eklenmiş İlaçlar";
            // 
            // gridControlPrescriptionItems
            // 
            this.gridControlPrescriptionItems.DataSource = this.bindingSourcePrescriptionItems;
            this.gridControlPrescriptionItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrescriptionItems.Location = new System.Drawing.Point(2, 21);
            this.gridControlPrescriptionItems.MainView = this.gridViewPrescriptionItem;
            this.gridControlPrescriptionItems.MenuManager = this.ribbonControl1;
            this.gridControlPrescriptionItems.Name = "gridControlPrescriptionItems";
            this.gridControlPrescriptionItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlPrescriptionItems.Size = new System.Drawing.Size(367, 367);
            this.gridControlPrescriptionItems.TabIndex = 0;
            this.gridControlPrescriptionItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrescriptionItem});
            // 
            // bindingSourcePrescriptionItems
            // 
            this.bindingSourcePrescriptionItems.DataSource = typeof(HealthMonitoringSystem.WinApp.PrescriptionService.PrescriptionItem);
            // 
            // gridViewPrescriptionItem
            // 
            this.gridViewPrescriptionItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colUsePerDay1});
            this.gridViewPrescriptionItem.GridControl = this.gridControlPrescriptionItems;
            this.gridViewPrescriptionItem.Name = "gridViewPrescriptionItem";
            this.gridViewPrescriptionItem.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "İlaç Adı";
            this.gridColumn1.FieldName = "Medicament.Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 217;
            // 
            // colUsePerDay1
            // 
            this.colUsePerDay1.Caption = "Kullanım Sıklığı (gün,adet)";
            this.colUsePerDay1.ColumnEdit = this.repositoryItemTextEdit1;
            this.colUsePerDay1.FieldName = "UsePerDay";
            this.colUsePerDay1.Name = "colUsePerDay1";
            this.colUsePerDay1.Visible = true;
            this.colUsePerDay1.VisibleIndex = 1;
            this.colUsePerDay1.Width = 134;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "f1";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // XtraFormPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XtraFormPrescription_FormClosing);
            this.Load += new System.EventHandler(this.XtraFormPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAllMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrescriptionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePrescriptionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrescriptionItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbonControl1;
        private BarButtonItem barButtonItemSave;
        private BarButtonItem barButtonItemCancel;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupControl groupControl1;
        private GridControl gridControlAllMedicaments;
        private GridView gridViewAllMedicament;
        private GroupControl groupControl2;
        private BindingSource bindingSourceAllMedicaments;
        private GridColumn colName;
        private GridColumn colUsePerDay;
        private GridControl gridControlPrescriptionItems;
        private BindingSource bindingSourcePrescriptionItems;
        private GridView gridViewPrescriptionItem;
        private GridColumn gridColumn1;
        private GridColumn colUsePerDay1;
        private BarButtonItem barButtonItemAddCommand;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}