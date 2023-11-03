// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- EfDegreeDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MsSqlContent
{
    public class MsSqlDegreeDal : IDegreeDAL
    {
        public Degree Select(int id)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.Degrees.FirstOrDefault(d => d.Id == id);
            }
        }

        public List<Degree> Degrees(bool? isActive = true)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                return ctx.Degrees.Where(c => isActive == null || c.IsActive == isActive).ToList();
            }
        }

        public Extensions.DataBaseResult Insert(Degree newDegree)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Degrees.Any(d => d.Name == newDegree.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }
                ctx.Degrees.Add(newDegree);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(Degree newInfoDegree)
        {
            using (MsSqlHealthContext ctx = new MsSqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Degrees.Any(d => d.Name == newInfoDegree.Name && d.Id != newInfoDegree.Id))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }

                Degree degree = ctx.Degrees.FirstOrDefault(d => d.Id == newInfoDegree.Id);

                if (degree == null)
                    return Extensions.DataBaseResult.NotFound;

                degree.Name = newInfoDegree.Name;
                degree.ShortName = newInfoDegree.ShortName;
                degree.IsActive = newInfoDegree.IsActive;
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

                Degree degree = ctx.Degrees.FirstOrDefault(d => d.Id == id);
                if (degree == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                bool b = ctx.Doctors.Any(d => d.DegreeId == degree.Id);
                if (b)
                {
                    return Extensions.DataBaseResult.Referanced;
                }

                ctx.Degrees.Remove(degree);
                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}