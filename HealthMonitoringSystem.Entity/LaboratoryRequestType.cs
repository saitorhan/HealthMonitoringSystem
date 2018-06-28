// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- LaboratoryRequestType.cs

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
    [KnownType(typeof (LaboratoryRequestType))]
    public class LaboratoryRequestType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Tahlil tipi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "En fazla 20 karakter girebilirsiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("Tahlil tipi")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Minimum Değer Alanı Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [DisplayName("Minimum Değer")]
        public double Min { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Maksimum Değer Alanı Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [DisplayName("Maksimum Değer")]
        public double Max { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public int LaboratoryItemUnitId { get; set; }

        [DataMember]
        public LaboratoryItemUnit LaboratoryItemUnit { get; set; }

        [DataMember]
        public virtual ICollection<LaboratoryRequestItem> LaboratoryRequestItems { get; set; }
    }
}