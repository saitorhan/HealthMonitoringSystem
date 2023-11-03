// Sait ORHAN -- 11.01.2015 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Holiday.cs

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
    [KnownType(typeof (Holiday))]
    public class Holiday
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Tatil İsmi Boş Bırakılamaz...", AllowEmptyStrings = false)]
        [MaxLength(100)]
        [DisplayName("Tatil")]
        public string Name { get; set; }

        [DataMember]
        [Required]
        public int Day { get; set; }

        [DataMember]
        [Required]
        public int Month { get; set; }

        [DataMember]
        public int? Year { get; set; }

        [NotMapped]
        public string MonthS
        {
            get
            {
                List<string> months = new List<string>
                {
                    "Ocak",
                    "Şubat",
                    "Mart",
                    "Nisan",
                    "Mayıs",
                    "Haziran",
                    "Temmuz",
                    "Ağustos",
                    "Eylül",
                    "Ekim",
                    "Kasım",
                    "Aralık"
                };
                return months[Month - 1];
            }
        }

        [NotMapped]
        public string YearS => Year == null ? "Her Yıl" : Year.Value.ToString();
    }
}