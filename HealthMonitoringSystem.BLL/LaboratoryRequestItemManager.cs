// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- LaboratoryRequestItemManager.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class LaboratoryRequestItemManager : ILaboratoryRequestItemSol
    {
        private ILaboratoryRequestItemDAL _laboratoryRequestItemDal;

        public LaboratoryRequestItemManager(ILaboratoryRequestItemDAL laboratoryRequestItemDal)
        {
            _laboratoryRequestItemDal = laboratoryRequestItemDal;
        }

        public LaboratoryRequestItem Select(int id)
        {
            return _laboratoryRequestItemDal.Select(id);
        }

        public List<LaboratoryRequestItem> LaboratoryRequestItems(int requestId)
        {
            return _laboratoryRequestItemDal.LaboratoryRequestItems(requestId);
        }

        public bool Insert(LaboratoryRequestItem newLaboratoryRequestItem)
        {
            return _laboratoryRequestItemDal.Insert(newLaboratoryRequestItem);
        }

        public bool Update(LaboratoryRequestItem newInfoLaboratoryRequestItem)
        {
            return _laboratoryRequestItemDal.Update(newInfoLaboratoryRequestItem);
        }

        public bool Delete(int id)
        {
            return _laboratoryRequestItemDal.Delete(id);
        }

        public bool ActiveService()
        {
            return true;
        }
    }
}