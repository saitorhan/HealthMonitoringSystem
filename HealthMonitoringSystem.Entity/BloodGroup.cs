// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- BloodGroup.cs

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
    [KnownType(typeof (BloodGroup))]
    public class BloodGroup
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Kan Grubu ismi boş bırakılamaz", AllowEmptyStrings = false)]
        [MaxLength(7, ErrorMessage = "Uzunluk 7'den çok olamaz")]
        [Index(IsUnique = true)]
        [DisplayName("Kan Grubu")]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public virtual ICollection<Patient> Patients { get; set; }
    }
}