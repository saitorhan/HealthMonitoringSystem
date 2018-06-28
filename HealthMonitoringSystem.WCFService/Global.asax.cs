// Sait ORHAN -- 08.11.2014 -> HealthMonitoringSystem -- HealthMonitoringSystem.WCFService -- Global.asax.cs

#region usings

using Ninject;
using Ninject.Web.Common;

#endregion

namespace HealthMonitoringSystem.WCFService
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new ServiceModule());
        }
    }
}