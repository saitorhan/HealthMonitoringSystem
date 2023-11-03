using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.XtraTabbedMdi;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupOffice = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemExamination = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupManagament = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemDegreeDepartment = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemCityCauntry = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDiagnosisMedicament = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDoctor = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemHoliday = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupRegistration = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemPatient = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemRendezvous = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupPersonalize = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemThema = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.navBarControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 661);
            this.panel1.TabIndex = 1;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroupOffice;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupOffice,
            this.navBarGroupManagament,
            this.navBarGroupRegistration,
            this.navBarGroupPersonalize});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemDegreeDepartment,
            this.navBarItemCityCauntry,
            this.navBarItemDiagnosisMedicament,
            this.navBarItemDoctor,
            this.navBarItemExamination,
            this.navBarItemThema,
            this.navBarItemPatient,
            this.navBarItemRendezvous,
            this.navBarItemHoliday});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 207;
            this.navBarControl1.Size = new System.Drawing.Size(207, 661);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator();
            // 
            // navBarGroupOffice
            // 
            this.navBarGroupOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarGroupOffice.Appearance.Options.UseFont = true;
            this.navBarGroupOffice.Caption = "Muayene İşlemleri";
            this.navBarGroupOffice.Expanded = true;
            this.navBarGroupOffice.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.note;
            this.navBarGroupOffice.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemExamination)});
            this.navBarGroupOffice.Name = "navBarGroupOffice";
            // 
            // navBarItemExamination
            // 
            this.navBarItemExamination.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemExamination.Appearance.Options.UseFont = true;
            this.navBarItemExamination.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemExamination.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemExamination.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemExamination.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemExamination.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemExamination.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemExamination.AppearancePressed.Options.UseFont = true;
            this.navBarItemExamination.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemExamination.Caption = "Muayene";
            this.navBarItemExamination.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.add_to_favorites1;
            this.navBarItemExamination.Name = "navBarItemExamination";
            this.navBarItemExamination.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarGroupManagament
            // 
            this.navBarGroupManagament.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarGroupManagament.Appearance.Options.UseFont = true;
            this.navBarGroupManagament.Caption = "Yönetim Araçları";
            this.navBarGroupManagament.Expanded = true;
            this.navBarGroupManagament.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupManagament.ImageOptions.SmallImage")));
            this.navBarGroupManagament.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDegreeDepartment),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemCityCauntry),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDiagnosisMedicament),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDoctor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemHoliday)});
            this.navBarGroupManagament.Name = "navBarGroupManagament";
            // 
            // navBarItemDegreeDepartment
            // 
            this.navBarItemDegreeDepartment.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDegreeDepartment.Appearance.Options.UseFont = true;
            this.navBarItemDegreeDepartment.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDegreeDepartment.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemDegreeDepartment.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemDegreeDepartment.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemDegreeDepartment.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDegreeDepartment.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemDegreeDepartment.AppearancePressed.Options.UseFont = true;
            this.navBarItemDegreeDepartment.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemDegreeDepartment.Caption = "Departman ve Ünvan";
            this.navBarItemDegreeDepartment.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.add_link2;
            this.navBarItemDegreeDepartment.ImageOptions.SmallImageSize = new System.Drawing.Size(30, 30);
            this.navBarItemDegreeDepartment.Name = "navBarItemDegreeDepartment";
            this.navBarItemDegreeDepartment.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDegreeDepartment_LinkClicked);
            // 
            // navBarItemCityCauntry
            // 
            this.navBarItemCityCauntry.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemCityCauntry.Appearance.Options.UseFont = true;
            this.navBarItemCityCauntry.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemCityCauntry.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemCityCauntry.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemCityCauntry.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemCityCauntry.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemCityCauntry.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemCityCauntry.AppearancePressed.Options.UseFont = true;
            this.navBarItemCityCauntry.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemCityCauntry.Caption = "Şehir ve İlçe";
            this.navBarItemCityCauntry.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.globe_process1;
            this.navBarItemCityCauntry.ImageOptions.SmallImageSize = new System.Drawing.Size(30, 30);
            this.navBarItemCityCauntry.Name = "navBarItemCityCauntry";
            this.navBarItemCityCauntry.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarItemDiagnosisMedicament
            // 
            this.navBarItemDiagnosisMedicament.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDiagnosisMedicament.Appearance.Options.UseFont = true;
            this.navBarItemDiagnosisMedicament.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDiagnosisMedicament.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemDiagnosisMedicament.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemDiagnosisMedicament.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemDiagnosisMedicament.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDiagnosisMedicament.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemDiagnosisMedicament.AppearancePressed.Options.UseFont = true;
            this.navBarItemDiagnosisMedicament.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemDiagnosisMedicament.Caption = "Hastalıklar ve İlaçlar";
            this.navBarItemDiagnosisMedicament.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.red_heart1;
            this.navBarItemDiagnosisMedicament.ImageOptions.SmallImageSize = new System.Drawing.Size(30, 30);
            this.navBarItemDiagnosisMedicament.Name = "navBarItemDiagnosisMedicament";
            this.navBarItemDiagnosisMedicament.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDiagnosisMedicament_LinkClicked);
            // 
            // navBarItemDoctor
            // 
            this.navBarItemDoctor.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDoctor.Appearance.Options.UseFont = true;
            this.navBarItemDoctor.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDoctor.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemDoctor.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemDoctor.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemDoctor.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemDoctor.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemDoctor.AppearancePressed.Options.UseFont = true;
            this.navBarItemDoctor.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemDoctor.Caption = "Doktor";
            this.navBarItemDoctor.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.business_male_female_users;
            this.navBarItemDoctor.ImageOptions.SmallImageSize = new System.Drawing.Size(30, 30);
            this.navBarItemDoctor.Name = "navBarItemDoctor";
            this.navBarItemDoctor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarItemHoliday
            // 
            this.navBarItemHoliday.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemHoliday.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemHoliday.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemHoliday.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemHoliday.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemHoliday.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemHoliday.AppearancePressed.Options.UseFont = true;
            this.navBarItemHoliday.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemHoliday.Caption = "Tatiller";
            this.navBarItemHoliday.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.calendar_empty;
            this.navBarItemHoliday.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.calendar_empty;
            this.navBarItemHoliday.Name = "navBarItemHoliday";
            this.navBarItemHoliday.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemHoliday_LinkClicked);
            // 
            // navBarGroupRegistration
            // 
            this.navBarGroupRegistration.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarGroupRegistration.Appearance.Options.UseFont = true;
            this.navBarGroupRegistration.Caption = "Kayıt İşlemleri";
            this.navBarGroupRegistration.Expanded = true;
            this.navBarGroupRegistration.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.book_download;
            this.navBarGroupRegistration.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPatient),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRendezvous)});
            this.navBarGroupRegistration.Name = "navBarGroupRegistration";
            // 
            // navBarItemPatient
            // 
            this.navBarItemPatient.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemPatient.Appearance.Options.UseFont = true;
            this.navBarItemPatient.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemPatient.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemPatient.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemPatient.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemPatient.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemPatient.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemPatient.AppearancePressed.Options.UseFont = true;
            this.navBarItemPatient.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemPatient.Caption = "Hasta İşlemleri";
            this.navBarItemPatient.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.male_female_users1;
            this.navBarItemPatient.Name = "navBarItemPatient";
            this.navBarItemPatient.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPatient_LinkClicked);
            // 
            // navBarItemRendezvous
            // 
            this.navBarItemRendezvous.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemRendezvous.Appearance.Options.UseFont = true;
            this.navBarItemRendezvous.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemRendezvous.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemRendezvous.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemRendezvous.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemRendezvous.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemRendezvous.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemRendezvous.AppearancePressed.Options.UseFont = true;
            this.navBarItemRendezvous.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemRendezvous.Caption = "Randevu İşlemleri";
            this.navBarItemRendezvous.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.clock1;
            this.navBarItemRendezvous.Name = "navBarItemRendezvous";
            this.navBarItemRendezvous.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemRendezvous_LinkClicked);
            // 
            // navBarGroupPersonalize
            // 
            this.navBarGroupPersonalize.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarGroupPersonalize.Appearance.Options.UseFont = true;
            this.navBarGroupPersonalize.Caption = "Kullanıcı Ayarları";
            this.navBarGroupPersonalize.Expanded = true;
            this.navBarGroupPersonalize.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.user;
            this.navBarGroupPersonalize.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemThema)});
            this.navBarGroupPersonalize.Name = "navBarGroupPersonalize";
            // 
            // navBarItemThema
            // 
            this.navBarItemThema.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemThema.Appearance.Options.UseFont = true;
            this.navBarItemThema.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemThema.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarItemThema.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItemThema.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarItemThema.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItemThema.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.navBarItemThema.AppearancePressed.Options.UseFont = true;
            this.navBarItemThema.AppearancePressed.Options.UseForeColor = true;
            this.navBarItemThema.Caption = "Tema Değiştir";
            this.navBarItemThema.ImageOptions.SmallImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.tablet1;
            this.navBarItemThema.Name = "navBarItemThema";
            this.navBarItemThema.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormMain.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sağlık Takip Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private NavBarControl navBarControl1;
        private NavBarGroup navBarGroupOffice;
        private NavBarGroup navBarGroupManagament;
        private NavBarItem navBarItemDegreeDepartment;
        private XtraTabbedMdiManager xtraTabbedMdiManager1;
        private NavBarItem navBarItemCityCauntry;
        private NavBarItem navBarItemDiagnosisMedicament;
        private NavBarItem navBarItemDoctor;
        private NavBarItem navBarItemExamination;
        private NavBarGroup navBarGroupPersonalize;
        private NavBarItem navBarItemThema;
        private NavBarGroup navBarGroupRegistration;
        private NavBarItem navBarItemPatient;
        private NavBarItem navBarItemRendezvous;
        private NavBarItem navBarItemHoliday;


    }
}

