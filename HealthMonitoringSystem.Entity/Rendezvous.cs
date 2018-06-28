// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Rendezvous.cs

#region usings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (Rendezvous))]
    public class Rendezvous
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public int RendezvousTimeId { get; set; }

        [DataMember]
        public int PatientId { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public RendezvousTime RendezvousTime { get; set; }

        [DataMember]
        public Patient Patient { get; set; }

        [DataMember]
        public Doctor Doctor { get; set; }

        public virtual List<Examination> Examinations { get; set; }
    }
}