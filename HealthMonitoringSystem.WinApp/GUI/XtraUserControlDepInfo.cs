// Sait ORHAN -- 15.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- XtraUserControlDepInfo.cs

#region usings

using DevExpress.XtraEditors;
using HealthMonitoringSystem.WinApp.RendezvousService;

#endregion

namespace HealthMonitoringSystem.WinApp.GUI
{
    public partial class XtraUserControlDepInfo : XtraUserControl
    {
        private DoctorRenInfo[] _Info;
        private int max;
        private int _value;

        public int Max
        {
            get { return max; }
            set
            {
                max = value > 30 ? value : 30;
                arcScaleBackgroundLayerComponent1.Scale.MaxValue = max;
                arcScaleBackgroundLayerComponent1.ArcScale.Ranges[0].StartValue = 0;
                arcScaleBackgroundLayerComponent1.ArcScale.Ranges[0].EndValue = max/(float) 3;
                arcScaleBackgroundLayerComponent1.ArcScale.Ranges[1].StartValue = max/(float) 3;
                arcScaleBackgroundLayerComponent1.ArcScale.Ranges[1].EndValue = max/3*2;
                arcScaleBackgroundLayerComponent1.ArcScale.Ranges[2].StartValue = max/3*2;
                arcScaleBackgroundLayerComponent1.ArcScale.Ranges[2].EndValue = max;
            }
        }

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                arcScaleBackgroundLayerComponent1.Scale.Value = value;
            }
        }

        public DoctorRenInfo[] Info
        {
            get { return _Info; }
            set
            {
                _Info = value;
                bindingSourceInfo.DataSource = value;
                gridControlInfo.Refresh();
            }
        }

        private string _department;

        public string DepartmentName
        {
            get { return _department; }
            set
            {
                _department = value;
                groupControlDepartment.Text = _department;
            }
        }

        public XtraUserControlDepInfo(RendezvousInfo rendezvousInfo)
        {
            InitializeComponent();

            DepartmentName = rendezvousInfo.DepartmentName;
            Info = rendezvousInfo.DoctorRenInfos;
            Max = rendezvousInfo.Max;
            Value = rendezvousInfo.Value;
        }
    }
}