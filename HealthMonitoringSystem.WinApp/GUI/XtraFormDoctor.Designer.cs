using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using HealthMonitoringSystem.Entity;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDoctor));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemNewDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDetailDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlDoctor = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceDoctor = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDegree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctorMails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctorPhones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.doctorMailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorPhonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceMail = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePhone = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPhonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhone)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemNewDoctor,
            this.barButtonItemEditDoctor,
            this.barButtonItemDeleteDoctor,
            this.barButtonItemDetailDoctor,
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
            // barButtonItemNewDoctor
            // 
            this.barButtonItemNewDoctor.Caption = "Yeni";
            this.barButtonItemNewDoctor.Id = 1;
            this.barButtonItemNewDoctor.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.add;
            this.barButtonItemNewDoctor.Name = "barButtonItemNewDoctor";
            this.barButtonItemNewDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNewDoctor_ItemClick);
            // 
            // barButtonItemEditDoctor
            // 
            this.barButtonItemEditDoctor.Caption = "Düzenle";
            this.barButtonItemEditDoctor.Id = 2;
            this.barButtonItemEditDoctor.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.barButtonItemEditDoctor.Name = "barButtonItemEditDoctor";
            this.barButtonItemEditDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditDoctor_ItemClick);
            // 
            // barButtonItemDeleteDoctor
            // 
            this.barButtonItemDeleteDoctor.Caption = "Sil";
            this.barButtonItemDeleteDoctor.Id = 3;
            this.barButtonItemDeleteDoctor.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.barButtonItemDeleteDoctor.Name = "barButtonItemDeleteDoctor";
            this.barButtonItemDeleteDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteDoctor_ItemClick);
            // 
            // barButtonItemDetailDoctor
            // 
            this.barButtonItemDetailDoctor.Caption = "Detay";
            this.barButtonItemDetailDoctor.Id = 4;
            this.barButtonItemDetailDoctor.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.note;
            this.barButtonItemDetailDoctor.Name = "barButtonItemDetailDoctor";
            this.barButtonItemDetailDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDetailDoctor_ItemClick);
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
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemNewDoctor);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemEditDoctor);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDetailDoctor);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDeleteDoctor);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Doktor İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemPrint);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Genel İşlemler";
            // 
            // barButtonItemPrint
            // 
            this.barButtonItemPrint.Caption = "Doktor Listesini Yazdır";
            this.barButtonItemPrint.Id = 6;
            this.barButtonItemPrint.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.printer;
            this.barButtonItemPrint.Name = "barButtonItemPrint";
            this.barButtonItemPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPrint_ItemClick);
            // 
            // gridControlDoctor
            // 
            this.gridControlDoctor.DataSource = this.bindingSourceDoctor;
            this.gridControlDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDoctor.Location = new System.Drawing.Point(0, 96);
            this.gridControlDoctor.MainView = this.gridView1;
            this.gridControlDoctor.MenuManager = this.ribbonControl1;
            this.gridControlDoctor.Name = "gridControlDoctor";
            this.gridControlDoctor.Size = new System.Drawing.Size(771, 330);
            this.gridControlDoctor.TabIndex = 1;
            this.gridControlDoctor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // bindingSourceDoctor
            // 
            this.bindingSourceDoctor.DataSource = typeof(Doctor);
            this.bindingSourceDoctor.CurrentChanged += new System.EventHandler(this.bindingSourceDoctor_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDegree,
            this.colDepartment,
            this.colName,
            this.colSurname,
            this.colDoctorMails,
            this.colDoctorPhones});
            this.gridView1.DefaultRelationIndex = 1;
            this.gridView1.GridControl = this.gridControlDoctor;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridView1.OptionsDetail.AutoZoomDetail = true;
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            // 
            // colDegree
            // 
            this.colDegree.Caption = "Ünvan";
            this.colDegree.FieldName = "Degree.ShortName";
            this.colDegree.Name = "colDegree";
            this.colDegree.Visible = true;
            this.colDegree.VisibleIndex = 0;
            // 
            // colDepartment
            // 
            this.colDepartment.Caption = "Departman";
            this.colDepartment.FieldName = "Department.Name";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.Caption = "Ad";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Soyad";
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 3;
            // 
            // colDoctorMails
            // 
            this.colDoctorMails.Caption = "Baba Adı";
            this.colDoctorMails.FieldName = "FatherName";
            this.colDoctorMails.Name = "colDoctorMails";
            this.colDoctorMails.Visible = true;
            this.colDoctorMails.VisibleIndex = 4;
            // 
            // colDoctorPhones
            // 
            this.colDoctorPhones.Caption = "Anne Adı";
            this.colDoctorPhones.FieldName = "MotherName";
            this.colDoctorPhones.Name = "colDoctorPhones";
            this.colDoctorPhones.Visible = true;
            this.colDoctorPhones.VisibleIndex = 5;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControlDoctor;
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
            // doctorMailsBindingSource
            // 
            this.doctorMailsBindingSource.DataMember = "DoctorMails";
            this.doctorMailsBindingSource.DataSource = this.bindingSourceDoctor;
            // 
            // doctorPhonesBindingSource
            // 
            this.doctorPhonesBindingSource.DataMember = "DoctorPhones";
            this.doctorPhonesBindingSource.DataSource = this.bindingSourceDoctor;
            // 
            // bindingSourceMail
            // 
            this.bindingSourceMail.DataSource = typeof(DoctorMail);
            // 
            // bindingSourcePhone
            // 
            this.bindingSourcePhone.DataSource = typeof(DoctorPhone);
            // 
            // XtraFormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 426);
            this.Controls.Add(this.gridControlDoctor);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doktor İşlemleri";
            this.Load += new System.EventHandler(this.XtraFormDoctor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPhonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemNewDoctor;
        private BarButtonItem barButtonItemEditDoctor;
        private BarButtonItem barButtonItemDeleteDoctor;
        private GridControl gridControlDoctor;
        private BindingSource bindingSourceDoctor;
        private BindingSource bindingSourceMail;
        private BindingSource bindingSourcePhone;
        private BarButtonItem barButtonItemDetailDoctor;
        private BindingSource doctorMailsBindingSource;
        private BindingSource doctorPhonesBindingSource;
        private BarButtonItem barButtonItemRefresh;
        private RibbonPageGroup ribbonPageGroup2;
        private GridView gridView1;
        private GridColumn colDegree;
        private GridColumn colDepartment;
        private GridColumn colName;
        private GridColumn colSurname;
        private GridColumn colDoctorMails;
        private GridColumn colDoctorPhones;
        private BarButtonItem barButtonItemPrint;
        private GridView gridView2;
        private GridColumn gridColumn1;
    }
}