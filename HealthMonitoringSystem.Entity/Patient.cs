// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Patient.cs

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
    [KnownType(typeof (Patient))]
    public class Patient
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required(ErrorMessage = "TC Numarası Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(11, ErrorMessage = " 11 karakter girmelisiniz!..")]
        [MinLength(11, ErrorMessage = " 11 karakter girmelisiniz!..")]
        [Index(IsUnique = true)]
        [DisplayName("TC Numarası")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana boşluk karakteri giremezsiniz!..")]
        public string TcNo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Hasta İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz!..")]
        [DisplayName("İsim")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana ssadece harf girilebilir!..")]
        public string Name { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Soyad Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz!..")]
        [DisplayName("Soyad")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir!..")]
        public string Surname { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Baba İsmi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz!..")]
        [DisplayName("Baba Adı")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana ssadece harf girilebilir!..")]
        public string FatherName { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Anne adı Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz!..")]
        [DisplayName("Anne Adı")]
        [DataType(DataType.Text, ErrorMessage = "Bu alana sadece harf girilebilir!..")]
        public string MotherName { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Adres Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "En fazla 100 karakter girebilirsiniz!..")]
        [DisplayName("Adres")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [DataMember]
        public int CityId { get; set; }

        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Telefon numarası Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(15, ErrorMessage = "En fazla 15 karakter girebilirsiniz!..")]
        [DisplayName("Telefon Numarası")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Bu alana karakter girişi yapamazsınız!..")]
        public string Phone { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Email Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "En fazla 100 karakter girebilirsiniz!..")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail adresi girmelisiniz!..")]
        public string Mail { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Doğum Tarihi Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [DisplayName("Doğum Tarihi")]
        [DataType(DataType.Date, ErrorMessage = "Tarih hatası")]
        public DateTime BirthDay { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Cinsiyet Boş Bırakılamaz!..", AllowEmptyStrings = false)]
        [DisplayName("Cinsiyet")]
        public bool Gender { get; set; }

        [DataMember]
        public int BloodGroupId { get; set; }

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
        public City City { get; set; }

        [DataMember]
        public Country Country { get; set; }

        [DataMember]
        public BloodGroup BloodGroup { get; set; }

        [DataMember]
        public virtual ICollection<Examination> Examinations { get; set; }

        [DataMember]
        public virtual ICollection<Message> Messages { get; set; }

        [DataMember]
        public virtual ICollection<Rendezvous> Rendezvouses { get; set; }

        public int GetAge()
        {
            return (DateTime.Today - BirthDay).Days/30;
        }

        [NotMapped]
        public string NameSurname
        {
            get { return String.Format("{0} {1}", Name, Surname); }
        }
    }
}