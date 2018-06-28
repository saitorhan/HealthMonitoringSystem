// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Department.cs

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
    [KnownType(typeof (Department))]
    public class Department
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Departman İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(25, ErrorMessage = "En fazla 25 karakter girebilirsiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("Departman")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girişi yapılabilir..")]
        public string Name { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public int? MinAge { get; set; }

        [DataMember]
        public int? MaxAge { get; set; }

        [DataMember]
        public bool? Gender { get; set; }


        [DataMember]
        public virtual ICollection<Doctor> Doctors { get; set; }

        [DataMember]
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
    }
}