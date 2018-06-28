// Sait ORHAN -- 05.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraFormDownloadLanguages.cs

#region usings

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using HealthMonitoringSystem.WinApp.Resources;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraFormDownloadLanguages : XtraForm
    {
        private string language;
        private string lang;

        public XtraFormDownloadLanguages(string language, string lang)
        {
            InitializeComponent();
            this.language = language;
            this.lang = lang;
        }

        private void XtraFormDownloadLanguages_Shown(object sender, EventArgs e)
        {
            string rootUrl = GlobalVariables.ServiceRoot + "/installapp/" + lang + "/{0}";
            string rootFile = Application.StartupPath + "\\" + lang;
            if (!Directory.Exists(rootFile))
                Directory.CreateDirectory(rootFile);
            XDocument doc = XDocument.Load(String.Format("{0}/installapp/files.xml", GlobalVariables.ServiceRoot));
            var xElement = doc.Element("Files");
            if (xElement == null) return;
            IEnumerable<XElement> elements = xElement.Elements().ToList();
            progressBarControl1.Properties.Maximum = elements.Count();
            int i = 0;
            foreach (XElement element in elements)
            {
                string uri = String.Format(rootUrl, element.Value);
                string file = String.Format("{0}\\{1}", rootFile, element.Value);
                WebClient webClient = new WebClient();
                FileInfo info = new FileInfo(file);
                if (!info.Exists)
                    webClient.DownloadFile(uri, file);
                progressBarControl1.PerformStep();
                LanguagelabelControl.Text = String.Format("{0} dili dosyaları indiriliyor. ({1}/{2})", language, i++,
                    progressBarControl1.Properties.Maximum);
                Application.DoEvents();
            }
            Close();
        }
    }
}