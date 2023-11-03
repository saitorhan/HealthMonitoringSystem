using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormHoliday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormHoliday));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLenght = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.dateEditFirstDay = new DevExpress.XtraEditors.DateEdit();
            this.textEditLenght = new DevExpress.XtraEditors.TextEdit();
            this.checkEditEveryYear = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFirstDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFirstDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLenght.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditEveryYear.Properties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(295, 126);
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
            this.labelControl1.Location = new System.Drawing.Point(8, 135);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tatil Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 161);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tatilin İlk Günü";
            // 
            // labelControlLenght
            // 
            this.labelControlLenght.Location = new System.Drawing.Point(8, 212);
            this.labelControlLenght.Name = "labelControlLenght";
            this.labelControlLenght.Size = new System.Drawing.Size(67, 13);
            this.labelControlLenght.TabIndex = 1;
            this.labelControlLenght.Text = "Tatil Uzunluğu";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(94, 132);
            this.textEditName.MenuManager = this.ribbonControl1;
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Mask.EditMask = "[A-ZĞÜŞİÖÇ ]+";
            this.textEditName.Properties.Mask.IgnoreMaskBlank = false;
            this.textEditName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditName.Properties.Mask.ShowPlaceHolders = false;
            this.textEditName.Size = new System.Drawing.Size(181, 20);
            this.textEditName.TabIndex = 2;
            // 
            // dateEditFirstDay
            // 
            this.dateEditFirstDay.EditValue = null;
            this.dateEditFirstDay.Location = new System.Drawing.Point(94, 158);
            this.dateEditFirstDay.MenuManager = this.ribbonControl1;
            this.dateEditFirstDay.Name = "dateEditFirstDay";
            this.dateEditFirstDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFirstDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFirstDay.Properties.DisplayFormat.FormatString = "dd MMMM yyyy";
            this.dateEditFirstDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditFirstDay.Size = new System.Drawing.Size(178, 20);
            this.dateEditFirstDay.TabIndex = 3;
            // 
            // textEditLenght
            // 
            this.textEditLenght.Location = new System.Drawing.Point(94, 209);
            this.textEditLenght.MenuManager = this.ribbonControl1;
            this.textEditLenght.Name = "textEditLenght";
            this.textEditLenght.Properties.Mask.EditMask = "d";
            this.textEditLenght.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditLenght.Size = new System.Drawing.Size(178, 20);
            this.textEditLenght.TabIndex = 4;
            // 
            // checkEditEveryYear
            // 
            this.checkEditEveryYear.EditValue = true;
            this.checkEditEveryYear.Location = new System.Drawing.Point(124, 184);
            this.checkEditEveryYear.MenuManager = this.ribbonControl1;
            this.checkEditEveryYear.Name = "checkEditEveryYear";
            this.checkEditEveryYear.Properties.Caption = "Her Yıl Aynı Günde Oluyor";
            this.checkEditEveryYear.Size = new System.Drawing.Size(148, 20);
            this.checkEditEveryYear.TabIndex = 5;
            // 
            // XtraFormHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 248);
            this.Controls.Add(this.checkEditEveryYear);
            this.Controls.Add(this.textEditLenght);
            this.Controls.Add(this.dateEditFirstDay);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.labelControlLenght);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XtraFormHoliday.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormHoliday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tatil İşlemleri";
            this.Load += new System.EventHandler(this.XtraFormHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFirstDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFirstDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLenght.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditEveryYear.Properties)).EndInit();
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
        private LabelControl labelControlLenght;
        private TextEdit textEditName;
        private DateEdit dateEditFirstDay;
        private TextEdit textEditLenght;
        private CheckEdit checkEditEveryYear;
    }
}