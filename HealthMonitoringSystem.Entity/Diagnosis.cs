// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Diagnosis.cs

#region usings

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required(ErrorMessage = "Te�his �smi Bo� B�rak�lamaz...", AllowEmptyStrings = false)]
        [MaxLength(100)]
        [DisplayName("Te�his")]
        public string Name { get; set; }

        [DataMember]
        public int DepartmentId { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("�al��ma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public Department Department { get; set; }

        [DataMember]
        public virtual ICollection<Examination> Examinations { get; set; }

        [NotMapped]
        public string DisplayName => Name == "DEFAULT" ? "TE�H�S YOK" : Name;
    }
}