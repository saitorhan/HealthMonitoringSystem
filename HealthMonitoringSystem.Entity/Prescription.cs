// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Prescription.cs

#region usings

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (Prescription))]
    public class Prescription
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ExaminationId { get; set; }

        [DataMember]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter girilebilir")]
        [DisplayName("Doktor Notu")]
        public string DoctorNote { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public Examination Examination { get; set; }

        [DataMember]
        public virtual ICollection<PrescriptionItem> PrescriptionItems { get; set; }
    }
}