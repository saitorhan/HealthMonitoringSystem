using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormExaminationDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormExaminationDetail));
            this.groupControlPatients = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxControlRandevozous = new DevExpress.XtraEditors.ListBoxControl();
            this.bindingSourceExaminations = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControlWaitingLabs = new DevExpress.XtraEditors.ListBoxControl();
            this.bindingSourceLabResult = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControlCurrentExamination = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonLastExams = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPrintLabResult = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLabRequest = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuItems = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemWithPres = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemWithoutPres = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemWithCons = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControlNameSurname = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.checkEditCanSendMessage = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNextDay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditDiagnosis = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingSourceDiagnosis = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlLabResults = new DevExpress.XtraEditors.GroupControl();
            this.gridControlLabResults = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceItems = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlMessages = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMessages = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceMessages = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMessages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlPastExaminations = new DevExpress.XtraEditors.GroupControl();
            this.gridControlPastExaminations = new DevExpress.XtraGrid.GridControl();
            this.bindingSourcePastExaminations = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPastExams = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNextTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStripFinishExamination = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reçeteliMuayeneBitirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteYazmadanMuayeneyiBitirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerGetPatients = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripShow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.muayeneOlmuslariGizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneOlmuslariGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPatients)).BeginInit();
            this.groupControlPatients.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlRandevozous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceExaminations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlWaitingLabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLabResult)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCurrentExamination)).BeginInit();
            this.groupControlCurrentExamination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCanSendMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNextDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDiagnosis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLabResults)).BeginInit();
            this.groupControlLabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLabResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMessages)).BeginInit();
            this.groupControlMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPastExaminations)).BeginInit();
            this.groupControlPastExaminations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPastExaminations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePastExaminations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPastExams)).BeginInit();
            this.contextMenuStripFinishExamination.SuspendLayout();
            this.contextMenuStripShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlPatients
            // 
            this.groupControlPatients.Controls.Add(this.tableLayoutPanel2);
            this.groupControlPatients.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlPatients.Location = new System.Drawing.Point(0, 0);
            this.groupControlPatients.Name = "groupControlPatients";
            this.groupControlPatients.Size = new System.Drawing.Size(191, 661);
            this.groupControlPatients.TabIndex = 0;
            this.groupControlPatients.Text = "Sıradaki Hastalar";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxControlRandevozous, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(187, 638);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listBoxControlRandevozous
            // 
            this.listBoxControlRandevozous.ContextMenuStrip = this.contextMenuStripShow;
            this.listBoxControlRandevozous.DataSource = this.bindingSourceExaminations;
            this.listBoxControlRandevozous.DisplayMember = "Patient.NameSurname";
            this.listBoxControlRandevozous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControlRandevozous.Location = new System.Drawing.Point(3, 3);
            this.listBoxControlRandevozous.Name = "listBoxControlRandevozous";
            this.listBoxControlRandevozous.Size = new System.Drawing.Size(181, 440);
            this.listBoxControlRandevozous.TabIndex = 0;
            this.listBoxControlRandevozous.ValueMember = "PatientId";
            // 
            // bindingSourceExaminations
            // 
            this.bindingSourceExaminations.CurrentChanged += new System.EventHandler(this.bindingSourceExaminations_CurrentChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listBoxControlWaitingLabs);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 449);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(181, 186);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Laboratuvar İstekleri";
            // 
            // listBoxControlWaitingLabs
            // 
            this.listBoxControlWaitingLabs.DataSource = this.bindingSourceLabResult;
            this.listBoxControlWaitingLabs.DisplayMember = "DateTime";
            this.listBoxControlWaitingLabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControlWaitingLabs.Location = new System.Drawing.Point(2, 21);
            this.listBoxControlWaitingLabs.Name = "listBoxControlWaitingLabs";
            this.listBoxControlWaitingLabs.Size = new System.Drawing.Size(177, 163);
            this.listBoxControlWaitingLabs.TabIndex = 0;
            this.listBoxControlWaitingLabs.ValueMember = "Id";
            // 
            // bindingSourceLabResult
            // 
            this.bindingSourceLabResult.DataSource = typeof(HealthMonitoringSystem.WinApp.ExaminationService.LaboratoryRequest);
            this.bindingSourceLabResult.CurrentChanged += new System.EventHandler(this.bindingSourceLabResult_CurrentChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControlCurrentExamination, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControlLabResults, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControlMessages, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControlPastExaminations, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(191, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 661);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupControlCurrentExamination
            // 
            this.groupControlCurrentExamination.Controls.Add(this.simpleButtonLastExams);
            this.groupControlCurrentExamination.Controls.Add(this.simpleButtonPrintLabResult);
            this.groupControlCurrentExamination.Controls.Add(this.simpleButtonLabRequest);
            this.groupControlCurrentExamination.Controls.Add(this.dropDownButton1);
            this.groupControlCurrentExamination.Controls.Add(this.labelControlNameSurname);
            this.groupControlCurrentExamination.Controls.Add(this.labelControl5);
            this.groupControlCurrentExamination.Controls.Add(this.checkEditCanSendMessage);
            this.groupControlCurrentExamination.Controls.Add(this.labelControl4);
            this.groupControlCurrentExamination.Controls.Add(this.textEditNextDay);
            this.groupControlCurrentExamination.Controls.Add(this.labelControl3);
            this.groupControlCurrentExamination.Controls.Add(this.textBoxNote);
            this.groupControlCurrentExamination.Controls.Add(this.labelControl2);
            this.groupControlCurrentExamination.Controls.Add(this.lookUpEditDiagnosis);
            this.groupControlCurrentExamination.Controls.Add(this.labelControl1);
            this.groupControlCurrentExamination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCurrentExamination.Location = new System.Drawing.Point(3, 3);
            this.groupControlCurrentExamination.Name = "groupControlCurrentExamination";
            this.groupControlCurrentExamination.Size = new System.Drawing.Size(390, 324);
            this.groupControlCurrentExamination.TabIndex = 0;
            this.groupControlCurrentExamination.Text = "Şuanki Muayene Bilgisi";
            // 
            // simpleButtonLastExams
            // 
            this.simpleButtonLastExams.Location = new System.Drawing.Point(5, 270);
            this.simpleButtonLastExams.Name = "simpleButtonLastExams";
            this.simpleButtonLastExams.Size = new System.Drawing.Size(208, 29);
            this.simpleButtonLastExams.TabIndex = 13;
            this.simpleButtonLastExams.Text = "Geçmiş Muayene ve Mesajlaşma Bilgileri";
            this.simpleButtonLastExams.Click += new System.EventHandler(this.simpleButtonLastExams_Click);
            // 
            // simpleButtonPrintLabResult
            // 
            this.simpleButtonPrintLabResult.Location = new System.Drawing.Point(219, 270);
            this.simpleButtonPrintLabResult.Name = "simpleButtonPrintLabResult";
            this.simpleButtonPrintLabResult.Size = new System.Drawing.Size(166, 29);
            this.simpleButtonPrintLabResult.TabIndex = 12;
            this.simpleButtonPrintLabResult.Text = "Laboratuvar Sonuçlarını Yazdır";
            this.simpleButtonPrintLabResult.Click += new System.EventHandler(this.simpleButtonPrintLabResult_Click);
            // 
            // simpleButtonLabRequest
            // 
            this.simpleButtonLabRequest.Location = new System.Drawing.Point(5, 241);
            this.simpleButtonLabRequest.Name = "simpleButtonLabRequest";
            this.simpleButtonLabRequest.Size = new System.Drawing.Size(208, 23);
            this.simpleButtonLabRequest.TabIndex = 11;
            this.simpleButtonLabRequest.Text = "Laboratuvar İsteği Oluştur";
            this.simpleButtonLabRequest.Click += new System.EventHandler(this.simpleButtonLabRequest_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropDownButton1.DropDownControl = this.popupMenuItems;
            this.dropDownButton1.Location = new System.Drawing.Point(219, 241);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(166, 23);
            this.dropDownButton1.TabIndex = 10;
            this.dropDownButton1.Text = "Muayene Bitirme Seçenekleri";
            // 
            // popupMenuItems
            // 
            this.popupMenuItems.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemWithPres),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemWithoutPres),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemWithCons)});
            this.popupMenuItems.Manager = this.barManager1;
            this.popupMenuItems.Name = "popupMenuItems";
            // 
            // barButtonItemWithPres
            // 
            this.barButtonItemWithPres.Caption = "Reçeteli Muayene Kapat";
            this.barButtonItemWithPres.Id = 0;
            this.barButtonItemWithPres.Name = "barButtonItemWithPres";
            this.barButtonItemWithPres.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemWithPres_ItemClick);
            // 
            // barButtonItemWithoutPres
            // 
            this.barButtonItemWithoutPres.Caption = "Reçetesiz Muayene Kapat";
            this.barButtonItemWithoutPres.Id = 1;
            this.barButtonItemWithoutPres.Name = "barButtonItemWithoutPres";
            this.barButtonItemWithoutPres.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemWithoutPres_ItemClick);
            // 
            // barButtonItemWithCons
            // 
            this.barButtonItemWithCons.Caption = "Konsültasyonla Kapat";
            this.barButtonItemWithCons.Id = 2;
            this.barButtonItemWithCons.Name = "barButtonItemWithCons";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemWithPres,
            this.barButtonItemWithoutPres,
            this.barButtonItemWithCons});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(984, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 661);
            this.barDockControlBottom.Size = new System.Drawing.Size(984, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 661);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(984, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 661);
            // 
            // labelControlNameSurname
            // 
            this.labelControlNameSurname.Location = new System.Drawing.Point(135, 34);
            this.labelControlNameSurname.Name = "labelControlNameSurname";
            this.labelControlNameSurname.Size = new System.Drawing.Size(0, 13);
            this.labelControlNameSurname.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Hastanın Adı Soyadı";
            // 
            // checkEditCanSendMessage
            // 
            this.checkEditCanSendMessage.AutoSizeInLayoutControl = true;
            this.checkEditCanSendMessage.Location = new System.Drawing.Point(133, 216);
            this.checkEditCanSendMessage.Name = "checkEditCanSendMessage";
            this.checkEditCanSendMessage.Properties.Caption = "Mesaj Gönderemez";
            this.checkEditCanSendMessage.Size = new System.Drawing.Size(224, 19);
            this.checkEditCanSendMessage.TabIndex = 7;
            this.checkEditCanSendMessage.CheckedChanged += new System.EventHandler(this.checkEditCanSendMessage_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(241, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "gün sonra";
            // 
            // textEditNextDay
            // 
            this.textEditNextDay.Location = new System.Drawing.Point(135, 190);
            this.textEditNextDay.Name = "textEditNextDay";
            this.textEditNextDay.Properties.Mask.EditMask = "\\d*";
            this.textEditNextDay.Properties.Mask.IgnoreMaskBlank = false;
            this.textEditNextDay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditNextDay.Properties.Mask.ShowPlaceHolders = false;
            this.textEditNextDay.Size = new System.Drawing.Size(100, 20);
            this.textEditNextDay.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 193);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Sonraki Kontrol Zamanı";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(135, 79);
            this.textBoxNote.MaxLength = 500;
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(222, 105);
            this.textBoxNote.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Not";
            // 
            // lookUpEditDiagnosis
            // 
            this.lookUpEditDiagnosis.Location = new System.Drawing.Point(135, 53);
            this.lookUpEditDiagnosis.Name = "lookUpEditDiagnosis";
            this.lookUpEditDiagnosis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDiagnosis.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Teşhis", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditDiagnosis.Properties.DataSource = this.bindingSourceDiagnosis;
            this.lookUpEditDiagnosis.Properties.DisplayMember = "Name";
            this.lookUpEditDiagnosis.Properties.NullText = "Teşhisi Belirtin";
            this.lookUpEditDiagnosis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditDiagnosis.Properties.ValueMember = "Id";
            this.lookUpEditDiagnosis.Size = new System.Drawing.Size(222, 20);
            this.lookUpEditDiagnosis.TabIndex = 1;
            // 
            // bindingSourceDiagnosis
            // 
            this.bindingSourceDiagnosis.DataSource = typeof(HealthMonitoringSystem.WinApp.DiagnosisService.Diagnosis);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Teşhis";
            // 
            // groupControlLabResults
            // 
            this.groupControlLabResults.Controls.Add(this.gridControlLabResults);
            this.groupControlLabResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlLabResults.Location = new System.Drawing.Point(399, 3);
            this.groupControlLabResults.Name = "groupControlLabResults";
            this.groupControlLabResults.Size = new System.Drawing.Size(391, 324);
            this.groupControlLabResults.TabIndex = 1;
            this.groupControlLabResults.Text = "Laboratuvar Sonuçları";
            // 
            // gridControlLabResults
            // 
            this.gridControlLabResults.DataSource = this.bindingSourceItems;
            this.gridControlLabResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLabResults.Location = new System.Drawing.Point(2, 21);
            this.gridControlLabResults.MainView = this.gridView1;
            this.gridControlLabResults.Name = "gridControlLabResults";
            this.gridControlLabResults.Size = new System.Drawing.Size(387, 301);
            this.gridControlLabResults.TabIndex = 0;
            this.gridControlLabResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourceItems
            // 
            this.bindingSourceItems.DataSource = typeof(HealthMonitoringSystem.WinApp.LaboratoryRequestItemService.LaboratoryRequestItem);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colResult});
            this.gridView1.GridControl = this.gridControlLabResults;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tetkik";
            this.gridColumn1.FieldName = "LaboratoryRequestType.Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Min Değer";
            this.gridColumn2.FieldName = "LaboratoryRequestType.Min";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Max Değer";
            this.gridColumn3.FieldName = "LaboratoryRequestType.Max";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // colResult
            // 
            this.colResult.Caption = "Sonuç";
            this.colResult.FieldName = "Result";
            this.colResult.Name = "colResult";
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 3;
            // 
            // groupControlMessages
            // 
            this.groupControlMessages.Controls.Add(this.gridControlMessages);
            this.groupControlMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlMessages.Location = new System.Drawing.Point(3, 333);
            this.groupControlMessages.Name = "groupControlMessages";
            this.groupControlMessages.Size = new System.Drawing.Size(390, 325);
            this.groupControlMessages.TabIndex = 2;
            this.groupControlMessages.Text = "Mesajlar";
            // 
            // gridControlMessages
            // 
            this.gridControlMessages.DataSource = this.bindingSourceMessages;
            this.gridControlMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMessages.Location = new System.Drawing.Point(2, 21);
            this.gridControlMessages.MainView = this.gridViewMessages;
            this.gridControlMessages.Name = "gridControlMessages";
            this.gridControlMessages.Size = new System.Drawing.Size(386, 302);
            this.gridControlMessages.TabIndex = 0;
            this.gridControlMessages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMessages});
            // 
            // bindingSourceMessages
            // 
            this.bindingSourceMessages.DataSource = typeof(HealthMonitoringSystem.WinApp.MessageService.Message);
            // 
            // gridViewMessages
            // 
            this.gridViewMessages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDateTime,
            this.gridColumn5,
            this.colMesage});
            this.gridViewMessages.GridControl = this.gridControlMessages;
            this.gridViewMessages.Name = "gridViewMessages";
            this.gridViewMessages.OptionsBehavior.Editable = false;
            this.gridViewMessages.OptionsView.ShowGroupPanel = false;
            // 
            // colDateTime
            // 
            this.colDateTime.Caption = "Tarih";
            this.colDateTime.DisplayFormat.FormatString = "dd MMMM yyyy HH:mm";
            this.colDateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateTime.FieldName = "DateTime";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Visible = true;
            this.colDateTime.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Gönderen";
            this.gridColumn5.FieldName = "From";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // colMesage
            // 
            this.colMesage.Caption = "Mesaj";
            this.colMesage.FieldName = "Mesage";
            this.colMesage.Name = "colMesage";
            this.colMesage.Visible = true;
            this.colMesage.VisibleIndex = 2;
            // 
            // groupControlPastExaminations
            // 
            this.groupControlPastExaminations.Controls.Add(this.gridControlPastExaminations);
            this.groupControlPastExaminations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlPastExaminations.Location = new System.Drawing.Point(399, 333);
            this.groupControlPastExaminations.Name = "groupControlPastExaminations";
            this.groupControlPastExaminations.Size = new System.Drawing.Size(391, 325);
            this.groupControlPastExaminations.TabIndex = 3;
            this.groupControlPastExaminations.Text = "Geçmişteki Muayeneler";
            // 
            // gridControlPastExaminations
            // 
            this.gridControlPastExaminations.DataSource = this.bindingSourcePastExaminations;
            this.gridControlPastExaminations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPastExaminations.Location = new System.Drawing.Point(2, 21);
            this.gridControlPastExaminations.MainView = this.gridViewPastExams;
            this.gridControlPastExaminations.Name = "gridControlPastExaminations";
            this.gridControlPastExaminations.Size = new System.Drawing.Size(387, 302);
            this.gridControlPastExaminations.TabIndex = 0;
            this.gridControlPastExaminations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPastExams});
            this.gridControlPastExaminations.DoubleClick += new System.EventHandler(this.gridControlPastExaminations_DoubleClick);
            // 
            // bindingSourcePastExaminations
            // 
            this.bindingSourcePastExaminations.DataSource = typeof(HealthMonitoringSystem.WinApp.ExaminationService.Examination);
            // 
            // gridViewPastExams
            // 
            this.gridViewPastExams.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTime,
            this.colNextTime,
            this.gridColumn4});
            this.gridViewPastExams.GridControl = this.gridControlPastExaminations;
            this.gridViewPastExams.Name = "gridViewPastExams";
            this.gridViewPastExams.OptionsBehavior.Editable = false;
            this.gridViewPastExams.OptionsView.ShowGroupPanel = false;
            // 
            // colTime
            // 
            this.colTime.Caption = "Tarih";
            this.colTime.DisplayFormat.FormatString = "dd MMMM yyyy";
            this.colTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTime.FieldName = "Time";
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 0;
            // 
            // colNextTime
            // 
            this.colNextTime.Caption = "Kontrol Tarihi";
            this.colNextTime.DisplayFormat.FormatString = "dd MMMM yyyy";
            this.colNextTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNextTime.FieldName = "NextTime";
            this.colNextTime.Name = "colNextTime";
            this.colNextTime.Visible = true;
            this.colNextTime.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Teşhis";
            this.gridColumn4.FieldName = "Diagnosis.DisplayName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // contextMenuStripFinishExamination
            // 
            this.contextMenuStripFinishExamination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reçeteliMuayeneBitirToolStripMenuItem,
            this.reçeteYazmadanMuayeneyiBitirToolStripMenuItem});
            this.contextMenuStripFinishExamination.Name = "contextMenuStripFinishExamination";
            this.contextMenuStripFinishExamination.Size = new System.Drawing.Size(253, 48);
            // 
            // reçeteliMuayeneBitirToolStripMenuItem
            // 
            this.reçeteliMuayeneBitirToolStripMenuItem.Name = "reçeteliMuayeneBitirToolStripMenuItem";
            this.reçeteliMuayeneBitirToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.reçeteliMuayeneBitirToolStripMenuItem.Text = "Reçeteli Muayene Bitir";
            // 
            // reçeteYazmadanMuayeneyiBitirToolStripMenuItem
            // 
            this.reçeteYazmadanMuayeneyiBitirToolStripMenuItem.Name = "reçeteYazmadanMuayeneyiBitirToolStripMenuItem";
            this.reçeteYazmadanMuayeneyiBitirToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.reçeteYazmadanMuayeneyiBitirToolStripMenuItem.Text = "Reçete Yazmadan Muayeneyi Bitir";
            // 
            // timerGetPatients
            // 
            this.timerGetPatients.Interval = 15000;
            this.timerGetPatients.Tick += new System.EventHandler(this.timerGetPatients_Tick);
            // 
            // contextMenuStripShow
            // 
            this.contextMenuStripShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muayeneOlmuslariGizleToolStripMenuItem,
            this.muayeneOlmuslariGösterToolStripMenuItem});
            this.contextMenuStripShow.Name = "contextMenuStripShow";
            this.contextMenuStripShow.Size = new System.Drawing.Size(215, 48);
            // 
            // muayeneOlmuslariGizleToolStripMenuItem
            // 
            this.muayeneOlmuslariGizleToolStripMenuItem.Name = "muayeneOlmuslariGizleToolStripMenuItem";
            this.muayeneOlmuslariGizleToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.muayeneOlmuslariGizleToolStripMenuItem.Text = "Muayene Olmuşları Gizle";
            this.muayeneOlmuslariGizleToolStripMenuItem.Click += new System.EventHandler(this.muayeneOlmuslariGizleToolStripMenuItem_Click);
            // 
            // muayeneOlmuslariGösterToolStripMenuItem
            // 
            this.muayeneOlmuslariGösterToolStripMenuItem.Name = "muayeneOlmuslariGösterToolStripMenuItem";
            this.muayeneOlmuslariGösterToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.muayeneOlmuslariGösterToolStripMenuItem.Text = "Muayene Olmuşları Göster";
            this.muayeneOlmuslariGösterToolStripMenuItem.Click += new System.EventHandler(this.muayeneOlmuslariGosterToolStripMenuItem_Click);
            // 
            // XtraFormExaminationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupControlPatients);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "XtraFormExaminationDetail";
            this.Text = "Muayene Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraFormExaminationDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XtraFormExaminationDetail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPatients)).EndInit();
            this.groupControlPatients.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlRandevozous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceExaminations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlWaitingLabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLabResult)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCurrentExamination)).EndInit();
            this.groupControlCurrentExamination.ResumeLayout(false);
            this.groupControlCurrentExamination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCanSendMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNextDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDiagnosis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLabResults)).EndInit();
            this.groupControlLabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLabResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMessages)).EndInit();
            this.groupControlMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPastExaminations)).EndInit();
            this.groupControlPastExaminations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPastExaminations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePastExaminations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPastExams)).EndInit();
            this.contextMenuStripFinishExamination.ResumeLayout(false);
            this.contextMenuStripShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControlPatients;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupControl groupControlCurrentExamination;
        private GroupControl groupControlLabResults;
        private GroupControl groupControlMessages;
        private GroupControl groupControlPastExaminations;
        private GridControl gridControlLabResults;
        private GridView gridView1;
        private GridControl gridControlMessages;
        private BindingSource bindingSourceMessages;
        private GridView gridViewMessages;
        private GridControl gridControlPastExaminations;
        private BindingSource bindingSourcePastExaminations;
        private GridView gridViewPastExams;
        private Timer timerGetPatients;
        private ListBoxControl listBoxControlRandevozous;
        private LookUpEdit lookUpEditDiagnosis;
        private BindingSource bindingSourceDiagnosis;
        private LabelControl labelControl1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupControl groupControl1;
        private ListBoxControl listBoxControlWaitingLabs;
        private CheckEdit checkEditCanSendMessage;
        private LabelControl labelControl4;
        private TextEdit textEditNextDay;
        private LabelControl labelControl3;
        private TextBox textBoxNote;
        private LabelControl labelControl2;
        private LabelControl labelControlNameSurname;
        private LabelControl labelControl5;
        private SimpleButton simpleButtonLabRequest;
        private DropDownButton dropDownButton1;
        private ContextMenuStrip contextMenuStripFinishExamination;
        private ToolStripMenuItem reçeteliMuayeneBitirToolStripMenuItem;
        private ToolStripMenuItem reçeteYazmadanMuayeneyiBitirToolStripMenuItem;
        private BindingSource bindingSourceExaminations;
        private BindingSource bindingSourceLabResult;
        private BindingSource bindingSourceItems;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private GridColumn colResult;
        private PopupMenu popupMenuItems;
        private BarButtonItem barButtonItemWithPres;
        private BarButtonItem barButtonItemWithoutPres;
        private BarManager barManager1;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItemWithCons;
        private SimpleButton simpleButtonPrintLabResult;
        private SimpleButton simpleButtonLastExams;
        private GridColumn colTime;
        private GridColumn colNextTime;
        private GridColumn gridColumn4;
        private GridColumn colDateTime;
        private GridColumn colMesage;
        private GridColumn gridColumn5;
        private ContextMenuStrip contextMenuStripShow;
        private ToolStripMenuItem muayeneOlmuslariGizleToolStripMenuItem;
        private ToolStripMenuItem muayeneOlmuslariGösterToolStripMenuItem;
    }
}