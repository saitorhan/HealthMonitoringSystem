// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WCFService -- ServiceModule.cs

#region usings

using System;
using System.Configuration;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.DAL.Content.MsSqlContent;
using HealthMonitoringSystem.DAL.Content.MySqlContent;
using HealthMonitoringSystem.Entity.Enums;
using Ninject.Modules;

#endregion

namespace HealthMonitoringSystem.WCFService
{
    public class ServiceModule : NinjectModule
    {
        public ServerType ServerType
        {
            get
            {
                Entity.Enums.ServerType enServerType;
                string serverType = ConfigurationManager.AppSettings["ServerType"];
                bool tryParse = Enum.TryParse(serverType, true, out enServerType);
                return tryParse ? enServerType : ServerType.MsSql;
            }
        }
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            switch (ServerType)
            {
                case ServerType.MsSql:
                    BindMsSqlServer();
                    break;
                case ServerType.MySql:
                    BindMySqlServer();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void BindMySqlServer()
        {
            this.Bind<IBloodGroupDAL>().To<MySqlBloodGroupDal>();
            this.Bind<ICityDAL>().To<MySqlCityDal>();
            this.Bind<ICountryDAL>().To<MySqlCountryDal>();
            this.Bind<IDegreeDAL>().To<MySqlDegreeDal>();
            this.Bind<IDepartmentDAL>().To<MySqlDepartmentDal>();
            this.Bind<IDiagnosisDAL>().To<MySqlDiagnosisDal>();
            this.Bind<IDoctorMailDAL>().To<MySqlDoctorMailDal>();
            this.Bind<IDoctorDAL>().To<MySqlDoctorDal>();
            this.Bind<IDoctorPhoneDAL>().To<MySqlDoctorPhoneDal>();
            this.Bind<IExaminationDAL>().To<MySqlExaminationDal>();
            this.Bind<ILaboratoryItemUnitDAL>().To<MySqlLaboratoryItemUnit>();
            this.Bind<ILaboratoryRequestItemDAL>().To<MySqlLaboratoryRequestItemDal>();
            this.Bind<ILaboratoryRequestDAL>().To<MySqlLaboratoryRequestDal>();
            this.Bind<ILaboratoryRequestTypeDAL>().To<MySqlLaboratoryRequestTypeDal>();
            this.Bind<IMedicamentDAL>().To<MySqlMedicamentDal>();
            this.Bind<IMessageDAL>().To<MySqlMessageDal>();
            this.Bind<IPatientDAL>().To<MySqlPatientDal>();
            this.Bind<IPrescriptionItemDAL>().To<MySqlPrescriptionItemDal>();
            this.Bind<IPrescriptionDAL>().To<MySqlPrescriptionDal>();
            this.Bind<IRendezvousDAL>().To<MySqlRendezvousDal>();
            this.Bind<IRendezvousTimeDAL>().To<MySqlRendezvousTimeDal>();
            this.Bind<IPersonnelDAL>().To<MySqlPersonnelDal>();
            this.Bind<IHolidayDAL>().To<MySqlHolidayDal>();
        }

        private void BindMsSqlServer()
        {
            this.Bind<IBloodGroupDAL>().To<MsSqlBloodGroupDal>();
            this.Bind<ICityDAL>().To<MsSqlCityDal>();
            this.Bind<ICountryDAL>().To<MsSqlCountryDal>();
            this.Bind<IDegreeDAL>().To<MsSqlDegreeDal>();
            this.Bind<IDepartmentDAL>().To<MsSqlDepartmentDal>();
            this.Bind<IDiagnosisDAL>().To<MsSqlDiagnosisDal>();
            this.Bind<IDoctorMailDAL>().To<MsSqlDoctorMailDal>();
            this.Bind<IDoctorDAL>().To<MsSqlDoctorDal>();
            this.Bind<IDoctorPhoneDAL>().To<MsSqlDoctorPhoneDal>();
            this.Bind<IExaminationDAL>().To<MsSqlExaminationDal>();
            this.Bind<ILaboratoryItemUnitDAL>().To<MsSqlLaboratoryItemUnit>();
            this.Bind<ILaboratoryRequestItemDAL>().To<MsSqlLaboratoryRequestItemDal>();
            this.Bind<ILaboratoryRequestDAL>().To<MsSqlLaboratoryRequestDal>();
            this.Bind<ILaboratoryRequestTypeDAL>().To<MsSqlLaboratoryRequestTypeDal>();
            this.Bind<IMedicamentDAL>().To<MsSqlMedicamentDal>();
            this.Bind<IMessageDAL>().To<MsSqlMessageDal>();
            this.Bind<IPatientDAL>().To<MsSqlPatientDal>();
            this.Bind<IPrescriptionItemDAL>().To<MsSqlPrescriptionItemDal>();
            this.Bind<IPrescriptionDAL>().To<MsSqlPrescriptionDal>();
            this.Bind<IRendezvousDAL>().To<MsSqlRendezvousDal>();
            this.Bind<IRendezvousTimeDAL>().To<MsSqlRendezvousTimeDal>();
            this.Bind<IPersonnelDAL>().To<MsSqlPersonnelDal>();
            this.Bind<IHolidayDAL>().To<MsSqlHolidayDal>();
        }
    }
}