// Sait ORHAN -- 11.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- IExaminationDAL.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Abstract
{
    public interface IExaminationDAL
    {
        Examination Select(int id);

        List<Examination> Examinations(DateTime? time, int doctorId, int? patientId, bool? isActive = true,
            bool includeDiagnosis = false);

        bool Insert(Examination newExamination);
        bool Update(Examination newInfoExamination);
        bool Delete(int id);
    }
}