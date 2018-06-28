// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- DoktorMail.cs

#region usings

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (DoctorMail))]
    public class DoctorMail
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Email Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("E-mail")]
        // [DataType(DataType.EmailAddress, ErrorMessage = "E-mail adresi girmelisiniz!..")]
        public string Mail { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public Doctor Doctor { get; set; }
    }
}