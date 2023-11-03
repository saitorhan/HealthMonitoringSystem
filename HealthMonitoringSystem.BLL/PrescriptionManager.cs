// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- PrescriptionManager.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.DAL.Content.MsSqlContent;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class PrescriptionManager 
    {
        private IPrescriptionDAL _prescriptionDal;

        public PrescriptionManager()
        {
            _prescriptionDal = new MsSqlPrescriptionDal();
        }

        public Prescription Select(int id)
        {
            return _prescriptionDal.Select(id);
        }

        public List<PrescriptionItem> GetPrescriptionItems(int examId)
        {
            Prescription prescription = _prescriptionDal.Prescriptions().FirstOrDefault(p => p.ExaminationId == examId);
            if (prescription == null) return null;
            PrescriptionItemManager manager = new PrescriptionItemManager();
            return manager.PrescriptionItems(prescription.Id);
        }

        public List<Prescription> Prescriptions(bool? isActive = true)
        {
            return _prescriptionDal.Prescriptions();
        }

        public ProcessResult Insert(Prescription newPrescription)
        {
            ExaminationManager manager = new ExaminationManager();
            ProcessResult result = VerifyPrescription(newPrescription);
            if (result.Result == Extensions.BLLResult.NotVerified)
            {
                return result;
            }

            Examination examination = manager.Select(newPrescription.Examination.Id);
            examination.DiagnosisId = newPrescription.Examination.DiagnosisId;
            examination.IsActive = false;
            examination.DoctorNote = newPrescription.Examination.DoctorNote;
            examination.CanSendMessage = newPrescription.Examination.CanSendMessage;
            examination.NextTime = newPrescription.Examination.NextTime;

            newPrescription.Examination = null;
            if (_prescriptionDal.Insert(newPrescription))
            {
                bool update = manager.Update(examination);
                if (update)
                {
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add("Reçete başarı ile oluşturuldu ve muayene kapandı");
                }
                else
                {
                    result.Result = Extensions.BLLResult.Error;
                    result.Errors.Add("Reçete oluşturulamadı");
                }
            }
            else
            {
                result.Result = Extensions.BLLResult.Error;
                result.Errors.Add("Reçete oluşturulamadı");
            }
            return result;
        }

        private ProcessResult VerifyPrescription(Prescription newPrescription)
        {
            ProcessResult result = new ProcessResult();
            DiagnosisManager manager = new DiagnosisManager();
            if (newPrescription.Examination.DiagnosisId < 1 ||
                newPrescription.Examination.DiagnosisId == manager.GetDefaultDiagnosis().Id)
            {
                result.Errors.Add("Reçeteli kapatmalarda teşhis belirtilmelidir.");
            }
            if (newPrescription.PrescriptionItems.Count == 0)
            {
                result.Errors.Add("Reçeteli kapatmalarda enaz bir ilaç eklenmelidir");
            }
            if (newPrescription.PrescriptionItems.Any(p => p.MedicamentId < 1))
            {
                result.Errors.Add("İlacı belirtilmemiş reçete satırı olamaz.");
            }

            if (newPrescription.DoctorNote != null)
            {
                if (newPrescription.DoctorNote.Length > 500)
                {
                    result.Errors.Add(string.Format("Doktor notu 500 karakteri geçemez. Not uzunluğu: {0}",
                        newPrescription.DoctorNote.Length));
                }
            }

            result.Result = !result.Errors.Any()
                ? Extensions.BLLResult.Verified
                : Extensions.BLLResult.NotVerified;

            return result;
        }

        public bool Update(Prescription newInfoPresciption)
        {
            return _prescriptionDal.Update(newInfoPresciption);
        }

        public bool Delete(int id)
        {
            return _prescriptionDal.Delete(id);
        }
    }
}