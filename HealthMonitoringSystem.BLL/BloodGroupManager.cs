// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- BloodGroupManager.cs

#region usings

using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.DAL.Content.MsSqlContent;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class BloodGroupManager
    {
        private IBloodGroupDAL _bloodGroupDal;

        public BloodGroupManager()
        {
            _bloodGroupDal = new MsSqlBloodGroupDal();
        }

        public BloodGroup Select(int id)
        {
            return _bloodGroupDal.Select(id);
        }

        public List<BloodGroup> BloodGroups(bool? isActive = true)
        {
            return _bloodGroupDal.BloodGroups(isActive);
        }

        public bool Insert(BloodGroup newBloodGroup)
        {
            return _bloodGroupDal.Insert(newBloodGroup);
        }

        public bool Update(BloodGroup newInfoBloodGroup)
        {
            return _bloodGroupDal.Update(newInfoBloodGroup);
        }

        public bool Delete(int id)
        {
            return _bloodGroupDal.Delete(id);
        }
    }
}