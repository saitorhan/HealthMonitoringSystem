// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- City.cs

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
    public class City
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Şehir İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter girebilirsiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("Şehir Adı")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf yazılabilir!..")]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public virtual ICollection<Patient> Patients { get; set; }

        [DataMember]
        public virtual ICollection<Personnel> Personnels { get; set; }

        [DataMember]
        public virtual ICollection<Country> Countries { get; set; }
    }
}