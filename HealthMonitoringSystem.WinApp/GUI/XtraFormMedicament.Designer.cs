using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormMedicament));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditNote = new DevExpress.XtraEditors.TextEdit();
            this.checkEditIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUseDay = new DevExpress.XtraEditors.TextEdit();
            this.textBoxUsePer = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUseDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUsePer.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(282, 96);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlaç Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Not";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(104, 112);
            this.textEditName.MenuManager = this.ribbonControl1;
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ 1-9]+";
            this.textEditName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditName.Size = new System.Drawing.Size(160, 20);
            this.textEditName.TabIndex = 0;
            // 
            // textEditNote
            // 
            this.textEditNote.Location = new System.Drawing.Point(104, 142);
            this.textEditNote.MenuManager = this.ribbonControl1;
            this.textEditNote.Name = "textEditNote";
            this.textEditNote.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ 1-9]+";
            this.textEditNote.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditNote.Size = new System.Drawing.Size(160, 20);
            this.textEditNote.TabIndex = 1;
            // 
            // checkEditIsActive
            // 
            this.checkEditIsActive.EditValue = true;
            this.checkEditIsActive.Location = new System.Drawing.Point(102, 229);
            this.checkEditIsActive.MenuManager = this.ribbonControl1;
            this.checkEditIsActive.Name = "checkEditIsActive";
            this.checkEditIsActive.Properties.Caption = "Aktif";
            this.checkEditIsActive.Size = new System.Drawing.Size(95, 19);
            this.checkEditIsActive.TabIndex = 4;
            this.checkEditIsActive.CheckedChanged += new System.EventHandler(this.checkEditActive_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kullanım (Gün)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kullanım (Adet)";
            // 
            // textBoxUseDay
            // 
            this.textBoxUseDay.Location = new System.Drawing.Point(104, 172);
            this.textBoxUseDay.MenuManager = this.ribbonControl1;
            this.textBoxUseDay.Name = "textBoxUseDay";
            this.textBoxUseDay.Properties.Mask.EditMask = "\\d +";
            this.textBoxUseDay.Properties.Mask.IgnoreMaskBlank = false;
            this.textBoxUseDay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxUseDay.Properties.Mask.ShowPlaceHolders = false;
            this.textBoxUseDay.Size = new System.Drawing.Size(160, 20);
            this.textBoxUseDay.TabIndex = 2;
            // 
            // textBoxUsePer
            // 
            this.textBoxUsePer.Location = new System.Drawing.Point(104, 202);
            this.textBoxUsePer.MenuManager = this.ribbonControl1;
            this.textBoxUsePer.Name = "textBoxUsePer";
            this.textBoxUsePer.Properties.Mask.EditMask = "\\d+";
            this.textBoxUsePer.Properties.Mask.IgnoreMaskBlank = false;
            this.textBoxUsePer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textBoxUsePer.Properties.Mask.ShowPlaceHolders = false;
            this.textBoxUsePer.Size = new System.Drawing.Size(160, 20);
            this.textBoxUsePer.TabIndex = 3;
            // 
            // XtraFormMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 267);
            this.Controls.Add(this.textBoxUsePer);
            this.Controls.Add(this.textBoxUseDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkEditIsActive);
            this.Controls.Add(this.textEditNote);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İlaç İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUseDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxUsePer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem barButtonItemSave;
        private BarButtonItem barButtonItemCancel;
        private Label label1;
        private Label label3;
        private TextEdit textEditName;
        private TextEdit textEditNote;
        private CheckEdit checkEditIsActive;
        private Label label4;
        private Label label5;
        private TextEdit textBoxUseDay;
        private TextEdit textBoxUsePer;
    }
}