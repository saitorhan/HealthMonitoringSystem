// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Consultation.cs

namespace HealthMonitoringSystem.Entity
{
    public class Consultation
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public bool IsActive { get; set; }
        public Patient Patient { get; set; }
    }
}