// Sait ORHAN -- 02.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfPersonnelDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlPersonnelDal : IPersonnelDAL
    {
        public Personnel Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.Personnels.Include("City").Include("Country").Include("Degree").FirstOrDefault(d => d.Id == id);
            }
        }

        public List<Personnel> Personnels(bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.Personnels.Include("City")
                        .Include("Country")
                        .Include("Degree")
                        .Where(c => isActive == null || c.IsActive == isActive)
                        .ToList();
            }
        }

        public bool Insert(Personnel newPersonnel)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                ctx.Personnels.Add(newPersonnel);
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Update(Personnel newInfoPersonnel)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                Personnel personnel = ctx.Personnels.FirstOrDefault(d => d.Id == newInfoPersonnel.Id);
                if (personnel == null)
                {
                    return false;
                }

                personnel.TcNo = newInfoPersonnel.TcNo;
                personnel.Name = newInfoPersonnel.Name;
                personnel.Surname = newInfoPersonnel.Surname;
                personnel.Address = newInfoPersonnel.Address;
                personnel.CityId = newInfoPersonnel.CityId;
                personnel.CountryId = newInfoPersonnel.CountryId;
                personnel.Phone = newInfoPersonnel.Phone;
                personnel.Mail = newInfoPersonnel.Mail;
                personnel.BirthDay = newInfoPersonnel.BirthDay;
                personnel.Gender = newInfoPersonnel.Gender;
                personnel.City = newInfoPersonnel.City;
                personnel.Country = newInfoPersonnel.Country;
                personnel.IsActive = newInfoPersonnel.IsActive;
                personnel.DegreeId = newInfoPersonnel.DegreeId;
                return ctx.SaveChanges() > -1;
            }
        }

        public bool Delete(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                Personnel personnel = ctx.Personnels.FirstOrDefault(d => d.Id == id);
                if (personnel == null)
                {
                    return false;
                }

                ctx.Personnels.Remove(personnel);
                return ctx.SaveChanges() > -1;
            }
        }

        public Personnel Select(string tc)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return
                    ctx.Personnels.Include("City")
                        .Include("Country")
                        .Include("Degree")
                        .FirstOrDefault(d => d.TcNo == tc);
            }
        }
    }
}