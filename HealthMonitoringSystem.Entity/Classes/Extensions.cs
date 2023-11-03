// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Interfaces -- Extensions.cs

#region usings

using System;
using System.Runtime.Serialization;

#endregion

namespace HealthMonitoringSystem.Entity.Classes
{
    public partial class Extensions
    {
        [DataContract]
        public enum BLLResult
        {
            [EnumMember] Success, // 0
            [EnumMember] NotVerified, // 1
            [EnumMember] InnerException, // 2
            [EnumMember] Verified, // 3
            [EnumMember] AlreadyFound, // 4
            [EnumMember] Referanced, // 5
            [EnumMember] NotFound, // 6
            [EnumMember] Error, // 7
            [EnumMember] ServerDisable
        }

        public const string InnerException = "Belirlenemeyen bir hatadan dolayı işlem başarısız oldu.";
        public const string NotFound = "Kayıt bulunamadı";
        public const string SuccessProcess = "İşlem başarılı";
        public const string ServerDisable = "Sunucu ile bağlantı sağlanamadı. Sistem yöneticinize başvurunuz.";

        public static string AlreadyFoundString(string name)
        {
            return String.Format("{0} zaten kayıtlı", name);
        }

        public static bool VerifyTC(string no)
        {
            int a;
            int b;
            int c;
            no = no.Trim();
            if (no.Length != 11) return false;


            if (Int32.TryParse(no[0].ToString(), out a))
                if (a == 0) return false;
                else ;
            else
                return false;

            a = b = 0;
            for (int i = 0; i < 9; i += 2)
            {
                if (Int32.TryParse(no[i].ToString(), out c))
                {
                    a += c;
                }
                else
                {
                    return false;
                }
            }

            a *= 7;

            for (int i = 1; i < 8; i += 2)
            {
                if (Int32.TryParse(no[i].ToString(), out c))
                {
                    b += c;
                }
                else
                {
                    return false;
                }
            }

            a = (a - b)%10;

            if (Int32.TryParse(no[9].ToString(), out c))
                if (c != a) return false;
                else ;
            else
                return false;

            a = b = 0;

            for (int i = 0; i < 10; i++)
            {
                if (Int32.TryParse(no[i].ToString(), out c))
                {
                    a += c;
                }
                else
                {
                    return false;
                }
            }

            a %= 10;

            if (Int32.TryParse(no[10].ToString(), out c))
                if (c != a) return false;
                else ;
            else
                return false;

            return true;
        }

        public static BLLResult DataBaseResultToBLLResult(DataBaseResult dataBaseResult)
        {
            BLLResult result = BLLResult.Error;
            switch (dataBaseResult)
            {
                case DataBaseResult.Success:
                    result = BLLResult.Success;
                    break;
                case DataBaseResult.AlreadyFound:
                    result = BLLResult.AlreadyFound;
                    break;
                case DataBaseResult.Referanced:
                    result = BLLResult.Referanced;
                    break;
                case DataBaseResult.NotFound:
                    result = BLLResult.NotFound;
                    break;
                case DataBaseResult.Error:
                    result = BLLResult.Error;
                    break;
                case DataBaseResult.ServerDisable:
                    result = BLLResult.ServerDisable;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("dataBaseResult", dataBaseResult, null);
            }
            return result;
        }
    }
}