using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormExamDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormExamDetails));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlPrescription = new DevExpress.XtraGrid.GridControl();
            this.bindingSourcePrescription = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControlNextDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxDoctorNote = new System.Windows.Forms.TextBox();
            this.labelControlDiagnosis = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlLabResults = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceResults = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewLabResults = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControlRequests = new DevExpress.XtraEditors.ListBoxControl();
            this.bindingSourceLabRequests = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLabResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLabResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLabRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 500);
            this.panel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlPrescription);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 167);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(382, 333);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Reçete Bilgileri";
            // 
            // gridControlPrescription
            // 
            this.gridControlPrescription.DataSource = this.bindingSourcePrescription;
            this.gridControlPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrescription.Location = new System.Drawing.Point(2, 21);
            this.gridControlPrescription.MainView = this.gridView1;
            this.gridControlPrescription.Name = "gridControlPrescription";
            this.gridControlPrescription.Size = new System.Drawing.Size(378, 310);
            this.gridControlPrescription.TabIndex = 0;
            this.gridControlPrescription.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourcePrescription
            // 
            this.bindingSourcePrescription.DataSource = typeof(HealthMonitoringSystem.WinApp.PrescriptionItemService.PrescriptionItem);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControlPrescription;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "İlaç Adı";
            this.gridColumn1.FieldName = "Medicament.Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kullanma Sıklığı";
            this.gridColumn2.FieldName = "SUsePerDay";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControlNextDate);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textBoxDoctorNote);
            this.groupControl1.Controls.Add(this.labelControlDiagnosis);
            this.groupControl1.Controls.Add(this.labelControlDate);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(382, 167);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Muayene Bilgileri";
            // 
            // labelControlNextDate
            // 
            this.labelControlNextDate.Location = new System.Drawing.Point(82, 53);
            this.labelControlNextDate.Name = "labelControlNextDate";
            this.labelControlNextDate.Size = new System.Drawing.Size(63, 13);
            this.labelControlNextDate.TabIndex = 7;
            this.labelControlNextDate.Text = "labelControl5";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Kontrol Tarihi";
            // 
            // textBoxDoctorNote
            // 
            this.textBoxDoctorNote.Location = new System.Drawing.Point(82, 91);
            this.textBoxDoctorNote.Multiline = true;
            this.textBoxDoctorNote.Name = "textBoxDoctorNote";
            this.textBoxDoctorNote.ReadOnly = true;
            this.textBoxDoctorNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDoctorNote.Size = new System.Drawing.Size(295, 66);
            this.textBoxDoctorNote.TabIndex = 5;
            // 
            // labelControlDiagnosis
            // 
            this.labelControlDiagnosis.Location = new System.Drawing.Point(82, 72);
            this.labelControlDiagnosis.Name = "labelControlDiagnosis";
            this.labelControlDiagnosis.Size = new System.Drawing.Size(63, 13);
            this.labelControlDiagnosis.TabIndex = 4;
            this.labelControlDiagnosis.Text = "labelControl4";
            // 
            // labelControlDate
            // 
            this.labelControlDate.Location = new System.Drawing.Point(82, 34);
            this.labelControlDate.Name = "labelControlDate";
            this.labelControlDate.Size = new System.Drawing.Size(63, 13);
            this.labelControlDate.TabIndex = 3;
            this.labelControlDate.Text = "labelControl4";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Doktor Noto";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Teşhis";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tarih";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl4);
            this.panel2.Controls.Add(this.groupControl3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(391, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 500);
            this.panel2.TabIndex = 1;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gridControlLabResults);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 139);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(383, 361);
            this.groupControl4.TabIndex = 1;
            // 
            // gridControlLabResults
            // 
            this.gridControlLabResults.DataSource = this.bindingSourceResults;
            this.gridControlLabResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLabResults.Location = new System.Drawing.Point(2, 21);
            this.gridControlLabResults.MainView = this.gridViewLabResults;
            this.gridControlLabResults.Name = "gridControlLabResults";
            this.gridControlLabResults.Size = new System.Drawing.Size(379, 338);
            this.gridControlLabResults.TabIndex = 0;
            this.gridControlLabResults.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLabResults});
            // 
            // bindingSourceResults
            // 
            this.bindingSourceResults.DataSource = typeof(HealthMonitoringSystem.WinApp.LaboratoryRequestItemService.LaboratoryRequestItem);
            // 
            // gridViewLabResults
            // 
            this.gridViewLabResults.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewLabResults.GridControl = this.gridControlLabResults;
            this.gridViewLabResults.Name = "gridViewLabResults";
            this.gridViewLabResults.OptionsBehavior.Editable = false;
            this.gridViewLabResults.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tetkik";
            this.gridColumn3.FieldName = "LaboratoryRequestType.Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 153;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Min";
            this.gridColumn4.FieldName = "LaboratoryRequestType.Min";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 68;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Max";
            this.gridColumn5.FieldName = "LaboratoryRequestType.Max";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 68;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Sonuç";
            this.gridColumn6.FieldName = "Result";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 74;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.listBoxControlRequests);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(383, 139);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Laboratuvar İstekleri";
            // 
            // listBoxControlRequests
            // 
            this.listBoxControlRequests.DataSource = this.bindingSourceLabRequests;
            this.listBoxControlRequests.DisplayMember = "DateTime";
            this.listBoxControlRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControlRequests.Location = new System.Drawing.Point(2, 21);
            this.listBoxControlRequests.Name = "listBoxControlRequests";
            this.listBoxControlRequests.Size = new System.Drawing.Size(379, 116);
            this.listBoxControlRequests.TabIndex = 0;
            this.listBoxControlRequests.ValueMember = "Id";
            // 
            // bindingSourceLabRequests
            // 
            this.bindingSourceLabRequests.DataSource = typeof(HealthMonitoringSystem.WinApp.LaboratoryRequestService.LaboratoryRequest);
            this.bindingSourceLabRequests.CurrentChanged += new System.EventHandler(this.bindingSourceLabRequests_CurrentChanged);
            // 
            // XtraFormExamDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormExamDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Geçmiş Muayene";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLabResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLabResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLabRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupControl groupControl2;
        private GroupControl groupControl1;
        private TextBox textBoxDoctorNote;
        private LabelControl labelControlDiagnosis;
        private LabelControl labelControlDate;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private LabelControl labelControlNextDate;
        private LabelControl labelControl4;
        private GridControl gridControlPrescription;
        private GridView gridView1;
        private BindingSource bindingSourcePrescription;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private Panel panel2;
        private GroupControl groupControl4;
        private GridControl gridControlLabResults;
        private GridView gridViewLabResults;
        private GroupControl groupControl3;
        private BindingSource bindingSourceLabRequests;
        private BindingSource bindingSourceResults;
        private ListBoxControl listBoxControlRequests;
        private GridColumn gridColumn3;
        private GridColumn gridColumn4;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
    }
}