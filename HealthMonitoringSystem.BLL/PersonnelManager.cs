// Sait ORHAN -- 02.12.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.BLL -- PersonnelManager.cs

#region usings

using System;
using System.Collections.Generic;
using HealthMonitoringSystem.DAL.Abstract;
using HealthMonitoringSystem.Entity;
using HealthMonitoringSystem.Interfaces;
using Ninject;

#endregion

// ReSharper disable UnusedVariable

namespace HealthMonitoringSystem.BLL
{
    public class PersonnelManager 
    {
        private IPersonnelDAL _personnelDal;

        public PersonnelManager()
        {
            _personnelDal = new NinjectManager().CoreKernel.Get<IPersonnelDAL>();
        }

        public Personnel Select(int id)
        {
            return _personnelDal.Select(id);
        }

        public Personnel Select(string Tc)
        {
            return _personnelDal.Select(Tc);
        }

        public List<Personnel> Personnels(bool? isActive = true)
        {
            return _personnelDal.Personnels(isActive);
        }

        public ProcessResult Insert(Personnel newPatient)
        {
            ProcessResult result = ValidateModel(newPatient, false);
            //return _personnelDal.Insert(newPatient);
            return null;
        }

        private ProcessResult ValidateModel(Personnel personnel, bool upd)
        {
            ProcessResult processResult = new ProcessResult();

            if (!Extensions.VerifyTC(personnel.TcNo))
            {
                processResult.Errors.Add("Kimlik numarası doğrulanmadı");
            }
            if (personnel.TcNo.Trim().Length != 11)
            {
                processResult.Errors.Add("Kimlik numarası doğrulanamadı");
            }
            if (personnel.Name.Trim().Length == 0)
            {
                processResult.Errors.Add("İsim alanı boş bırakılamaz");
            }
            if (personnel.Surname.Trim().Length == 0)
            {
                processResult.Errors.Add("Soyadı alanı boş bırakılamaz");
            }
            if (personnel.Address.Trim().Length == 0)
            {
                processResult.Errors.Add("Adres alanı boş bırakılamaz");
            }
            if (personnel.CityId <= 0)
            {
                processResult.Errors.Add("Şehir alanı boş bırakılamaz");
            }
            if (personnel.CountryId <= 0)
            {
                processResult.Errors.Add("İlçe alanı boş bırakılamaz");
            }
            if (personnel.Phone.Length == 0)
            {
                processResult.Errors.Add("Telefon alanı boş bırakılamaz");
            }
            if (personnel.Mail.Length == 0)
            {
                processResult.Errors.Add("Mail alanı boş bırakılamaz");
            }
            if (personnel.DegreeId <= 0)
            {
                processResult.Errors.Add("Ünvan alanı boş bırakılamaz");
            }
            if (personnel.BirthDay > DateTime.Today)
            {
                processResult.Errors.Add("Doğum tarihi bugünün tarihinden sonra olamaz");
            }
            if (upd && personnel.Password.Length == 0)
            {
                processResult.Errors.Add("Şifre alanı boş bırakılamaz");
            }

            processResult.Result = processResult.Errors.Count == 0
                ? Extensions.BLLResult.Verified
                : Extensions.BLLResult.NotVerified;
            return processResult;
        }

        public bool Update(Personnel newInfoPersonnal)
        {
            return _personnelDal.Update(newInfoPersonnal);
        }

        public bool Delete(int id)
        {
            return _personnelDal.Delete(id);
        }
    }
}