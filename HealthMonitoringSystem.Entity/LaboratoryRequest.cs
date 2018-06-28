// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- LaboratoryRequest.cs

#region usings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (LaboratoryRequest))]
    public class LaboratoryRequest
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ExaminationId { get; set; }

        [DataMember]
        [DataType(DataType.Date, ErrorMessage = "Bu alana tarih bilgisi girmelisiniz.")]
        public DateTime DateTime { get; set; }

        [DataMember]
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        [DataMember]
        [Required]
        [DefaultValue(true)]
        [DisplayName("Çalışma Durumu")]
        public bool IsActive { get; set; }

        [DataMember]
        public Examination Examination { get; set; }

        [DataMember]
        public virtual ICollection<LaboratoryRequestItem> LaboratoryRequestItems { get; set; }
    }
}