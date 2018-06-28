// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Medicament.cs

#region usings

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (Medicament))]
    public class Medicament
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "İlaç İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(200, ErrorMessage = "En fazla 200 karakter girebilirsiniz!..")]
        //[Index(IsUnique = true)]
        [DisplayName("İlaç")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir..")]
        public string Name { get; set; }

        [DataMember]
        [DisplayName("Kullanım Sıklığı")]
        [DataType(DataType.Text)]
        public double? UsePerDay { get; set; }

        [DataMember]
        [DataType(DataType.Text)]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter giriş yapabilirsiniz")]
        public string Note { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public virtual ICollection<PrescriptionItem> PrescriptionItems { get; set; }
    }
}