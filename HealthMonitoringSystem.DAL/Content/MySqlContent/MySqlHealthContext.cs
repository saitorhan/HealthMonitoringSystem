// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- MySqlHealthContext.cs

#region usings

using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using HealthMonitoringSystem.DAL.Migrations;
using HealthMonitoringSystem.Entity;
using MySql.Data.Entity;

#endregion

namespace HealthMonitoringSystem.DAL.Content.MySqlContent
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MySqlHealthContext : DbContext
    {
        public bool ServerIsEnable { get; set; }

        public MySqlHealthContext()
        {
            try
            {
                Database.CreateIfNotExists();
                ServerIsEnable = true;
            }
            catch (Exception ex)
            {
                ServerIsEnable = false;
                SaveExceptionToXml(ex);
                //BUG [Sait,20141203] server kapalı ise nesne oluşmasını engelle
            }

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MySqlHealthContext, MySqlConfiguration>());
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<DoctorPhone> DoctorPhones { get; set; }
        public DbSet<DoctorMail> DoctorMails { get; set; }
        public DbSet<LaboratoryItemUnit> LaboratoryItemUnits { get; set; }
        public DbSet<LaboratoryRequest> LaboratoryRequests { get; set; }
        public DbSet<LaboratoryRequestItem> LaboratoryRequestItems { get; set; }
        public DbSet<LaboratoryRequestType> LaboratoryRequestTypes { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionItem> PrescriptionItems { get; set; }
        public DbSet<RendezvousTime> RendezvousTimes { get; set; }
        public DbSet<Rendezvous> Rendezvouses { get; set; }
        public DbSet<Exceptions> Exceptionses { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Holiday> Holidays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .HasRequired<Department>(d => d.Department)
                .WithMany(dep => dep.Doctors)
                .HasForeignKey(d => d.DepartmentId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Doctor>()
                .HasRequired<Degree>(d => d.Degree)
                .WithMany(dep => dep.Doktors)
                .HasForeignKey(d => d.DegreeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DoctorPhone>()
                .HasRequired<Doctor>(co => co.Doctor)
                .WithMany(c => c.DoctorPhones)
                .HasForeignKey(co => co.DoctorId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DoctorMail>()
                .HasRequired<Doctor>(co => co.Doctor)
                .WithMany(c => c.DoctorMails)
                .HasForeignKey(co => co.DoctorId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Country>()
                .HasRequired<City>(co => co.City)
                .WithMany(c => c.Countries)
                .HasForeignKey(co => co.CityId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Diagnosis>()
                .HasRequired<Department>(co => co.Department)
                .WithMany(c => c.Diagnoses)
                .HasForeignKey(co => co.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Examination>()
                .HasRequired<Patient>(co => co.Patient)
                .WithMany(c => c.Examinations)
                .HasForeignKey(co => co.PatientId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Examination>()
                .HasRequired<Doctor>(co => co.Doctor)
                .WithMany(c => c.Examinations)
                .HasForeignKey(co => co.DoctorId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Examination>()
                .HasRequired<Diagnosis>(co => co.Diagnosis)
                .WithMany(c => c.Examinations)
                .HasForeignKey(co => co.DiagnosisId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LaboratoryRequest>()
                .HasRequired<Examination>(co => co.Examination)
                .WithMany(c => c.LaboratoryRequests)
                .HasForeignKey(co => co.ExaminationId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LaboratoryRequestItem>()
                .HasRequired<LaboratoryRequest>(co => co.LaboratoryRequest)
                .WithMany(c => c.LaboratoryRequestItems)
                .HasForeignKey(co => co.LaboratoryRequestId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<LaboratoryRequestItem>()
                .HasRequired<LaboratoryRequestType>(co => co.LaboratoryRequestType)
                .WithMany(c => c.LaboratoryRequestItems)
                .HasForeignKey(co => co.LaboratoryRequestTypeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LaboratoryRequestType>()
                .HasRequired<LaboratoryItemUnit>(co => co.LaboratoryItemUnit)
                .WithMany(c => c.LaboratoryRequestTypes)
                .HasForeignKey(co => co.LaboratoryItemUnitId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Message>()
                .HasRequired<Doctor>(co => co.Doctor)
                .WithMany(c => c.Messages)
                .HasForeignKey(co => co.DoctorId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Message>()
                .HasRequired<Patient>(co => co.Patient)
                .WithMany(c => c.Messages)
                .HasForeignKey(co => co.PatientId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Patient>()
                .HasRequired<City>(co => co.City)
                .WithMany(c => c.Patients)
                .HasForeignKey(co => co.CityId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Patient>()
                .HasRequired<Country>(co => co.Country)
                .WithMany(c => c.Patients)
                .HasForeignKey(co => co.CountryId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Patient>()
                .HasRequired<BloodGroup>(co => co.BloodGroup)
                .WithMany(c => c.Patients)
                .HasForeignKey(co => co.BloodGroupId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Prescription>()
                .HasRequired<Examination>(co => co.Examination)
                .WithMany(c => c.Prescriptions)
                .HasForeignKey(co => co.ExaminationId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PrescriptionItem>()
                .HasRequired<Prescription>(co => co.Prescription)
                .WithMany(c => c.PrescriptionItems)
                .HasForeignKey(co => co.PrescriptionId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<PrescriptionItem>()
                .HasRequired<Medicament>(co => co.Medicament)
                .WithMany(c => c.PrescriptionItems)
                .HasForeignKey(co => co.MedicamentId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Rendezvous>()
                .HasRequired<RendezvousTime>(co => co.RendezvousTime)
                .WithMany(c => c.Rendezvouses)
                .HasForeignKey(co => co.RendezvousTimeId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Rendezvous>()
                .HasRequired<Patient>(co => co.Patient)
                .WithMany(c => c.Rendezvouses)
                .HasForeignKey(co => co.PatientId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Rendezvous>()
                .HasRequired<Doctor>(co => co.Doctor)
                .WithMany(c => c.Rendezvouses)
                .HasForeignKey(co => co.DoctorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personnel>()
                .HasRequired<City>(co => co.City)
                .WithMany(c => c.Personnels)
                .HasForeignKey(co => co.CityId)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Personnel>()
                .HasRequired<Country>(co => co.Country)
                .WithMany(c => c.Personnels)
                .HasForeignKey(co => co.CountryId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                try
                {
                    string command = GetCommand(ex);
                    SqlConnection connection = new SqlConnection(Database.Connection.ConnectionString);
                    SqlCommand command1 = new SqlCommand(command, connection);
                    connection.Open();
                    command1.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                    SaveExceptionToXml(ex);
                }

                return -1;
            }
        }

        private static void SaveExceptionToXml(Exception ex)
        {
            try
            {
                string directoryPath = String.Format("C:\\Health Monitoring System");

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                directoryPath = String.Format("{0}\\Exception", directoryPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                string filePath = String.Format("{0}\\{1}.xml", directoryPath, DateTime.Now.ToString("O"));
                Stream stream = File.Open(filePath, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, ex);
                stream.Close();
                //TODO [Sait,20141203] Hangi hataların yazılacağını belirt
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private string GetCommand(Exception e)
        {
            return
                String.Format(
                    "INSERT dbo.Exceptions( HResult ,HelpLink ,InnerException ,Message ,Source ,StackTrace ,TargetSite,InnerHResult ,InnerHelpLink ,InnerMessage ,InnerSource ,InnerStackTrace ,InnerTargetSite ,DateTime) VALUES  ( N'{0}' , N'{1}' , N'{2}' , N'{3}' , N'{4}' , N'{5}' , N'{6}' , N'{7}' , N'{8}' , N'{9}' , N'{10}' ,N'{11}' ,N'{12}' ,GETDATE())",
                    e.HResult, e.HelpLink, e.InnerException.Message, e.Message, e.Source, e.StackTrace, e.TargetSite,
                    e.InnerException.HResult, e.InnerException.HelpLink, e.InnerException.Message,
                    e.InnerException.Source, e.InnerException.StackTrace, e.InnerException.TargetSite);
        }
    }
}