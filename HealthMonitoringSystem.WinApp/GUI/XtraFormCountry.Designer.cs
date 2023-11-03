using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using HealthMonitoringSystem.Entity;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormCountry));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemCountrySave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCountryName = new DevExpress.XtraEditors.TextEdit();
            this.checkEditIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxErrorProviderCountry = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditCities = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCountryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCities.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemCountrySave,
            this.barButtonItemCancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(238, 96);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemCountrySave
            // 
            this.barButtonItemCountrySave.Caption = "Kaydet";
            this.barButtonItemCountrySave.Id = 1;
            this.barButtonItemCountrySave.LargeGlyph = global::HealthMonitoringSystem.WinApp.Properties.Resources.save;
            this.barButtonItemCountrySave.Name = "barButtonItemCountrySave";
            this.barButtonItemCountrySave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCountrySave_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCountrySave);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 151);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "İlçe Adı";
            // 
            // textEditCountryName
            // 
            this.textEditCountryName.Location = new System.Drawing.Point(80, 148);
            this.textEditCountryName.MenuManager = this.ribbonControl1;
            this.textEditCountryName.Name = "textEditCountryName";
            this.textEditCountryName.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditCountryName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditCountryName.Size = new System.Drawing.Size(130, 20);
            this.textEditCountryName.TabIndex = 1;
            // 
            // checkEditIsActive
            // 
            this.checkEditIsActive.EditValue = true;
            this.checkEditIsActive.Location = new System.Drawing.Point(78, 174);
            this.checkEditIsActive.MenuManager = this.ribbonControl1;
            this.checkEditIsActive.Name = "checkEditIsActive";
            this.checkEditIsActive.Properties.Caption = "Aktif";
            this.checkEditIsActive.Size = new System.Drawing.Size(75, 19);
            this.checkEditIsActive.TabIndex = 2;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(City);
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.cityBindingSource;
            // 
            // dxErrorProviderCountry
            // 
            this.dxErrorProviderCountry.ContainerControl = this;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "İl seçiniz";
            // 
            // lookUpEditCities
            // 
            this.lookUpEditCities.Location = new System.Drawing.Point(80, 110);
            this.lookUpEditCities.MenuManager = this.ribbonControl1;
            this.lookUpEditCities.Name = "lookUpEditCities";
            this.lookUpEditCities.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCities.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Şehirler", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditCities.Properties.DataSource = this.cityBindingSource;
            this.lookUpEditCities.Properties.DisplayMember = "Name";
            this.lookUpEditCities.Properties.NullText = "Şehir Seçiniz";
            this.lookUpEditCities.Properties.ValidateOnEnterKey = true;
            this.lookUpEditCities.Properties.ValueMember = "Id";
            this.lookUpEditCities.Size = new System.Drawing.Size(130, 20);
            this.lookUpEditCities.TabIndex = 0;
            // 
            // XtraFormCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 214);
            this.Controls.Add(this.lookUpEditCities);
            this.Controls.Add(this.checkEditIsActive);
            this.Controls.Add(this.textEditCountryName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormCountry";
            this.Text = "İlçe İşlemleri";
            this.Load += new System.EventHandler(this.XtraFormCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCountryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCities.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemCountrySave;
        private BarButtonItem barButtonItemCancel;
        private LabelControl labelControl2;
        private TextEdit textEditCountryName;
        private CheckEdit checkEditIsActive;
        private BindingSource cityBindingSource;
        private BindingSource countriesBindingSource;
        private DXErrorProvider dxErrorProviderCountry;
        private LookUpEdit lookUpEditCities;
        private LabelControl labelControl1;
    }
}