using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormPatient));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bindingSourceCities = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCountries = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceBloodGroups = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEditIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpEditBloodGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.comboBoxEditGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditBirthDay = new DevExpress.XtraEditors.DateEdit();
            this.textEditMother = new DevExpress.XtraEditors.TextEdit();
            this.textEditSurname = new DevExpress.XtraEditors.TextEdit();
            this.textEditFather = new DevExpress.XtraEditors.TextEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditTCNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.memoEditAdress = new DevExpress.XtraEditors.MemoEdit();
            this.lookUpEditCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditCity = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditMail = new DevExpress.XtraEditors.TextEdit();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBloodGroups)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBloodGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMother.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFather.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTCNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barButtonItemCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(627, 96);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // bindingSourceCities
            // 
            this.bindingSourceCities.DataSource = typeof(HealthMonitoringSystem.WinApp.CityService.City);
            // 
            // bindingSourceCountries
            // 
            this.bindingSourceCountries.DataSource = typeof(HealthMonitoringSystem.WinApp.CounrtyService.Country);
            // 
            // bindingSourceBloodGroups
            // 
            this.bindingSourceBloodGroups.DataSource = typeof(HealthMonitoringSystem.WinApp.BloodGroupService.BloodGroup);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 282);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkEditIsActive);
            this.groupControl1.Controls.Add(this.lookUpEditBloodGroup);
            this.groupControl1.Controls.Add(this.comboBoxEditGender);
            this.groupControl1.Controls.Add(this.dateEditBirthDay);
            this.groupControl1.Controls.Add(this.textEditMother);
            this.groupControl1.Controls.Add(this.textEditSurname);
            this.groupControl1.Controls.Add(this.textEditFather);
            this.groupControl1.Controls.Add(this.textEditName);
            this.groupControl1.Controls.Add(this.textEditTCNumber);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(307, 276);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kişisel Bilgiler";
            // 
            // checkEditIsActive
            // 
            this.checkEditIsActive.EditValue = true;
            this.checkEditIsActive.Location = new System.Drawing.Point(100, 241);
            this.checkEditIsActive.MenuManager = this.ribbonControl1;
            this.checkEditIsActive.Name = "checkEditIsActive";
            this.checkEditIsActive.Properties.Caption = "Aktif";
            this.checkEditIsActive.Size = new System.Drawing.Size(75, 19);
            this.checkEditIsActive.TabIndex = 8;
            this.checkEditIsActive.CheckedChanged += new System.EventHandler(this.checkEditIsActive_CheckedChanged);
            // 
            // lookUpEditBloodGroup
            // 
            this.lookUpEditBloodGroup.Location = new System.Drawing.Point(102, 215);
            this.lookUpEditBloodGroup.MenuManager = this.ribbonControl1;
            this.lookUpEditBloodGroup.Name = "lookUpEditBloodGroup";
            this.lookUpEditBloodGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditBloodGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Kan Grubu")});
            this.lookUpEditBloodGroup.Properties.DataSource = this.bindingSourceBloodGroups;
            this.lookUpEditBloodGroup.Properties.DisplayMember = "Name";
            this.lookUpEditBloodGroup.Properties.NullText = "Kan Grubu Seçiniz";
            this.lookUpEditBloodGroup.Properties.ValueMember = "Id";
            this.lookUpEditBloodGroup.Size = new System.Drawing.Size(188, 20);
            this.lookUpEditBloodGroup.TabIndex = 7;
            // 
            // comboBoxEditGender
            // 
            this.comboBoxEditGender.EditValue = "Erkek";
            this.comboBoxEditGender.Location = new System.Drawing.Point(102, 189);
            this.comboBoxEditGender.MenuManager = this.ribbonControl1;
            this.comboBoxEditGender.Name = "comboBoxEditGender";
            this.comboBoxEditGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditGender.Properties.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBoxEditGender.Size = new System.Drawing.Size(188, 20);
            this.comboBoxEditGender.TabIndex = 6;
            // 
            // dateEditBirthDay
            // 
            this.dateEditBirthDay.EditValue = null;
            this.dateEditBirthDay.Location = new System.Drawing.Point(102, 163);
            this.dateEditBirthDay.MenuManager = this.ribbonControl1;
            this.dateEditBirthDay.Name = "dateEditBirthDay";
            this.dateEditBirthDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthDay.Size = new System.Drawing.Size(188, 20);
            this.dateEditBirthDay.TabIndex = 5;
            // 
            // textEditMother
            // 
            this.textEditMother.Location = new System.Drawing.Point(102, 137);
            this.textEditMother.Name = "textEditMother";
            this.textEditMother.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditMother.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditMother.Size = new System.Drawing.Size(188, 20);
            this.textEditMother.TabIndex = 4;
            // 
            // textEditSurname
            // 
            this.textEditSurname.Location = new System.Drawing.Point(102, 85);
            this.textEditSurname.Name = "textEditSurname";
            this.textEditSurname.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditSurname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditSurname.Size = new System.Drawing.Size(188, 20);
            this.textEditSurname.TabIndex = 2;
            // 
            // textEditFather
            // 
            this.textEditFather.Location = new System.Drawing.Point(102, 111);
            this.textEditFather.Name = "textEditFather";
            this.textEditFather.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditFather.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditFather.Size = new System.Drawing.Size(188, 20);
            this.textEditFather.TabIndex = 3;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(102, 59);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditName.Size = new System.Drawing.Size(188, 20);
            this.textEditName.TabIndex = 1;
            // 
            // textEditTCNumber
            // 
            this.textEditTCNumber.Location = new System.Drawing.Point(102, 33);
            this.textEditTCNumber.MenuManager = this.ribbonControl1;
            this.textEditTCNumber.Name = "textEditTCNumber";
            this.textEditTCNumber.Properties.Mask.EditMask = "\\d{11}";
            this.textEditTCNumber.Properties.Mask.IgnoreMaskBlank = false;
            this.textEditTCNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditTCNumber.Properties.Mask.ShowPlaceHolders = false;
            this.textEditTCNumber.Size = new System.Drawing.Size(188, 20);
            this.textEditTCNumber.TabIndex = 0;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(5, 218);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(50, 13);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "Kan Grubu";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(5, 192);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 13);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Cinsiyeti";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 166);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(62, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Doğum Tarihi";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(5, 140);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(43, 13);
            this.labelControl13.TabIndex = 17;
            this.labelControl13.Text = "Anne Adı";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(5, 114);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(42, 13);
            this.labelControl12.TabIndex = 16;
            this.labelControl12.Text = "Baba Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Soyadı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "TC Kimlik No";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.memoEditAdress);
            this.groupControl2.Controls.Add(this.lookUpEditCountry);
            this.groupControl2.Controls.Add(this.lookUpEditCity);
            this.groupControl2.Controls.Add(this.textEditMail);
            this.groupControl2.Controls.Add(this.textEditPhone);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(316, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(308, 276);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "İletişim Bilgileri";
            // 
            // memoEditAdress
            // 
            this.memoEditAdress.Location = new System.Drawing.Point(102, 33);
            this.memoEditAdress.MenuManager = this.ribbonControl1;
            this.memoEditAdress.Name = "memoEditAdress";
            this.memoEditAdress.Size = new System.Drawing.Size(195, 71);
            this.memoEditAdress.TabIndex = 0;
            this.memoEditAdress.UseOptimizedRendering = true;
            // 
            // lookUpEditCountry
            // 
            this.lookUpEditCountry.Location = new System.Drawing.Point(102, 136);
            this.lookUpEditCountry.Name = "lookUpEditCountry";
            this.lookUpEditCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCountry.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "İlçe Adı")});
            this.lookUpEditCountry.Properties.DataSource = this.bindingSourceCountries;
            this.lookUpEditCountry.Properties.DisplayMember = "Name";
            this.lookUpEditCountry.Properties.NullText = "İlçe Seçiniz";
            this.lookUpEditCountry.Properties.ValueMember = "Id";
            this.lookUpEditCountry.Size = new System.Drawing.Size(195, 20);
            this.lookUpEditCountry.TabIndex = 2;
            // 
            // lookUpEditCity
            // 
            this.lookUpEditCity.Location = new System.Drawing.Point(102, 110);
            this.lookUpEditCity.MenuManager = this.ribbonControl1;
            this.lookUpEditCity.Name = "lookUpEditCity";
            this.lookUpEditCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Şehir Adı")});
            this.lookUpEditCity.Properties.DataSource = this.bindingSourceCities;
            this.lookUpEditCity.Properties.DisplayMember = "Name";
            this.lookUpEditCity.Properties.NullText = "Şehir Seçiniz";
            this.lookUpEditCity.Properties.ValueMember = "Id";
            this.lookUpEditCity.Size = new System.Drawing.Size(195, 20);
            this.lookUpEditCity.TabIndex = 1;
            this.lookUpEditCity.EditValueChanged += new System.EventHandler(this.lookUpEditCity_EditValueChanged);
            // 
            // textEditMail
            // 
            this.textEditMail.Location = new System.Drawing.Point(102, 188);
            this.textEditMail.Name = "textEditMail";
            this.textEditMail.Size = new System.Drawing.Size(195, 20);
            this.textEditMail.TabIndex = 4;
            // 
            // textEditPhone
            // 
            this.textEditPhone.Location = new System.Drawing.Point(102, 162);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Size = new System.Drawing.Size(195, 20);
            this.textEditPhone.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 191);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Mail Adresi";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 165);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(83, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Telefon Numarası";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 139);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "İlçesi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Şehri";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Adresi";
            // 
            // XtraFormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBloodGroups)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBloodGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMother.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFather.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTCNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemSave;
        private BarButtonItem barButtonItemCancel;
        private BindingSource bindingSourceCities;
        private BindingSource bindingSourceCountries;
        private BindingSource bindingSourceBloodGroups;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupControl groupControl1;
        private CheckEdit checkEditIsActive;
        private LookUpEdit lookUpEditBloodGroup;
        private ComboBoxEdit comboBoxEditGender;
        private DateEdit dateEditBirthDay;
        private TextEdit textEditMother;
        private TextEdit textEditSurname;
        private TextEdit textEditFather;
        private TextEdit textEditName;
        private TextEdit textEditTCNumber;
        private LabelControl labelControl11;
        private LabelControl labelControl10;
        private LabelControl labelControl9;
        private LabelControl labelControl13;
        private LabelControl labelControl12;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private GroupControl groupControl2;
        private MemoEdit memoEditAdress;
        private LookUpEdit lookUpEditCountry;
        private LookUpEdit lookUpEditCity;
        private TextEdit textEditMail;
        private TextEdit textEditPhone;
        private LabelControl labelControl8;
        private LabelControl labelControl7;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private LabelControl labelControl4;
    }
}