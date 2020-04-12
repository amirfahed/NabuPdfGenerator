using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace NabuPdfGenerator
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var a = new NabuPdfGenerator.Authorization.Authorization().Authorize("admin","pass");
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}