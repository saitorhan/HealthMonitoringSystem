// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlPrescriptionItemDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlPrescriptionItemDal : IPrescriptionItemDAL
    {
        public PrescriptionItem Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.PrescriptionItems.Include("Prescription").Include("Medicament").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<PrescriptionItem> PrescriptionItems(int presId, bool? isActive = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return
                    ctx.PrescriptionItems.Include("Medicament")
                        .Where(c => c.PrescriptionId == presId && (isActive == null || c.IsActive == isActive))
                        .ToList();
            }
        }

        public bool Insert(PrescriptionItem newPrescriptionItem)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                ctx.PrescriptionItems.Add(newPrescriptionItem);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(PrescriptionItem newInfoPresciptionItem)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
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
            using (MySqlHealthContext ctx = new MySqlHealthContext())
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