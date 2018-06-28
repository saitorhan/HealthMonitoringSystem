// Sait ORHAN -- 15.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- RendezvousInfo.cs

#region usings

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (City))]
    public class RendezvousInfo
    {
        public RendezvousInfo()
        {
            DoctorRenInfos = new List<DoctorRenInfo>();
            Value = 0;
        }

        [DataMember]
        public string DepartmentName { get; set; }

        [DataMember]
        public int Max { get; set; }

        [DataMember]
        public int Value { get; set; }

        [DataMember]
        public List<DoctorRenInfo> DoctorRenInfos { get; set; }
    }
}