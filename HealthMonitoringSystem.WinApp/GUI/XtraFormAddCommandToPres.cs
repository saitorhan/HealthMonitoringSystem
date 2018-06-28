// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormAddCommandToPres.cs

#region usings

using System;
using DevExpress.XtraEditors;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormAddCommandToPres : XtraForm
    {
        public string Command { get; set; }

        public XtraFormAddCommandToPres()
        {
            InitializeComponent();
        }

        public XtraFormAddCommandToPres(string command)
        {
            Command = command;
            InitializeComponent();
            memoEditCommand.Text = command;
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            Command = memoEditCommand.Text;
        }
    }
}