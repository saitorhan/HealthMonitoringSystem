// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- DiagnosisManager.cs

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
    public class DiagnosisManager : IDiagnosisSol
    {
        private IDiagnosisDAL _diagnosisDal;

        public DiagnosisManager()
        {
            _diagnosisDal = new NinjectManager().CoreKernel.Get<IDiagnosisDAL>();
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

            DAL.Extensions.DataBaseResult insert = _diagnosisDal.Insert(newDiagnosis);

            switch (insert)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newDiagnosis.Name));
                    break;
                case DAL.Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case DAL.Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    break;
                case DAL.Extensions.DataBaseResult.NotFound:
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

            DAL.Extensions.DataBaseResult insert = _diagnosisDal.Update(newInfoDiagnosis);

            switch (insert)
            {
                case DAL.Extensions.DataBaseResult.AlreadyFound:
                    result.Result = Extensions.BLLResult.AlreadyFound;
                    result.Errors.Add(Extensions.AlreadyFoundString(newInfoDiagnosis.Name));
                    break;
                case DAL.Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case DAL.Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    break;
                case DAL.Extensions.DataBaseResult.NotFound:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public ProcessResult Delete(int id)
        {
            ProcessResult result = new ProcessResult();

            DAL.Extensions.DataBaseResult delete = _diagnosisDal.Delete(id);
            switch (delete)
            {
                case DAL.Extensions.DataBaseResult.Success:
                    result.Result = Extensions.BLLResult.Success;
                    result.Errors.Add(Extensions.SuccessProcess);
                    break;
                case DAL.Extensions.DataBaseResult.Referanced:
                    result.Result = Extensions.BLLResult.Referanced;
                    result.Errors.Add("Teşhisler başka tablolar üzerinde refere edildiğinden silinemedi");
                    break;
                case DAL.Extensions.DataBaseResult.NotFound:
                    result.Result = Extensions.BLLResult.NotFound;
                    result.Errors.Add(Extensions.NotFound);
                    break;
                case DAL.Extensions.DataBaseResult.Error:
                    result.Result = Extensions.BLLResult.InnerException;
                    result.Errors.Add(Extensions.InnerException);
                    break;
                case DAL.Extensions.DataBaseResult.ServerDisable:
                    result.Result = Extensions.BLLResult.ServerDisable;
                    result.Errors.Add(Extensions.ServerDisable);
                    break;
                case DAL.Extensions.DataBaseResult.AlreadyFound:
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