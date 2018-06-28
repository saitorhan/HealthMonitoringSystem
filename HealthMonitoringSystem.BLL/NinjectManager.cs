using System;
using System.Configuration;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.DAL.Content.MsSqlContent;
using HealthMonitoringSystem.DAL.Content.MySqlContent;
using HealthMonitoringSystem.Entity.Enums;
using Ninject;
using Ninject.Modules;

namespace HealthMonitoringSystem.BLL
{
    public class NinjectManager : NinjectModule
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

        public readonly IKernel CoreKernel;
        public NinjectManager()
        {
            CoreKernel = new StandardKernel();
            Load();
        }
        public override void Load()
        {
            switch (ServerType)
            {
                case ServerType.MySql:
                    BindMySqlServer();
                    break;
                case ServerType.MsSql:
                    BindMsSqlServer();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void BindMsSqlServer()
        {
            CoreKernel.Bind<IBloodGroupDAL>().To<MsSqlBloodGroupDal>();
            CoreKernel.Bind<ICityDAL>().To<MsSqlCityDal>();
            CoreKernel.Bind<ICountryDAL>().To<MsSqlCountryDal>();
            CoreKernel.Bind<IDegreeDAL>().To<MsSqlDegreeDal>();
            CoreKernel.Bind<IDepartmentDAL>().To<MsSqlDepartmentDal>();
            CoreKernel.Bind<IDiagnosisDAL>().To<MsSqlDiagnosisDal>();
            CoreKernel.Bind<IDoctorMailDAL>().To<MsSqlDoctorMailDal>();
            CoreKernel.Bind<IDoctorDAL>().To<MsSqlDoctorDal>();
            CoreKernel.Bind<IDoctorPhoneDAL>().To<MsSqlDoctorPhoneDal>();
            CoreKernel.Bind<IExaminationDAL>().To<MsSqlExaminationDal>();
            CoreKernel.Bind<ILaboratoryItemUnitDAL>().To<MsSqlLaboratoryItemUnit>();
            CoreKernel.Bind<ILaboratoryRequestItemDAL>().To<MsSqlLaboratoryRequestItemDal>();
            CoreKernel.Bind<ILaboratoryRequestDAL>().To<MsSqlLaboratoryRequestDal>();
            CoreKernel.Bind<ILaboratoryRequestTypeDAL>().To<MsSqlLaboratoryRequestTypeDal>();
            CoreKernel.Bind<IMedicamentDAL>().To<MsSqlMedicamentDal>();
            CoreKernel.Bind<IMessageDAL>().To<MsSqlMessageDal>();
            CoreKernel.Bind<IPatientDAL>().To<MsSqlPatientDal>();
            CoreKernel.Bind<IPrescriptionItemDAL>().To<MsSqlPrescriptionItemDal>();
            CoreKernel.Bind<IPrescriptionDAL>().To<MsSqlPrescriptionDal>();
            CoreKernel.Bind<IRendezvousDAL>().To<MsSqlRendezvousDal>();
            CoreKernel.Bind<IRendezvousTimeDAL>().To<MsSqlRendezvousTimeDal>();
            CoreKernel.Bind<IPersonnelDAL>().To<MsSqlPersonnelDal>();
            CoreKernel.Bind<IHolidayDAL>().To<MsSqlHolidayDal>();
        }

        private void BindMySqlServer()
        {
            CoreKernel.Bind<IBloodGroupDAL>().To<MySqlBloodGroupDal>();
            CoreKernel.Bind<ICityDAL>().To<MySqlCityDal>();
            CoreKernel.Bind<ICountryDAL>().To<MySqlCountryDal>();
            CoreKernel.Bind<IDegreeDAL>().To<MySqlDegreeDal>();
            CoreKernel.Bind<IDepartmentDAL>().To<MySqlDepartmentDal>();
            CoreKernel.Bind<IDiagnosisDAL>().To<MySqlDiagnosisDal>();
            CoreKernel.Bind<IDoctorMailDAL>().To<MySqlDoctorMailDal>();
            CoreKernel.Bind<IDoctorDAL>().To<MySqlDoctorDal>();
            CoreKernel.Bind<IDoctorPhoneDAL>().To<MySqlDoctorPhoneDal>();
            CoreKernel.Bind<IExaminationDAL>().To<MySqlExaminationDal>();
            CoreKernel.Bind<ILaboratoryItemUnitDAL>().To<MySqlLaboratoryItemUnit>();
            CoreKernel.Bind<ILaboratoryRequestItemDAL>().To<MySqlLaboratoryRequestItemDal>();
            CoreKernel.Bind<ILaboratoryRequestDAL>().To<MySqlLaboratoryRequestDal>();
            CoreKernel.Bind<ILaboratoryRequestTypeDAL>().To<MySqlLaboratoryRequestTypeDal>();
            CoreKernel.Bind<IMedicamentDAL>().To<MySqlMedicamentDal>();
            CoreKernel.Bind<IMessageDAL>().To<MySqlMessageDal>();
            CoreKernel.Bind<IPatientDAL>().To<MySqlPatientDal>();
            CoreKernel.Bind<IPrescriptionItemDAL>().To<MySqlPrescriptionItemDal>();
            CoreKernel.Bind<IPrescriptionDAL>().To<MySqlPrescriptionDal>();
            CoreKernel.Bind<IRendezvousDAL>().To<MySqlRendezvousDal>();
            CoreKernel.Bind<IRendezvousTimeDAL>().To<MySqlRendezvousTimeDal>();
            CoreKernel.Bind<IPersonnelDAL>().To<MySqlPersonnelDal>();
            CoreKernel.Bind<IHolidayDAL>().To<MySqlHolidayDal>();
        }
    }
}