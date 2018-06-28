// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Country.cs

#region usings

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (Country))]
    public class Country
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int CityId { get; set; }

        [DataMember]
        [Required(ErrorMessage = "İlçe İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(30, ErrorMessage = "En fazla 15 karakter girebilirsiniz!..")]
        [DisplayName("İlçe Adı")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir!..")]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public City City { get; set; }

        [DataMember]
        public virtual ICollection<Patient> Patients { get; set; }

        [DataMember]
        public virtual ICollection<Personnel> Personnels { get; set; }
    }
}