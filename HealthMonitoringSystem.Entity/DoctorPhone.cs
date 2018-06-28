// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- DoctorPhone.cs

#region usings

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

#endregion

// 
// HealthMonitoringSystem.Entity - DoctorPhone.cs
// 21 / 09 / 2014

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (DoctorPhone))]
    public class DoctorPhone
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Telefon numarası Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(11, ErrorMessage = "En fazla 11 karakter girebilirsiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("Telefon Numarası")]
        public string Phone { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public Doctor Doctor { get; set; }
    }
}