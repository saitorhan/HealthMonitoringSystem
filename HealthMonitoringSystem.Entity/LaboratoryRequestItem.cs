// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- LaboratoryRequestItem.cs

#region usings

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof (LaboratoryRequestItem))]
    public class LaboratoryRequestItem
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int LaboratoryRequestId { get; set; }

        [DataMember]
        public int LaboratoryRequestTypeId { get; set; }

        [DataMember]
        [DisplayName("Laboratuar Sonucu")]
        [DataType(DataType.Text)]
        public double? Result { get; set; }

        [DataMember]
        public LaboratoryRequest LaboratoryRequest { get; set; }

        [DataMember]
        public LaboratoryRequestType LaboratoryRequestType { get; set; }
    }
}