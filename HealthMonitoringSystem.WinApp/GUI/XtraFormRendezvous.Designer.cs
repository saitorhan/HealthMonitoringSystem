using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormRendezvous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormRendezvous));
            this.groupControlProcess = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonDeleteRendezvous = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNewRendevu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlInfos = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timerRendezvousInfo = new System.Windows.Forms.Timer(this.components);
            this.simpleButtonRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlProcess)).BeginInit();
            this.groupControlProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfos)).BeginInit();
            this.groupControlInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlProcess
            // 
            this.groupControlProcess.Controls.Add(this.simpleButtonRefresh);
            this.groupControlProcess.Controls.Add(this.simpleButtonDeleteRendezvous);
            this.groupControlProcess.Controls.Add(this.simpleButtonNewRendevu);
            this.groupControlProcess.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlProcess.Location = new System.Drawing.Point(0, 0);
            this.groupControlProcess.Name = "groupControlProcess";
            this.groupControlProcess.Size = new System.Drawing.Size(188, 661);
            this.groupControlProcess.TabIndex = 0;
            this.groupControlProcess.Text = "İşlemler";
            // 
            // simpleButtonDeleteRendezvous
            // 
            this.simpleButtonDeleteRendezvous.Image = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.simpleButtonDeleteRendezvous.Location = new System.Drawing.Point(6, 104);
            this.simpleButtonDeleteRendezvous.Name = "simpleButtonDeleteRendezvous";
            this.simpleButtonDeleteRendezvous.Size = new System.Drawing.Size(177, 74);
            this.simpleButtonDeleteRendezvous.TabIndex = 1;
            this.simpleButtonDeleteRendezvous.Text = "Randevu Sil";
            this.simpleButtonDeleteRendezvous.Click += new System.EventHandler(this.simpleButtonDeleteRendezvous_Click);
            // 
            // simpleButtonNewRendevu
            // 
            this.simpleButtonNewRendevu.Image = global::HealthMonitoringSystem.WinApp.Properties.Resources.add_to_favorites;
            this.simpleButtonNewRendevu.Location = new System.Drawing.Point(6, 24);
            this.simpleButtonNewRendevu.Name = "simpleButtonNewRendevu";
            this.simpleButtonNewRendevu.Size = new System.Drawing.Size(177, 74);
            this.simpleButtonNewRendevu.TabIndex = 0;
            this.simpleButtonNewRendevu.Text = "Yeni Randevu Ver";
            this.simpleButtonNewRendevu.Click += new System.EventHandler(this.simpleButtonNewRendevu_Click);
            // 
            // groupControlInfos
            // 
            this.groupControlInfos.Controls.Add(this.flowLayoutPanel1);
            this.groupControlInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlInfos.Location = new System.Drawing.Point(188, 0);
            this.groupControlInfos.Name = "groupControlInfos";
            this.groupControlInfos.Size = new System.Drawing.Size(996, 661);
            this.groupControlInfos.TabIndex = 1;
            this.groupControlInfos.Text = "Genel Bilgiler";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(992, 638);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // timerRendezvousInfo
            // 
            this.timerRendezvousInfo.Enabled = true;
            this.timerRendezvousInfo.Interval = 60000;
            this.timerRendezvousInfo.Tick += new System.EventHandler(this.timerRendezvousInfo_Tick);
            // 
            // simpleButtonRefresh
            // 
            this.simpleButtonRefresh.Image = global::HealthMonitoringSystem.WinApp.Properties.Resources.refresh;
            this.simpleButtonRefresh.Location = new System.Drawing.Point(6, 184);
            this.simpleButtonRefresh.Name = "simpleButtonRefresh";
            this.simpleButtonRefresh.Size = new System.Drawing.Size(177, 74);
            this.simpleButtonRefresh.TabIndex = 2;
            this.simpleButtonRefresh.Text = "Bilgileri Yenile";
            this.simpleButtonRefresh.Click += new System.EventHandler(this.simpleButtonRefresh_Click);
            // 
            // XtraFormRendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupControlInfos);
            this.Controls.Add(this.groupControlProcess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormRendezvous";
            this.Text = "Randevu İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControlProcess)).EndInit();
            this.groupControlProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfos)).EndInit();
            this.groupControlInfos.ResumeLayout(false);
            this.groupControlInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControlProcess;
        private GroupControl groupControlInfos;
        private SimpleButton simpleButtonNewRendevu;
        private SimpleButton simpleButtonDeleteRendezvous;
        private FlowLayoutPanel flowLayoutPanel1;
        private Timer timerRendezvousInfo;
        private SimpleButton simpleButtonRefresh;
    }
}