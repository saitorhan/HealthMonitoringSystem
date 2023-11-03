// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Message.cs

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
    [KnownType(typeof (Message))]
    public class Message
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int PatientId { get; set; }

        [DataMember]
        public DateTime DateTime { get; set; }

        [DataMember]
        [DisplayName("Mesaj içeriği")]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter giriş yapılabilir")]
        [DataType(DataType.MultilineText)]
        public string Mesage { get; set; }

        [DataMember]
        public bool FromDoctor { get; set; }

        [DataMember]
        [DefaultValue(false)]
        public bool Readed { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public Doctor Doctor { get; set; }

        [DataMember]
        public Patient Patient { get; set; }

        [NotMapped]
        public string From
        {
            get
            {
                return String.Format("{0} {1}",
                    FromDoctor ? Doctor.Name : Patient.Name,
                    FromDoctor ? Doctor.Surname : Patient.Surname);
            }
        }

        [NotMapped]
        public string To
        {
            get
            {
                return String.Format("{0} {1}",
                    FromDoctor ? Patient.Name : Doctor.Name,
                    FromDoctor ? Patient.Surname : Doctor.Surname);
            }
        }

        [NotMapped]
        public string SReaded
        {
            get { return Readed ? "OKUNDU" : "OKUNMADI"; }
        }
    }
}