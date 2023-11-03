// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- ProcessResult.cs

#region usings

using System.Collections.Generic;
using System.Runtime.Serialization;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.Entity.Classes
{
    [DataContract]
    public class ProcessResult
    {
        public ProcessResult()
        {
            Errors = new List<string>();
        }

        [DataMember]
        public Extensions.BLLResult Result { get; set; }

        [DataMember]
        public List<string> Errors { get; set; }
    }
}