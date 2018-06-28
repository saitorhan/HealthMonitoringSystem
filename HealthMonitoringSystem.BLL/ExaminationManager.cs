// Sait ORHAN -- 11.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- ExaminationManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;
using Ninject;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class ExaminationManager : IExaminationSol
    {
        private IExaminationDAL _examinationDal;

        public ExaminationManager()
        {
            _examinationDal = new NinjectManager().CoreKernel.Get<IExaminationDAL>();
        }

        public Examination Select(int id)
        {
            return _examinationDal.Select(id);
        }

        public List<Examination> Examinations(DateTime? time, int doctorId, int? patientId, bool? isActive = true,
            bool includeDiagnosis = false)
        {
            return _examinationDal.Examinations(time, doctorId, patientId, isActive, includeDiagnosis);
        }

        public bool Insert(Examination newExamination)
        {
            if (newExamination.DiagnosisId > 0) return _examinationDal.Insert(newExamination);

            DiagnosisManager manager = new DiagnosisManager();
            newExamination.DiagnosisId = manager.GetDefaultDiagnosis().Id;
            return _examinationDal.Insert(newExamination);
        }

        public bool Update(Examination newInfoExamination)
        {
            if (newInfoExamination.DiagnosisId > 0) return _examinationDal.Update(newInfoExamination);

            DiagnosisManager manager = new DiagnosisManager();
            newInfoExamination.DiagnosisId = manager.GetDefaultDiagnosis().Id;
            return _examinationDal.Update(newInfoExamination);
        }

        public bool Delete(int id)
        {
            return _examinationDal.Delete(id);
        }

        public bool ActiveService()
        {
            return true;
        }
    }
}