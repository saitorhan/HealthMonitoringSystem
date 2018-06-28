// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfMedicamentDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlMedicamentDal : IMedicamentDAL
    {
        public Medicament Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.Medicaments.FirstOrDefault(d => d.Id == id);
            }
        }

        public List<Medicament> Medicaments(bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.Medicaments.Where(c => isActive == null || c.IsActive == isActive).ToList();
            }
        }

        public Extensions.DataBaseResult Insert(Medicament newMedicament)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Departments.Any(d => d.Name == newMedicament.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                ctx.Medicaments.Add(newMedicament);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(Medicament newInfoMedicament)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Departments.Any(d => d.Name == newInfoMedicament.Name && d.Id != newInfoMedicament.Id))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }

                Medicament medicament = ctx.Medicaments.FirstOrDefault(d => d.Id == newInfoMedicament.Id);

                if (medicament == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                medicament.Name = newInfoMedicament.Name;
                medicament.UsePerDay = newInfoMedicament.UsePerDay;
                medicament.Note = newInfoMedicament.Note;
                medicament.IsActive = newInfoMedicament.IsActive;

                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Delete(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                Medicament medicament = ctx.Medicaments.FirstOrDefault(d => d.Id == id);
                if (medicament == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }
                bool b = ctx.PrescriptionItems.Any(d => d.MedicamentId == id);

                if (b)
                {
                    return Extensions.DataBaseResult.Referanced;
                }

                ctx.Medicaments.Remove(medicament);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}