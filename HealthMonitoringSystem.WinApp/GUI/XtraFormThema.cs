// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormThema.cs

#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using HealthMonitoringSystem.WinApp.Extensions;
using HealthMonitoringSystem.WinApp.Properties;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormThema : XtraForm
    {
        public XtraFormThema()
        {
            InitializeComponent();
        }

        private void XtraFormThema_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary =
                SkinManager.Default.Skins.Cast<SkinContainer>()
                    .ToDictionary(skin => skin.SkinName, skin => skin.SkinName);
            lookUpEdit1.Properties.DataSource = dictionary;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string value = lookUpEdit1.EditValue as string;
            if (value.IsNull())
            {
                XtraMessageBox.Show("Tema seçmediniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            UserLookAndFeel.Default.SetSkinStyle(value);
            Settings.Default.Save();
            Close();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            string value = lookUpEdit1.EditValue.ToString();
            if (value.IsNull())
            {
                return;
            }
            UserLookAndFeel.Default.SetSkinStyle(value);
        }

        private void XtraFormThema_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}