// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Degree.cs

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
    [KnownType(typeof (City))]
    public class Degree
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Ünvan İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter girebilirsiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("Ünvan")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir..")]
        public string Name { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Ünvan Kısaltma İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(10, ErrorMessage = "En fazla 10 karakter girebilirsiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("Ünvan Kısaltması")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir..")]
        public string ShortName { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Yönetici mi")]
        public bool IsAdmin { get; set; }

        public virtual ICollection<Doctor> Doktors { get; set; }
        public virtual ICollection<Personnel> Personnels { get; set; }
    }
}