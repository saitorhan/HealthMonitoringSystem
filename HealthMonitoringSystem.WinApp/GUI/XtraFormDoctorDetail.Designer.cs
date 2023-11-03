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
    partial class XtraFormDoctorDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDoctorDetail));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSaveNewDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancelNewDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.degreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlPhones = new DevExpress.XtraGrid.GridControl();
            this.bindingSourcePhones = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPhones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMails = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceMail = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditDepartmant = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditDegree = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEditBirthDay = new DevExpress.XtraEditors.DateEdit();
            this.textEditDoctorSurname = new DevExpress.XtraEditors.TextEdit();
            this.textEditDoctorName = new DevExpress.XtraEditors.TextEdit();
            this.textEditFatherName = new DevExpress.XtraEditors.TextEdit();
            this.textEditMotherName = new DevExpress.XtraEditors.TextEdit();
            this.textEditTcNumber = new DevExpress.XtraEditors.TextEdit();
            this.checkEditIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBirthday = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControlSurname = new DevExpress.XtraEditors.LabelControl();
            this.LabelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMail = new DevExpress.XtraEditors.LabelControl();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonNewPhone = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlPhone = new DevExpress.XtraEditors.LabelControl();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonNewMail = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartmant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDegree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDoctorSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDoctorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFatherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMotherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTcNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSaveNewDoctor,
            this.barButtonItemCancelNewDoctor});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(674, 126);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barButtonItemSaveNewDoctor
            // 
            this.barButtonItemSaveNewDoctor.Caption = "Kaydet";
            this.barButtonItemSaveNewDoctor.Id = 1;
            this.barButtonItemSaveNewDoctor.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.save;
            this.barButtonItemSaveNewDoctor.Name = "barButtonItemSaveNewDoctor";
            this.barButtonItemSaveNewDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSaveNewDoctor_ItemClick);
            // 
            // barButtonItemCancelNewDoctor
            // 
            this.barButtonItemCancelNewDoctor.Caption = "İptal";
            this.barButtonItemCancelNewDoctor.Id = 2;
            this.barButtonItemCancelNewDoctor.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.remove;
            this.barButtonItemCancelNewDoctor.Name = "barButtonItemCancelNewDoctor";
            this.barButtonItemCancelNewDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancelNewDoctor_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemSaveNewDoctor);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCancelNewDoctor);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // degreeBindingSource
            // 
            this.degreeBindingSource.DataSource = typeof(HealthMonitoringSystem.Entity.Degree);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(HealthMonitoringSystem.Entity.Department);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tableLayoutPanel1);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.lookUpEditDepartmant);
            this.panelControl1.Controls.Add(this.lookUpEditDegree);
            this.panelControl1.Controls.Add(this.dateEditBirthDay);
            this.panelControl1.Controls.Add(this.textEditDoctorSurname);
            this.panelControl1.Controls.Add(this.textEditDoctorName);
            this.panelControl1.Controls.Add(this.textEditFatherName);
            this.panelControl1.Controls.Add(this.textEditMotherName);
            this.panelControl1.Controls.Add(this.textEditTcNumber);
            this.panelControl1.Controls.Add(this.checkEditIsActive);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControlBirthday);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.LabelControlSurname);
            this.panelControl1.Controls.Add(this.LabelControlName);
            this.panelControl1.Location = new System.Drawing.Point(12, 135);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(619, 367);
            this.panelControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(297, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 363);
            this.tableLayoutPanel1.TabIndex = 71;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlPhones);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 175);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Telefon Numaraları";
            // 
            // gridControlPhones
            // 
            this.gridControlPhones.DataSource = this.bindingSourcePhones;
            this.gridControlPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPhones.Location = new System.Drawing.Point(2, 23);
            this.gridControlPhones.MainView = this.gridViewPhones;
            this.gridControlPhones.MenuManager = this.ribbonControl1;
            this.gridControlPhones.Name = "gridControlPhones";
            this.gridControlPhones.Size = new System.Drawing.Size(310, 150);
            this.gridControlPhones.TabIndex = 0;
            this.gridControlPhones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhones});
            // 
            // bindingSourcePhones
            // 
            this.bindingSourcePhones.DataSource = typeof(HealthMonitoringSystem.Entity.DoctorPhone);
            // 
            // gridViewPhones
            // 
            this.gridViewPhones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridViewPhones.GridControl = this.gridControlPhones;
            this.gridViewPhones.Name = "gridViewPhones";
            this.gridViewPhones.OptionsBehavior.Editable = false;
            this.gridViewPhones.OptionsView.ShowGroupPanel = false;
            this.gridViewPhones.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewPhones_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Telefon";
            this.gridColumn1.FieldName = "Phone";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlMails);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 184);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(314, 176);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Mailler";
            // 
            // gridControlMails
            // 
            this.gridControlMails.DataSource = this.bindingSourceMail;
            this.gridControlMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMails.Location = new System.Drawing.Point(2, 23);
            this.gridControlMails.MainView = this.gridViewMails;
            this.gridControlMails.MenuManager = this.ribbonControl1;
            this.gridControlMails.Name = "gridControlMails";
            this.gridControlMails.Size = new System.Drawing.Size(310, 151);
            this.gridControlMails.TabIndex = 0;
            this.gridControlMails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMails});
            // 
            // bindingSourceMail
            // 
            this.bindingSourceMail.DataSource = typeof(HealthMonitoringSystem.Entity.DoctorMail);
            // 
            // gridViewMails
            // 
            this.gridViewMails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMail});
            this.gridViewMails.GridControl = this.gridControlMails;
            this.gridViewMails.Name = "gridViewMails";
            this.gridViewMails.OptionsBehavior.Editable = false;
            this.gridViewMails.OptionsView.ShowGroupPanel = false;
            this.gridViewMails.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewMails_RowCellClick);
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(28, 331);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 63;
            this.labelControl9.Text = "Aktiflik";
            // 
            // lookUpEditDepartmant
            // 
            this.lookUpEditDepartmant.Location = new System.Drawing.Point(123, 252);
            this.lookUpEditDepartmant.MenuManager = this.ribbonControl1;
            this.lookUpEditDepartmant.Name = "lookUpEditDepartmant";
            this.lookUpEditDepartmant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDepartmant.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Deparman Adı", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditDepartmant.Properties.DataSource = this.departmentBindingSource;
            this.lookUpEditDepartmant.Properties.DisplayMember = "Name";
            this.lookUpEditDepartmant.Properties.NullText = "Departman Seçiniz";
            this.lookUpEditDepartmant.Properties.ValueMember = "Id";
            this.lookUpEditDepartmant.Size = new System.Drawing.Size(150, 20);
            this.lookUpEditDepartmant.TabIndex = 6;
            // 
            // lookUpEditDegree
            // 
            this.lookUpEditDegree.Location = new System.Drawing.Point(123, 286);
            this.lookUpEditDegree.MenuManager = this.ribbonControl1;
            this.lookUpEditDegree.Name = "lookUpEditDegree";
            this.lookUpEditDegree.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDegree.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShortName", "Ünvan", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditDegree.Properties.DataSource = this.degreeBindingSource;
            this.lookUpEditDegree.Properties.DisplayMember = "ShortName";
            this.lookUpEditDegree.Properties.NullText = "Ünvan Seçiniz";
            this.lookUpEditDegree.Properties.ValueMember = "Id";
            this.lookUpEditDegree.Size = new System.Drawing.Size(150, 20);
            this.lookUpEditDegree.TabIndex = 7;
            // 
            // dateEditBirthDay
            // 
            this.dateEditBirthDay.EditValue = null;
            this.dateEditBirthDay.Location = new System.Drawing.Point(123, 215);
            this.dateEditBirthDay.MenuManager = this.ribbonControl1;
            this.dateEditBirthDay.Name = "dateEditBirthDay";
            this.dateEditBirthDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthDay.Size = new System.Drawing.Size(150, 20);
            this.dateEditBirthDay.TabIndex = 5;
            // 
            // textEditDoctorSurname
            // 
            this.textEditDoctorSurname.Location = new System.Drawing.Point(123, 93);
            this.textEditDoctorSurname.MenuManager = this.ribbonControl1;
            this.textEditDoctorSurname.Name = "textEditDoctorSurname";
            this.textEditDoctorSurname.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditDoctorSurname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditDoctorSurname.Size = new System.Drawing.Size(150, 20);
            this.textEditDoctorSurname.TabIndex = 2;
            // 
            // textEditDoctorName
            // 
            this.textEditDoctorName.Location = new System.Drawing.Point(123, 62);
            this.textEditDoctorName.MenuManager = this.ribbonControl1;
            this.textEditDoctorName.Name = "textEditDoctorName";
            this.textEditDoctorName.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditDoctorName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditDoctorName.Size = new System.Drawing.Size(150, 20);
            this.textEditDoctorName.TabIndex = 1;
            // 
            // textEditFatherName
            // 
            this.textEditFatherName.Location = new System.Drawing.Point(123, 173);
            this.textEditFatherName.MenuManager = this.ribbonControl1;
            this.textEditFatherName.Name = "textEditFatherName";
            this.textEditFatherName.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditFatherName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditFatherName.Size = new System.Drawing.Size(150, 20);
            this.textEditFatherName.TabIndex = 4;
            // 
            // textEditMotherName
            // 
            this.textEditMotherName.Location = new System.Drawing.Point(123, 134);
            this.textEditMotherName.MenuManager = this.ribbonControl1;
            this.textEditMotherName.Name = "textEditMotherName";
            this.textEditMotherName.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditMotherName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditMotherName.Size = new System.Drawing.Size(150, 20);
            this.textEditMotherName.TabIndex = 3;
            // 
            // textEditTcNumber
            // 
            this.textEditTcNumber.Location = new System.Drawing.Point(123, 27);
            this.textEditTcNumber.MenuManager = this.ribbonControl1;
            this.textEditTcNumber.Name = "textEditTcNumber";
            this.textEditTcNumber.Properties.Mask.EditMask = "\\d{11}";
            this.textEditTcNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditTcNumber.Size = new System.Drawing.Size(150, 20);
            this.textEditTcNumber.TabIndex = 0;
            // 
            // checkEditIsActive
            // 
            this.checkEditIsActive.EditValue = true;
            this.checkEditIsActive.Location = new System.Drawing.Point(121, 325);
            this.checkEditIsActive.MenuManager = this.ribbonControl1;
            this.checkEditIsActive.Name = "checkEditIsActive";
            this.checkEditIsActive.Properties.Caption = "Aktif";
            this.checkEditIsActive.Size = new System.Drawing.Size(73, 20);
            this.checkEditIsActive.TabIndex = 8;
            this.checkEditIsActive.CheckedChanged += new System.EventHandler(this.checkEditIsActive_CheckedChanged_1);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(28, 180);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 49;
            this.labelControl6.Text = "Baba Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "Anne Adı";
            // 
            // labelControlBirthday
            // 
            this.labelControlBirthday.Location = new System.Drawing.Point(29, 218);
            this.labelControlBirthday.Name = "labelControlBirthday";
            this.labelControlBirthday.Size = new System.Drawing.Size(62, 13);
            this.labelControlBirthday.TabIndex = 47;
            this.labelControlBirthday.Text = "Doğum Tarihi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Tc Numarası";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 259);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 45;
            this.labelControl4.Text = "Departman Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 293);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 44;
            this.labelControl3.Text = "Ünvanı";
            // 
            // LabelControlSurname
            // 
            this.LabelControlSurname.Location = new System.Drawing.Point(29, 100);
            this.LabelControlSurname.Name = "LabelControlSurname";
            this.LabelControlSurname.Size = new System.Drawing.Size(32, 13);
            this.LabelControlSurname.TabIndex = 43;
            this.LabelControlSurname.Text = "Soyadı";
            // 
            // LabelControlName
            // 
            this.LabelControlName.Location = new System.Drawing.Point(28, 65);
            this.LabelControlName.Name = "LabelControlName";
            this.LabelControlName.Size = new System.Drawing.Size(15, 13);
            this.LabelControlName.TabIndex = 42;
            this.LabelControlName.Text = "Adı";
            // 
            // labelControlMail
            // 
            this.labelControlMail.Location = new System.Drawing.Point(315, 511);
            this.labelControlMail.Name = "labelControlMail";
            this.labelControlMail.Size = new System.Drawing.Size(61, 13);
            this.labelControlMail.TabIndex = 52;
            this.labelControlMail.Text = "E-mail Adresi";
            // 
            // textEditPhone
            // 
            this.textEditPhone.Location = new System.Drawing.Point(104, 508);
            this.textEditPhone.MenuManager = this.ribbonControl1;
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Mask.EditMask = "\\d{10}";
            this.textEditPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditPhone.Size = new System.Drawing.Size(145, 20);
            this.textEditPhone.TabIndex = 1;
            // 
            // simpleButtonNewPhone
            // 
            this.simpleButtonNewPhone.Location = new System.Drawing.Point(255, 505);
            this.simpleButtonNewPhone.Name = "simpleButtonNewPhone";
            this.simpleButtonNewPhone.Size = new System.Drawing.Size(45, 23);
            this.simpleButtonNewPhone.TabIndex = 68;
            this.simpleButtonNewPhone.Text = "Ekle";
            this.simpleButtonNewPhone.Click += new System.EventHandler(this.simpleButtonNewPhone_Click);
            // 
            // labelControlPhone
            // 
            this.labelControlPhone.Location = new System.Drawing.Point(15, 511);
            this.labelControlPhone.Name = "labelControlPhone";
            this.labelControlPhone.Size = new System.Drawing.Size(83, 13);
            this.labelControlPhone.TabIndex = 51;
            this.labelControlPhone.Text = "Telefon Numarası";
            // 
            // textEditMail
            // 
            this.textEditMail.Location = new System.Drawing.Point(382, 508);
            this.textEditMail.MenuManager = this.ribbonControl1;
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Size = new System.Drawing.Size(145, 20);
            this.textEditMail.TabIndex = 2;
            // 
            // simpleButtonNewMail
            // 
            this.simpleButtonNewMail.Location = new System.Drawing.Point(533, 505);
            this.simpleButtonNewMail.Name = "simpleButtonNewMail";
            this.simpleButtonNewMail.Size = new System.Drawing.Size(45, 23);
            this.simpleButtonNewMail.TabIndex = 69;
            this.simpleButtonNewMail.Text = "Ekle";
            this.simpleButtonNewMail.Click += new System.EventHandler(this.simpleButtonNewMail_Click);
            // 
            // XtraFormDoctorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 553);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButtonNewMail);
            this.Controls.Add(this.textEditMail);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.labelControlPhone);
            this.Controls.Add(this.simpleButtonNewPhone);
            this.Controls.Add(this.textEditPhone);
            this.Controls.Add(this.labelControlMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormDoctorDetail.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormDoctorDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doktor Ekleme";
            this.Load += new System.EventHandler(this.XtraFormDoctorDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartmant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDegree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDoctorSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDoctorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFatherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMotherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTcNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemSaveNewDoctor;
        private BarButtonItem barButtonItemCancelNewDoctor;
        private BindingSource degreeBindingSource;
        private BindingSource departmentBindingSource;
        private PanelControl panelControl1;
        private LabelControl labelControl9;
        private LookUpEdit lookUpEditDepartmant;
        private LookUpEdit lookUpEditDegree;
        private DateEdit dateEditBirthDay;
        private TextEdit textEditDoctorSurname;
        private TextEdit textEditDoctorName;
        private TextEdit textEditFatherName;
        private TextEdit textEditMotherName;
        private TextEdit textEditTcNumber;
        private CheckEdit checkEditIsActive;
        private LabelControl labelControl6;
        private LabelControl labelControl2;
        private LabelControl labelControlBirthday;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl LabelControlSurname;
        private LabelControl LabelControlName;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupControl groupControl1;
        private GridControl gridControlPhones;
        private BindingSource bindingSourcePhones;
        private GridView gridViewPhones;
        private GridColumn gridColumn1;
        private GroupControl groupControl2;
        private GridControl gridControlMails;
        private BindingSource bindingSourceMail;
        private GridView gridViewMails;
        private GridColumn colMail;
        private LabelControl labelControlMail;
        private TextEdit textEditPhone;
        private SimpleButton simpleButtonNewPhone;
        private LabelControl labelControlPhone;
        private TextEdit textEditMail;
        private SimpleButton simpleButtonNewMail;
    }
}