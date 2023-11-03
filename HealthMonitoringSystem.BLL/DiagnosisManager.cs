// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- DiagnosisManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.DAL.Content.MsSqlContent;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class DiagnosisManager 
    {
        private IDiagnosisDAL _diagnosisDal;

        public DiagnosisManager()
        {
            _diagnosisDal = new MsSqlDiagnosisDal();
        }

        public Diagnosis Select(int id)
        {
            return _diagnosisDal.Select(id);
        }

        public Diagnosis Select(string Name)
        {
            return _diagnosisDal.Select(Name);
        }

        public List<Diagnosis> Diagnoses(int? departmentId, bool? isActive = true)
        {
            return _diagnosisDal.Diagnoses(departmentId, isActive);
        }

        public ProcessResult Insert(Diagnosis newDiagnosis)
        {
            ProcessResult result = VerifeyModel(newDiagnosis);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            Extensions.DataBaseResult insert = _diagnosisDal.Insert(newDiagnosis);

            switch (insert)
            {
                case Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newDiagnosis.Name));
                    break;
                case Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case Extensions.DataBaseResult.Referanced:
                    break;
                case Extensions.DataBaseResult.NotFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public ProcessResult Update(Diagnosis newInfoDiagnosis)
        {
            ProcessResult result = VerifeyModel(newInfoDiagnosis);

            if (result.Result != Extensions.BLLResult.Verified)
            {
                return result;
            }

            Extensions.DataBaseResult insert = _diagnosisDal.Update(newInfoDiagnosis);

            switch (insert)
            {
                case Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newInfoDiagnosis.Name));
                    break;
                case Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case Extensions.DataBaseResult.Referanced:
                    break;
                case Extensions.DataBaseResult.NotFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public ProcessResult Delete(int id)
        {
            ProcessResult result = new ProcessResult();

            Extensions.DataBaseResult delete = _diagnosisDal.Delete(id);
            switch (delete)
            {
                case Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case Extensions.DataBaseResult.Referanced:
                    result.Result = Extensions.BLLResult.Referanced;
                    result.Errors.Add("Teşhisler başka tablolar üzerinde refere edildiğinden silinemedi");
                    break;
                case Extensions.DataBaseResult.NotFound:
                    result.Result = Extensions.BLLResult.NotFound;
                    result.Errors.Add(Extensions.NotFound);
                    break;
                case Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case Extensions.DataBaseResult.AlreadyFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public bool ActiveService()
        {
            return true;
        }

        private ProcessResult VerifeyModel(Diagnosis d)
        {
            ProcessResult result = new ProcessResult();

            if (d.Name.Length == 0 || d.DepartmentId <= 0)
            {
                result.Errors.Add("Ad ve Departman kısmı boş bırakılamaz!");
            }

            result.Result = result.Errors.Count == 0 ? Extensions.BLLResult.Verified : Extensions.BLLResult.NotVerified;

            return result;
        }

        public Diagnosis GetDefaultDiagnosis()
        {
            Diagnosis diagnosis = Select("DEFAULT");
            if (diagnosis != null) return diagnosis;
            DepartmentManager departmentManager = new DepartmentManager();
            Department department = departmentManager.GetDefaultDepartment();
            diagnosis = new Diagnosis
            {
                Name = "DEFAULT", IsActive = true, DepartmentId = department.Id
            };
            Insert(diagnosis);
            return Select("DEFAULT");
        }
    }
}