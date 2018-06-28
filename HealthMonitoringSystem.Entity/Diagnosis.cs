// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Diagnosis.cs

#region usings

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (Diagnosis))]
    public class Diagnosis
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Teþhis Ýsmi Boþ Býrakýlamaz...", AllowEmptyStrings = false)]
        [MaxLength(100)]
        [DisplayName("Teþhis")]
        public string Name { get; set; }

        [DataMember]
        public int DepartmentId { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalýþma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public Department Department { get; set; }

        [DataMember]
        public virtual ICollection<Examination> Examinations { get; set; }
    }
}