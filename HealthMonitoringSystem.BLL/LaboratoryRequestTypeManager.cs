// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- LaboratoryRequestTypeManager.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class LaboratoryRequestTypeManager 
    {
        private ILaboratoryRequestTypeDAL _laboratoryRequestTypeDal;

        public LaboratoryRequestTypeManager(ILaboratoryRequestTypeDAL laboratoryRequestTypeDal)
        {
            _laboratoryRequestTypeDal = laboratoryRequestTypeDal;
        }

        public LaboratoryRequestType Select(int id)
        {
            return _laboratoryRequestTypeDal.Select(id);
        }

        public List<LaboratoryRequestType> LaboratoryRequestTypes(bool? isActive = true)
        {
            return _laboratoryRequestTypeDal.LaboratoryRequestTypes();
        }

        public bool Insert(LaboratoryRequestType newLaboratoryRequestType)
        {
            return _laboratoryRequestTypeDal.Insert(newLaboratoryRequestType);
        }

        public bool Update(LaboratoryRequestType newInfoLaboratoryRequestType)
        {
            return _laboratoryRequestTypeDal.Update(newInfoLaboratoryRequestType);
        }

        public bool Delete(int id)
        {
            return _laboratoryRequestTypeDal.Delete(id);
        }
    }
}