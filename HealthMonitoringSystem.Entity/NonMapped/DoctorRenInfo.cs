// Sait ORHAN -- 15.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- DoctorRenInfo.cs

#region usings

using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (DoctorRenInfo))]
    public class DoctorRenInfo
    {
        [DataMember]
        public int Limit { get; set; }

        [DataMember]
        public string DoctorName { get; set; }
    }
}