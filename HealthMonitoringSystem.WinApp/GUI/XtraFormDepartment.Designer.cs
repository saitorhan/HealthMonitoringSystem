using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDepartment));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.checkEditIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMin = new DevExpress.XtraEditors.TextEdit();
            this.textEditMax = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditGender = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGender.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(314, 96);
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 115);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Departman Adı:";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(135, 112);
            this.textEditName.MenuManager = this.ribbonControl1;
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ 1-9]+";
            this.textEditName.Properties.Mask.IgnoreMaskBlank = false;
            this.textEditName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditName.Properties.Mask.SaveLiteral = false;
            this.textEditName.Properties.Mask.ShowPlaceHolders = false;
            this.textEditName.Properties.MaxLength = 25;
            this.textEditName.Size = new System.Drawing.Size(169, 20);
            this.textEditName.TabIndex = 0;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // checkEditIsActive
            // 
            this.checkEditIsActive.EditValue = true;
            this.checkEditIsActive.Location = new System.Drawing.Point(133, 216);
            this.checkEditIsActive.MenuManager = this.ribbonControl1;
            this.checkEditIsActive.Name = "checkEditIsActive";
            this.checkEditIsActive.Properties.Caption = "Aktif";
            this.checkEditIsActive.Size = new System.Drawing.Size(75, 19);
            this.checkEditIsActive.TabIndex = 4;
            this.checkEditIsActive.CheckedChanged += new System.EventHandler(this.checkEditIsActive_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "En Düşük  Yaş (Ay):";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "En Yüksek  Yaş (Ay):";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Gelebilecek Cinsiyet:";
            // 
            // textEditMin
            // 
            this.textEditMin.Location = new System.Drawing.Point(135, 138);
            this.textEditMin.MenuManager = this.ribbonControl1;
            this.textEditMin.Name = "textEditMin";
            this.textEditMin.Properties.Mask.EditMask = "[0-9]+";
            this.textEditMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditMin.Properties.Mask.ShowPlaceHolders = false;
            this.textEditMin.Size = new System.Drawing.Size(169, 20);
            this.textEditMin.TabIndex = 1;
            // 
            // textEditMax
            // 
            this.textEditMax.Location = new System.Drawing.Point(135, 164);
            this.textEditMax.MenuManager = this.ribbonControl1;
            this.textEditMax.Name = "textEditMax";
            this.textEditMax.Properties.Mask.EditMask = "[0-9]+";
            this.textEditMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditMax.Properties.Mask.ShowPlaceHolders = false;
            this.textEditMax.Size = new System.Drawing.Size(169, 20);
            this.textEditMax.TabIndex = 2;
            // 
            // lookUpEditGender
            // 
            this.lookUpEditGender.Location = new System.Drawing.Point(135, 190);
            this.lookUpEditGender.MenuManager = this.ribbonControl1;
            this.lookUpEditGender.Name = "lookUpEditGender";
            this.lookUpEditGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGender.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Cinsiyet")});
            this.lookUpEditGender.Properties.DisplayMember = "Key";
            this.lookUpEditGender.Properties.NullText = "Herkes";
            this.lookUpEditGender.Properties.ValueMember = "Value";
            this.lookUpEditGender.Size = new System.Drawing.Size(169, 20);
            this.lookUpEditGender.TabIndex = 3;
            // 
            // XtraFormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 248);
            this.Controls.Add(this.lookUpEditGender);
            this.Controls.Add(this.textEditMax);
            this.Controls.Add(this.textEditMin);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.checkEditIsActive);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Departman İşlemleri";
            this.Load += new System.EventHandler(this.XtraFormDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGender.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemSave;
        private BarButtonItem barButtonItemCancel;
        private LabelControl labelControl1;
        private TextEdit textEditName;
        private DXErrorProvider dxErrorProvider1;
        private CheckEdit checkEditIsActive;
        private TextEdit textEditMax;
        private TextEdit textEditMin;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LookUpEdit lookUpEditGender;
    }
}