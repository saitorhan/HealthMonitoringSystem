// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Examination.cs

#region usings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (Examination))]
    public class Examination
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PatientId { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        [DataType(DataType.Date, ErrorMessage = "Bu alana tarih bilgisi girmelisiniz.")]
        public DateTime Time { get; set; }

        [DataMember]
        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter girebilirsiniz...")]
        public string DoctorNote { get; set; }

        [DataMember]
        [DefaultValue(false)]
        public bool CanSendMessage { get; set; }

        [DataMember]
        [DataType(DataType.Date, ErrorMessage = "Bu alana tarih bilgisi girmelisiniz.")]
        public DateTime? NextTime { get; set; }

        [DataMember]
        [Required]
        public int RendezvousId { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public int DiagnosisId { get; set; }

        [DataMember]
        public Rendezvous Rendezvous { get; set; }

        [DataMember]
        public Patient Patient { get; set; }

        [DataMember]
        public Doctor Doctor { get; set; }

        [DataMember]
        public Diagnosis Diagnosis { get; set; }

        [DataMember]
        public virtual ICollection<LaboratoryRequest> LaboratoryRequests { get; set; }

        [DataMember]
        public virtual ICollection<Prescription> Prescriptions { get; set; }

    }
}