// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IMedicamentSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IMedicamentSol.cs
// 30 / 09 / 2014

using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Medicament))]
    public interface IMedicamentSol
    {
        [OperationContract]
        Medicament Select(int id);

        [OperationContract]
        List<Medicament> Medicaments(bool? isActive = true);

        [OperationContract]
        ProcessResult Insert(Medicament newMedicament);

        [OperationContract]
        ProcessResult Update(Medicament newInfoMedicament);

        [OperationContract]
        ProcessResult Delete(int id);
    }
}