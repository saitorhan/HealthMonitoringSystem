// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- PrescriptionItem.cs

#region usings

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (PrescriptionItem))]
    public class PrescriptionItem
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PrescriptionId { get; set; }

        [DataMember]
        public int MedicamentId { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Kullanım Sıklığı Alanı Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [DisplayName("Kullanım Sıklığı")]
        public double UsePerDay { get; set; }

        [DataMember]
        [DisplayName("Doktor Notu")]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter giriş yapabilirsiniz")]
        public string DoctorNote { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public Prescription Prescription { get; set; }

        [DataMember]
        public Medicament Medicament { get; set; }
    }
}