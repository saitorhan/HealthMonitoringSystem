using System.ComponentModel;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp
{
    partial class XtraFormService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormService));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.AdresstextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PorttextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.AdresstextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorttextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Root Adres";
            // 
            // AdresstextEdit
            // 
            this.AdresstextEdit.Location = new System.Drawing.Point(81, 12);
            this.AdresstextEdit.Name = "AdresstextEdit";
            this.AdresstextEdit.Size = new System.Drawing.Size(179, 20);
            this.AdresstextEdit.TabIndex = 0;
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButtonOK.Location = new System.Drawing.Point(241, 38);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonOK.TabIndex = 2;
            this.simpleButtonOK.Text = "Tamam";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(160, 38);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 3;
            this.simpleButtonCancel.Text = "İptal";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(266, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = ":";
            // 
            // PorttextEdit
            // 
            this.PorttextEdit.Location = new System.Drawing.Point(276, 12);
            this.PorttextEdit.Name = "PorttextEdit";
            this.PorttextEdit.Properties.Mask.EditMask = "d";
            this.PorttextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PorttextEdit.Properties.MaxLength = 5;
            this.PorttextEdit.Size = new System.Drawing.Size(40, 20);
            this.PorttextEdit.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.AllowHtmlString = true;
            this.labelControl3.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.Location = new System.Drawing.Point(12, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 26);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Başına <b>http://</b> yazmadan </br>giriniz.";
            // 
            // XtraFormService
            // 
            this.AcceptButton = this.simpleButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(328, 80);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.PorttextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonOK);
            this.Controls.Add(this.AdresstextEdit);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Servis İçin Root Adres Ayarlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XtraFormService_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.AdresstextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorttextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private TextEdit AdresstextEdit;
        private SimpleButton simpleButtonOK;
        private SimpleButton simpleButtonCancel;
        private LabelControl labelControl2;
        private TextEdit PorttextEdit;
        private LabelControl labelControl3;
    }
}