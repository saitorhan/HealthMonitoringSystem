using System.ComponentModel;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormAddCommandToPres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormAddCommandToPres));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditCommand = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditCommand.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Not";
            // 
            // memoEditCommand
            // 
            this.memoEditCommand.Location = new System.Drawing.Point(35, 12);
            this.memoEditCommand.Name = "memoEditCommand";
            this.memoEditCommand.Size = new System.Drawing.Size(367, 103);
            this.memoEditCommand.TabIndex = 1;
            this.memoEditCommand.UseOptimizedRendering = true;
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButtonSave.Location = new System.Drawing.Point(327, 130);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSave.TabIndex = 2;
            this.simpleButtonSave.Text = "Kaydet";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(246, 130);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 3;
            this.simpleButtonCancel.Text = "İptal";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // XtraFormAddCommandToPres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 166);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.memoEditCommand);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormAddCommandToPres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reçeteye Not Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.memoEditCommand.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl1;
        private MemoEdit memoEditCommand;
        private SimpleButton simpleButtonSave;
        private SimpleButton simpleButtonCancel;
    }
}