using System.ComponentModel;
using DevExpress.XtraEditors;

namespace HealthMonitoringSystem.WinApp.GUI
{
    partial class XtraFormDeleteRendezvous
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDeleteRendezvous));
            this.groupControlFindedrendezvous = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textEditTime = new DevExpress.XtraEditors.TextEdit();
            this.textEditDate = new DevExpress.XtraEditors.TextEdit();
            this.textEditDoctorName = new DevExpress.XtraEditors.TextEdit();
            this.textEditPatientName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEditFindRendezvous = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFindedrendezvous)).BeginInit();
            this.groupControlFindedrendezvous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDoctorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPatientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditFindRendezvous.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlFindedrendezvous
            // 
            this.groupControlFindedrendezvous.Controls.Add(this.simpleButtonUpdate);
            this.groupControlFindedrendezvous.Controls.Add(this.simpleButtonDelete);
            this.groupControlFindedrendezvous.Controls.Add(this.textEditTime);
            this.groupControlFindedrendezvous.Controls.Add(this.textEditDate);
            this.groupControlFindedrendezvous.Controls.Add(this.textEditDoctorName);
            this.groupControlFindedrendezvous.Controls.Add(this.textEditPatientName);
            this.groupControlFindedrendezvous.Controls.Add(this.labelControl4);
            this.groupControlFindedrendezvous.Controls.Add(this.labelControl3);
            this.groupControlFindedrendezvous.Controls.Add(this.labelControl2);
            this.groupControlFindedrendezvous.Controls.Add(this.labelControl1);
            this.groupControlFindedrendezvous.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlFindedrendezvous.Location = new System.Drawing.Point(0, 41);
            this.groupControlFindedrendezvous.Name = "groupControlFindedrendezvous";
            this.groupControlFindedrendezvous.Size = new System.Drawing.Size(357, 245);
            this.groupControlFindedrendezvous.TabIndex = 2;
            this.groupControlFindedrendezvous.Text = "Bulunan Randevu";
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.Enabled = false;
            this.simpleButtonUpdate.Image = global::HealthMonitoringSystem.WinApp.Properties.Resources.edit;
            this.simpleButtonUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonUpdate.Location = new System.Drawing.Point(257, 130);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(75, 68);
            this.simpleButtonUpdate.TabIndex = 5;
            this.simpleButtonUpdate.Text = "Güncelle";
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Enabled = false;
            this.simpleButtonDelete.Image = global::HealthMonitoringSystem.WinApp.Properties.Resources.delete;
            this.simpleButtonDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonDelete.Location = new System.Drawing.Point(257, 56);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(75, 68);
            this.simpleButtonDelete.TabIndex = 4;
            this.simpleButtonDelete.Text = "Sil";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // textEditTime
            // 
            this.textEditTime.Location = new System.Drawing.Point(5, 188);
            this.textEditTime.Name = "textEditTime";
            this.textEditTime.Properties.ReadOnly = true;
            this.textEditTime.Size = new System.Drawing.Size(230, 20);
            this.textEditTime.TabIndex = 3;
            // 
            // textEditDate
            // 
            this.textEditDate.Location = new System.Drawing.Point(5, 143);
            this.textEditDate.Name = "textEditDate";
            this.textEditDate.Properties.ReadOnly = true;
            this.textEditDate.Size = new System.Drawing.Size(230, 20);
            this.textEditDate.TabIndex = 2;
            // 
            // textEditDoctorName
            // 
            this.textEditDoctorName.Location = new System.Drawing.Point(5, 98);
            this.textEditDoctorName.Name = "textEditDoctorName";
            this.textEditDoctorName.Properties.ReadOnly = true;
            this.textEditDoctorName.Size = new System.Drawing.Size(230, 20);
            this.textEditDoctorName.TabIndex = 1;
            // 
            // textEditPatientName
            // 
            this.textEditPatientName.Location = new System.Drawing.Point(5, 53);
            this.textEditPatientName.Name = "textEditPatientName";
            this.textEditPatientName.Properties.ReadOnly = true;
            this.textEditPatientName.Size = new System.Drawing.Size(230, 20);
            this.textEditPatientName.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(22, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Saat";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tarih";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Doktor Adı Soyadı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hasta Adı Soyadı";
            // 
            // buttonEditFindRendezvous
            // 
            this.buttonEditFindRendezvous.Location = new System.Drawing.Point(12, 12);
            this.buttonEditFindRendezvous.Name = "buttonEditFindRendezvous";
            this.buttonEditFindRendezvous.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Randevu Bul", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.buttonEditFindRendezvous.Properties.Mask.EditMask = "d";
            this.buttonEditFindRendezvous.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.buttonEditFindRendezvous.Size = new System.Drawing.Size(337, 20);
            this.buttonEditFindRendezvous.TabIndex = 0;
            this.buttonEditFindRendezvous.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditFindRendezvous_ButtonClick);
            // 
            // XtraFormDeleteRendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 286);
            this.Controls.Add(this.buttonEditFindRendezvous);
            this.Controls.Add(this.groupControlFindedrendezvous);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraFormDeleteRendezvous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Randevu Silme";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFindedrendezvous)).EndInit();
            this.groupControlFindedrendezvous.ResumeLayout(false);
            this.groupControlFindedrendezvous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDoctorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPatientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditFindRendezvous.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl groupControlFindedrendezvous;
        private SimpleButton simpleButtonUpdate;
        private SimpleButton simpleButtonDelete;
        private TextEdit textEditTime;
        private TextEdit textEditDate;
        private TextEdit textEditDoctorName;
        private TextEdit textEditPatientName;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private ButtonEdit buttonEditFindRendezvous;
    }
}