using System.ComponentModel;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormDownloadLanguages
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
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.LanguagelabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(12, 12);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.progressBarControl1.Size = new System.Drawing.Size(633, 18);
            this.progressBarControl1.TabIndex = 0;
            // 
            // LanguagelabelControl
            // 
            this.LanguagelabelControl.Location = new System.Drawing.Point(272, 36);
            this.LanguagelabelControl.Name = "LanguagelabelControl";
            this.LanguagelabelControl.Size = new System.Drawing.Size(0, 13);
            this.LanguagelabelControl.TabIndex = 1;
            // 
            // XtraFormDownloadLanguages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 75);
            this.Controls.Add(this.LanguagelabelControl);
            this.Controls.Add(this.progressBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XtraFormDownloadLanguages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XtraFormDownloadLanguages";
            this.Shown += new System.EventHandler(this.XtraFormDownloadLanguages_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBarControl progressBarControl1;
        private LabelControl LanguagelabelControl;
    }
}