using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormDegree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDegree));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditShortName = new DevExpress.XtraEditors.TextEdit();
            this.checkEditActive = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditAdmin = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditShortName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAdmin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemSave,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(255, 126);
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "İptal";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.LargeImage = global::HealthMonitoringSystem.WinApp.Properties.Resources.remove;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 135);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 161);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kısa Adı:";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(85, 132);
            this.textEditName.MenuManager = this.ribbonControl1;
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Mask.EditMask = "[A-Z ĞÜŞİÖÇ10-9]+";
            this.textEditName.Properties.Mask.IgnoreMaskBlank = false;
            this.textEditName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditName.Properties.Mask.ShowPlaceHolders = false;
            this.textEditName.Size = new System.Drawing.Size(141, 20);
            this.textEditName.TabIndex = 0;
            // 
            // textEditShortName
            // 
            this.textEditShortName.Location = new System.Drawing.Point(85, 158);
            this.textEditShortName.MenuManager = this.ribbonControl1;
            this.textEditShortName.Name = "textEditShortName";
            this.textEditShortName.Properties.Mask.EditMask = "[A-Z ĞÜŞİÖÇ10-9.]+";
            this.textEditShortName.Properties.Mask.IgnoreMaskBlank = false;
            this.textEditShortName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditShortName.Properties.Mask.ShowPlaceHolders = false;
            this.textEditShortName.Size = new System.Drawing.Size(141, 20);
            this.textEditShortName.TabIndex = 1;
            // 
            // checkEditActive
            // 
            this.checkEditActive.EditValue = true;
            this.checkEditActive.Location = new System.Drawing.Point(83, 209);
            this.checkEditActive.MenuManager = this.ribbonControl1;
            this.checkEditActive.Name = "checkEditActive";
            this.checkEditActive.Properties.Caption = "Aktif";
            this.checkEditActive.Size = new System.Drawing.Size(75, 20);
            this.checkEditActive.TabIndex = 2;
            this.checkEditActive.CheckedChanged += new System.EventHandler(this.checkEditActive_CheckedChanged);
            // 
            // checkEditAdmin
            // 
            this.checkEditAdmin.Location = new System.Drawing.Point(83, 184);
            this.checkEditAdmin.MenuManager = this.ribbonControl1;
            this.checkEditAdmin.Name = "checkEditAdmin";
            this.checkEditAdmin.Properties.Caption = "Yönetici Değil";
            this.checkEditAdmin.Size = new System.Drawing.Size(94, 20);
            this.checkEditAdmin.TabIndex = 4;
            this.checkEditAdmin.CheckedChanged += new System.EventHandler(this.checkEditAdmin_CheckedChanged);
            // 
            // XtraFormDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 243);
            this.Controls.Add(this.checkEditAdmin);
            this.Controls.Add(this.checkEditActive);
            this.Controls.Add(this.textEditShortName);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormDegree.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormDegree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ünvan İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditShortName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAdmin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemSave;
        private BarButtonItem barButtonItem1;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private TextEdit textEditName;
        private TextEdit textEditShortName;
        private CheckEdit checkEditActive;
        private CheckEdit checkEditAdmin;
    }
}