// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WinApp -- ExtensionsMethods.cs

#region usings

using System;

#endregion

namespace HealthMonitoringSystem.WinApp.Extensions
{
    public static class ExtensionsMethods
    {
        public static bool IsNull(this object o)
        {
            return o == null;
        }

        public static bool IsNotNull(this object o)
        {
            return o != null;
        }

        public static int? ToNullableInt32(this string s)
        {
            try
            {
                return Int32.Parse(s);
            }
            catch
            {
                return null;
            }
        }

        public static bool IsWeekend(this DateTime time)
        {
            return time.DayOfWeek == DayOfWeek.Sunday || time.DayOfWeek == DayOfWeek.Saturday;
        }
    }
}