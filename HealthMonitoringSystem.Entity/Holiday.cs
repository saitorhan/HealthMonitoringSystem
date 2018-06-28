// Sait ORHAN -- 11.01.2015 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Holiday.cs

#region usings

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    }
}