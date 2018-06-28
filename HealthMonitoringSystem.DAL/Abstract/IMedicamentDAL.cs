// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IMedicamentDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IMedicamentDAL
    {
        Medicament Select(int id);
        List<Medicament> Medicaments(bool? isActive = true);
        Extensions.DataBaseResult Insert(Medicament newMedicament);
        Extensions.DataBaseResult Update(Medicament newInfoMedicament);
        Extensions.DataBaseResult Delete(int id);
    }
}