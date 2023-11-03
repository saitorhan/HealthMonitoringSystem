// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- PrescriptionItem.cs

#region usings

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public string SUsePerDay
        {
            get
            {
                if (UsePerDay < 1) return "BELİRTİLMEDİ";
                string s = UsePerDay.ToString();
                string[] split = s.Split(',');
                int day;
                int use;

                if (split.Length != 2) return "BELİRTİLMEDİ";

                Int32.TryParse(split[0], out day);
                Int32.TryParse(split[1], out use);

                return String.Format("{0} {1} defa", day == 1 ? "Günde" : day + " günde", use);
            }
        }
    }
}