// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Doctor.cs

#region usings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (Doctor))]
    public class Doctor
    {
        public Doctor()
        {
            DoctorMails = new List<DoctorMail>();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Doktor İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz!..")]
        [DisplayName("Adı")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir!..")]
        public string Name { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Soyad Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter girebilirsiniz!..")]
        [DisplayName("Soyadı")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir!..")]
        public string Surname { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Doğum Tarihi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [DisplayName("Doğum Tarihi")]
        [DataType(DataType.Date, ErrorMessage = "Tarih hatası")]
        public DateTime BirthDay { get; set; }

        [DataMember]
        [Required(ErrorMessage = "TC Numarası Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(11, ErrorMessage = " 11 karakter girmelisiniz!..")]
        [MinLength(11, ErrorMessage = " 11 karakter girmelisiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("TC Numarası")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana boşluk karakteri giremezsiniz!..")]
        public string TcNo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Sicil Numarası Boş Geçilemez...", AllowEmptyStrings = false)]
        [Index(IsUnique = true)]
        [MaxLength(11, ErrorMessage = " 11 karakter girmelisiniz!..")]
        [MinLength(11, ErrorMessage = " 11 karakter girmelisiniz!..")]
        [DisplayName("Sicil Numarası:")]
        [DataType(DataType.Text)]
        public string RegistrationNumber { get; set; }

        [DataMember]
        public int DepartmentId { get; set; }

        [DataMember]
        public int DegreeId { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Anne Adı Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz!..")]
        [DisplayName("Anne Adı")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir!..")]
        public string MotherName { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Baba Adı Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz!..")]
        [DisplayName("Baba Adı")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir!..")]
        public string FatherName { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Şifre boş bırakılamaz", AllowEmptyStrings = false)]
        [MaxLength(16, ErrorMessage = "Şifre en fazla 4 - 16 karakter arasında olmalı")]
        [MinLength(4, ErrorMessage = "Şifre en fazla 4 - 16 karakter arasında olmalı")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DataMember]
        public Department Department { get; set; }

        [DataMember]
        public Degree Degree { get; set; }

        [DataMember]
        public virtual ICollection<Examination> Examinations { get; set; }

        [DataMember]
        public virtual ICollection<DoctorMail> DoctorMails { get; set; }

        [DataMember]
        public virtual ICollection<DoctorPhone> DoctorPhones { get; set; }

        [DataMember]
        public virtual ICollection<Message> Messages { get; set; }

        [DataMember]
        public virtual ICollection<Rendezvous> Rendezvouses { get; set; }

        [NotMapped]
        public string NameSurname
        {
            get { return String.Format("{0} {1}", Name, Surname); }
        }
    }
}