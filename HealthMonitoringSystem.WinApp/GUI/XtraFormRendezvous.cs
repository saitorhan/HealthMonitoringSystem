// Sait ORHAN -- 06.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormRendezvous.cs

#region usings

using System;
using System.Linq;
using DevExpress.XtraEditors;
using HealthMonitoringSystem.BLL;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormRendezvous : XtraForm
    {
        public XtraFormRendezvous()
        {
            InitializeComponent();
            ShowInfos();
        }

        private void simpleButtonNewRendevu_Click(object sender, EventArgs e)
        {
            XtraFormRendezvousProcess process = new XtraFormRendezvousProcess();
            process.ShowDialog();
        }

        private void simpleButtonDeleteRendezvous_Click(object sender, EventArgs e)
        {
            XtraFormDeleteRendezvous deleteRendezvous = new XtraFormDeleteRendezvous();
            deleteRendezvous.ShowDialog();
        }

        private void ShowInfos()
        {
            flowLayoutPanel1.Controls.Clear();
            RendezvousManager client = new RendezvousManager();
            RendezvousInfo[] infos = client.RendezvousInfos().OrderBy(r => r.Max - r.Value).ToArray();

            foreach (XtraUserControlDepInfo depInfo in infos.Select(info => new XtraUserControlDepInfo(info)))
            {
                flowLayoutPanel1.Controls.Add(depInfo);
            }
        }

        private void timerRendezvousInfo_Tick(object sender, EventArgs e)
        {
            ShowInfos();
        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            ShowInfos();
        }
    }
}