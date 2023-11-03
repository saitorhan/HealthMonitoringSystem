// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MsSqlDepartmentDAL.cs

#region usings

using System.Collections.Generic;
using System.Linq;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Entity.Classes;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    public class MySqlDepartmentDal : IDepartmentDAL
    {
        public Department Select(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.Departments.FirstOrDefault(d => d.Id == id);
            }
        }

        public Department Select(string name)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return ctx.Departments.FirstOrDefault(d => d.Name == name);
            }
        }

        public List<Department> Departments(bool? isActive = true, bool includeDoctors = true)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                return includeDoctors
                    ? ctx.Departments.Include("Doctors")
                        .Where(c => isActive == null || c.IsActive == isActive)
                        .ToList()
                    : ctx.Departments.Where(c => isActive == null || c.IsActive == isActive).ToList();
            }
        }

        public Extensions.DataBaseResult Insert(Department newDepartment)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Departments.Any(d => d.Name == newDepartment.Name))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }

                ctx.Departments.Add(newDepartment);

                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Update(Department newInfoDepartment)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                if (ctx.Departments.Any(d => d.Name == newInfoDepartment.Name && d.Id != newInfoDepartment.Id))
                {
                    return Extensions.DataBaseResult.AlreadyFound;
                }

                Department department = ctx.Departments.FirstOrDefault(d => d.Id == newInfoDepartment.Id);
                if (department == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                department.Name = newInfoDepartment.Name;
                department.IsActive = newInfoDepartment.IsActive;
                department.MinAge = newInfoDepartment.MinAge;
                department.MaxAge = newInfoDepartment.MaxAge;
                department.Gender = newInfoDepartment.Gender;

                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }

        public Extensions.DataBaseResult Delete(int id)
        {
            using (MySqlHealthContext ctx = new MySqlHealthContext())
            {
                if (!ctx.ServerIsEnable)
                {
                    return Extensions.DataBaseResult.ServerDisable;
                }

                Department department = ctx.Departments.FirstOrDefault(d => d.Id == id);

                if (department == null)
                {
                    return Extensions.DataBaseResult.NotFound;
                }

                bool b = ctx.Doctors.Any(d => d.DepartmentId == id) || ctx.Diagnoses.Any(d => d.DepartmentId == id);

                if (b)
                {
                    return Extensions.DataBaseResult.Referanced;
                }

                ctx.Departments.Remove(department);

                return ctx.SaveChanges() > -1 ? Extensions.DataBaseResult.Success : Extensions.DataBaseResult.Error;
            }
        }
    }
}