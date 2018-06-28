// Sait ORHAN -- 11.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- IExaminationSol.cs

#region usings

// HealthMonitoringSystem.Interfaces - IExaminationSol.cs
// 30 / 09 / 2014

using System;
using System.Collections.Generic;
using System.ServiceModel;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.Interfaces
{
    [ServiceContract]
    [ServiceKnownType(typeof (Examination))]
    [ServiceKnownType(typeof (Patient))]
    [ServiceKnownType(typeof (Doctor))]
    [ServiceKnownType(typeof (Diagnosis))]
    public interface IExaminationSol
    {
        [OperationContract]
        Examination Select(int id);

        [OperationContract]
        List<Examination> Examinations(DateTime? time, int doctorId, int? patientId, bool? isActive = true,
            bool includeDiagnosis = false);

        [OperationContract]
        bool Insert(Examination newExamination);

        [OperationContract]
        bool Update(Examination newInfoExamination);

        [OperationContract]
        bool Delete(int id);

        [OperationContract]
        bool ActiveService();
    }
}