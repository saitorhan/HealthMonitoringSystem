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
    partial class XtraFormRendezvousProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormRendezvousProcess));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTCNO = new DevExpress.XtraEditors.TextEdit();
            this.labelControlPatientName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditDoctor = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceDoctor = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlTimes = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceTimes = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.simpleButtonPatientInfos = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNewPatient = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTCNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hasta TC No";
            // 
            // textEditTCNO
            // 
            this.textEditTCNO.Location = new System.Drawing.Point(95, 142);
            this.textEditTCNO.Name = "textEditTCNO";
            this.textEditTCNO.Properties.Mask.EditMask = "\\d{11}";
            this.textEditTCNO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditTCNO.Size = new System.Drawing.Size(144, 20);
            this.textEditTCNO.TabIndex = 0;
            // 
            // labelControlPatientName
            // 
            this.labelControlPatientName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControlPatientName.Appearance.Options.UseFont = true;
            this.labelControlPatientName.Location = new System.Drawing.Point(101, 219);
            this.labelControlPatientName.Name = "labelControlPatientName";
            this.labelControlPatientName.Size = new System.Drawing.Size(0, 16);
            this.labelControlPatientName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 219);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hasta Adı";
            // 
            // lookUpEditDepartment
            // 
            this.lookUpEditDepartment.Location = new System.Drawing.Point(101, 255);
            this.lookUpEditDepartment.Name = "lookUpEditDepartment";
            this.lookUpEditDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Bölüm Adı")});
            this.lookUpEditDepartment.Properties.DataSource = this.bindingSourceDepartment;
            this.lookUpEditDepartment.Properties.DisplayMember = "Name";
            this.lookUpEditDepartment.Properties.NullText = "Bölüm Seçiniz";
            this.lookUpEditDepartment.Properties.ValueMember = "Id";
            this.lookUpEditDepartment.Size = new System.Drawing.Size(144, 20);
            this.lookUpEditDepartment.TabIndex = 1;
            this.lookUpEditDepartment.EditValueChanged += new System.EventHandler(this.lookUpEditDepartment_EditValueChanged);
            // 
            // bindingSourceDepartment
            // 
            this.bindingSourceDepartment.DataSource = typeof(HealthMonitoringSystem.Entity.Department);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 258);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Bölüm Seçiniz";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 284);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Doktor Seçiniz";
            // 
            // lookUpEditDoctor
            // 
            this.lookUpEditDoctor.Location = new System.Drawing.Point(101, 281);
            this.lookUpEditDoctor.Name = "lookUpEditDoctor";
            this.lookUpEditDoctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDoctor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameSurname", "Doktor Adı")});
            this.lookUpEditDoctor.Properties.DataSource = this.bindingSourceDoctor;
            this.lookUpEditDoctor.Properties.DisplayMember = "NameSurname";
            this.lookUpEditDoctor.Properties.NullText = "Doktor Seçiniz";
            this.lookUpEditDoctor.Properties.ValueMember = "Id";
            this.lookUpEditDoctor.Size = new System.Drawing.Size(144, 20);
            this.lookUpEditDoctor.TabIndex = 2;
            this.lookUpEditDoctor.EditValueChanged += new System.EventHandler(this.lookUpEditDoctor_EditValueChanged);
            // 
            // bindingSourceDoctor
            // 
            this.bindingSourceDoctor.DataSource = typeof(HealthMonitoringSystem.Entity.Doctor);
            // 
            // gridControlTimes
            // 
            this.gridControlTimes.DataSource = this.bindingSourceTimes;
            this.gridControlTimes.Location = new System.Drawing.Point(101, 307);
            this.gridControlTimes.MainView = this.gridView1;
            this.gridControlTimes.Name = "gridControlTimes";
            this.gridControlTimes.Size = new System.Drawing.Size(144, 177);
            this.gridControlTimes.TabIndex = 3;
            this.gridControlTimes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourceTimes
            // 
            this.bindingSourceTimes.DataSource = typeof(HealthMonitoringSystem.Entity.RendezvousTime);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartTime});
            this.gridView1.GridControl = this.gridControlTimes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colStartTime
            // 
            this.colStartTime.Caption = "Başlama Saati";
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 307);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Uygun Saatler";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barButtonItemCancel,
            this.barButtonItemRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(275, 126);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Kaydet";
            this.barButtonItemSave.Id = 1;
            this.barButtonItemSave.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.save;
            this.barButtonItemSave.Name = "barButtonItemSave";
            this.barButtonItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSave_ItemClick);
            // 
            // barButtonItemCancel
            // 
            this.barButtonItemCancel.Caption = "İptal";
            this.barButtonItemCancel.Id = 2;
            this.barButtonItemCancel.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.remove;
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancel_ItemClick);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Bölüm ve Doktor Listesi Yenile";
            this.barButtonItemRefresh.Id = 3;
            this.barButtonItemRefresh.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.refresh;
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
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCancel);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // simpleButtonPatientInfos
            // 
            this.simpleButtonPatientInfos.Location = new System.Drawing.Point(128, 181);
            this.simpleButtonPatientInfos.Name = "simpleButtonPatientInfos";
            this.simpleButtonPatientInfos.Size = new System.Drawing.Size(111, 23);
            this.simpleButtonPatientInfos.TabIndex = 9;
            this.simpleButtonPatientInfos.Text = "Hasta Bilgilerini Getir";
            this.simpleButtonPatientInfos.Click += new System.EventHandler(this.simpleButtonPatientInfos_Click);
            // 
            // simpleButtonNewPatient
            // 
            this.simpleButtonNewPatient.Location = new System.Drawing.Point(32, 181);
            this.simpleButtonNewPatient.Name = "simpleButtonNewPatient";
            this.simpleButtonNewPatient.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonNewPatient.TabIndex = 11;
            this.simpleButtonNewPatient.Text = "Yeni Hasta Kaydı";
            this.simpleButtonNewPatient.Click += new System.EventHandler(this.simpleButtonNewPatient_Click);
            // 
            // XtraFormRendezvousProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 503);
            this.Controls.Add(this.simpleButtonNewPatient);
            this.Controls.Add(this.simpleButtonPatientInfos);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gridControlTimes);
            this.Controls.Add(this.lookUpEditDoctor);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lookUpEditDepartment);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControlPatientName);
            this.Controls.Add(this.textEditTCNO);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormRendezvousProcess.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormRendezvousProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Randevu";
            this.Load += new System.EventHandler(this.XtraFormRendezvousProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditTCNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private TextEdit textEditTCNO;
        private LabelControl labelControlPatientName;
        private LabelControl labelControl2;
        private LookUpEdit lookUpEditDepartment;
        private BindingSource bindingSourceDepartment;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LookUpEdit lookUpEditDoctor;
        private BindingSource bindingSourceDoctor;
        private GridControl gridControlTimes;
        private BindingSource bindingSourceTimes;
        private GridView gridView1;
        private GridColumn colStartTime;
        private LabelControl labelControl5;
        private RibbonControl ribbonControl1;
        private BarButtonItem barButtonItemSave;
        private BarButtonItem barButtonItemCancel;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private SimpleButton simpleButtonPatientInfos;
        private SimpleButton simpleButtonNewPatient;
        private BarButtonItem barButtonItemRefresh;

    }
}