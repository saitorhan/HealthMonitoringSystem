// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- LaboratoryItemUnit.cs

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
    [KnownType(typeof (LaboratoryItemUnit))]
    public class LaboratoryItemUnit
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Birim adı boş bırakılamaz", AllowEmptyStrings = false)]
        [Index(IsUnique = true)]
        [DisplayName("Birim Adı")]
        [DataType(DataType.Text)]
        [MaxLength(10, ErrorMessage = "En fazla 10 karakter girebilirsiniz")]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public virtual ICollection<LaboratoryRequestType> LaboratoryRequestTypes { get; set; }
    }
}