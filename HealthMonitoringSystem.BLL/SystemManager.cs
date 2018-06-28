// Sait ORHAN -- 08.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- SystemManager.cs

#region usings

using System;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;

#endregion

namespace HealthMonitoringSystem.BLL
{
    public class SystemManager : ISystemSol
    {
        public Doctor LoginDoctor(string tc, string password)
        {
            DoctorManager manager = new DoctorManager();
            Doctor doctor = manager.Select(tc);
            if (doctor == null)
            {
                return null;
            }
            return String.CompareOrdinal(password, doctor.Password) != 0 ? null : doctor;
        }

        public Personnel LoginPersonnel(string tc, string password)
        {
            PersonnelManager manager = new PersonnelManager();
            Personnel personnel = manager.Select(tc);
            if (personnel == null)
            {
                return null;
            }
            return String.CompareOrdinal(password, personnel.Password) != 0 ? null : personnel;
        }

        public Patient LoginPatient(string tc, string password)
        {
            PatientManager manager = new PatientManager();
            Patient patient = manager.Select(tc);
            if (patient == null)
            {
                return null;
            }
            return String.CompareOrdinal(password, patient.Password) != 0 ? null : patient;
        }

        public bool Test()
        {
            return true;
        }
    }
}