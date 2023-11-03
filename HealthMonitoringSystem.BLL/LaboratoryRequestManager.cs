// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- LaboratoryRequestManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class LaboratoryRequestManager 
    {
        private ILaboratoryRequestDAL _laboratoryRequestDal;

        public LaboratoryRequestManager(ILaboratoryRequestDAL laboratoryRequestDal)
        {
            _laboratoryRequestDal = laboratoryRequestDal;
        }

        public LaboratoryRequest Select(int id)
        {
            return _laboratoryRequestDal.Select(id);
        }

        public List<LaboratoryRequest> LaboratoryRequests(int examinationId, bool? isActive = true)
        {
            return _laboratoryRequestDal.LaboratoryRequests(examinationId, isActive);
        }

        public bool Insert(LaboratoryRequest newLaboratoryRequest)
        {
            newLaboratoryRequest.DateTime = DateTime.Now;
            newLaboratoryRequest.IsActive = true;
            return _laboratoryRequestDal.Insert(newLaboratoryRequest);
        }

        public bool Update(LaboratoryRequest newInfoLaboratoryRequest)
        {
            return _laboratoryRequestDal.Update(newInfoLaboratoryRequest);
        }

        public bool Delete(int id)
        {
            return _laboratoryRequestDal.Delete(id);
        }

        public bool ActiveService()
        {
            return true;
        }
    }
}