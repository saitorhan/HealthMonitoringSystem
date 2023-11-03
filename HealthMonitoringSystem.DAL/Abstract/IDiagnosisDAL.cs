// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IDiagnosisDAL.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IDiagnosisDAL
    {
        Diagnosis Select(int id);
        List<Diagnosis> Diagnoses(int? departmentId, bool? isActive = true);
        Extensions.DataBaseResult Insert(Diagnosis newDiagnosis);
        Extensions.DataBaseResult Update(Diagnosis newInfoDiagnosis);
        Extensions.DataBaseResult Delete(int id);
        Diagnosis Select(string name);
    }
}