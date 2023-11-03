// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.DAL -- Extensions.cs

#region usings

using System;

#endregion

namespace HealthMonitoringSystem.Entity.Classes
{
    public partial class Extensions
    {
        public enum DataBaseResult
        {
            Success,
            AlreadyFound,
            Referanced,
            NotFound,
            Error,
            ServerDisable
        }
    }

    public static class ExtensionMethod
    {
        public static bool SameDate(this DateTime time, DateTime dateTime)
        {
            return time.Day == dateTime.Day && time.Month == dateTime.Month && time.Year == dateTime.Year;
        }

        public static int CanTimeByMin(this TimeSpan time)
        {
            DateTime now = DateTime.Now;
            TimeSpan time1 = new TimeSpan(now.Hour, now.Minute, now.Second);
            return (int) (time - time1).TotalMinutes;
        }
    }
}