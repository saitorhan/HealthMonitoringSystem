// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- PrescriptionItemManager.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.DAL.Content.MsSqlContent;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class PrescriptionItemManager 
    {
        private IPrescriptionItemDAL _prescriptionItemDal;

        public PrescriptionItemManager()
        {
            _prescriptionItemDal = new MsSqlPrescriptionItemDal();
        }

        public PrescriptionItem Select(int id)
        {
            return _prescriptionItemDal.Select(id);
        }

        public List<PrescriptionItem> PrescriptionItems(int presId, bool? isActive = true)
        {
            return _prescriptionItemDal.PrescriptionItems(presId, isActive);
        }

        public bool Insert(PrescriptionItem newPrescriptionItem)
        {
            return _prescriptionItemDal.Insert(newPrescriptionItem);
        }

        public bool Update(PrescriptionItem newInfoPresciptionItem)
        {
            return _prescriptionItemDal.Update(newInfoPresciptionItem);
        }

        public bool Delete(int id)
        {
            return _prescriptionItemDal.Delete(id);
        }
    }
}