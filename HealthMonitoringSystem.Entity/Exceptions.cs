// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.Entity -- Exceptions.cs

#region usings

using System;

#endregion

namespace HealthMonitoringSystem.Entity
{
    [Serializable]
    public class Exceptions
    {
        public Exceptions(Exception exception)
        {
            HResult = exception.HResult.ToString();
            HelpLink = exception.HelpLink;
            InnerException = exception.InnerException.Message;
            Message = exception.Message;
            Source = exception.Source;
            StackTrace = exception.StackTrace;
            TargetSite = exception.TargetSite.ToString();

            InnerHResult = exception.InnerException.HResult.ToString();
            InnerHelpLink = exception.InnerException.HelpLink;
            InnerMessage = exception.InnerException.Message;
            InnerSource = exception.InnerException.Source;
            InnerStackTrace = exception.InnerException.StackTrace;
            InnerTargetSite = exception.InnerException.TargetSite.ToString();

            DateTime = DateTime.Now;
        }

        public int Id { get; set; }
        public string HResult { get; set; }
        public string HelpLink { get; set; }
        public string InnerException { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string TargetSite { get; set; }
        public string InnerHResult { get; set; }
        public string InnerHelpLink { get; set; }
        public string InnerMessage { get; set; }
        public string InnerSource { get; set; }
        public string InnerStackTrace { get; set; }
        public string InnerTargetSite { get; set; }
        public DateTime DateTime { get; private set; }
    }
}