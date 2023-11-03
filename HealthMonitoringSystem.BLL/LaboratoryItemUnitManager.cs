// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- LaboratoryItemUnitManager.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class LaboratoryItemUnitManager 
    {
        private ILaboratoryItemUnitDAL _laboratoryItemUnitDal;

        public LaboratoryItemUnitManager(ILaboratoryItemUnitDAL laboratoryItemUnitDal)
        {
            _laboratoryItemUnitDal = laboratoryItemUnitDal;
        }

        public LaboratoryItemUnit Select(int id)
        {
            return _laboratoryItemUnitDal.Select(id);
        }

        public List<LaboratoryItemUnit> LaboratoryItemUnits(bool? isActive = true)
        {
            return _laboratoryItemUnitDal.LaboratoryItemUnits();
        }

        public bool Insert(LaboratoryItemUnit newLaboratoryItemUnit)
        {
            return _laboratoryItemUnitDal.Insert(newLaboratoryItemUnit);
        }

        public bool Update(LaboratoryItemUnit newInfoLaboratoryItemUnit)
        {
            return _laboratoryItemUnitDal.Update(newInfoLaboratoryItemUnit);
        }

        public bool Delete(int id)
        {
            return _laboratoryItemUnitDal.Delete(id);
        }
    }
}