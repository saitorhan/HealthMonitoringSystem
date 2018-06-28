// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfPrescriptionItemDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlPrescriptionItemDal : IPrescriptionItemDAL
    {
        public PrescriptionItem Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.PrescriptionItems.Include("Prescription").Include("Medicament").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<PrescriptionItem> PrescriptionItems(int presId, bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.PrescriptionItems.Include("Medicament")
                        .Where(c => c.PrescriptionId == presId && (isActive == null || c.IsActive == isActive))
                        .ToList();
            }
        }

        public bool Insert(PrescriptionItem newPrescriptionItem)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                ctx.PrescriptionItems.Add(newPrescriptionItem);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(PrescriptionItem newInfoPresciptionItem)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                PrescriptionItem prescriptionItem =
                    ctx.PrescriptionItems.FirstOrDefault(d => d.Id == newInfoPresciptionItem.Id);

                if (prescriptionItem == null)
                {
                    return false;
                }

                prescriptionItem.PrescriptionId = newInfoPresciptionItem.PrescriptionId;
                prescriptionItem.MedicamentId = newInfoPresciptionItem.MedicamentId;
                prescriptionItem.UsePerDay = newInfoPresciptionItem.UsePerDay;
                prescriptionItem.DoctorNote = newInfoPresciptionItem.DoctorNote;
                prescriptionItem.IsActive = newInfoPresciptionItem.IsActive;
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                PrescriptionItem prescriptionItem = ctx.PrescriptionItems.FirstOrDefault(d => d.Id == id);
                if (prescriptionItem == null)
                {
                    return false;
                }
                ctx.PrescriptionItems.Remove(prescriptionItem);
                return ctx.SaveChanges() > -1;
            }
        }
    }
}