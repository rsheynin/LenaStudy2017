using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Castle.Windsor;
using Queue.Windsor;

namespace Queue
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ConfigureWindsor();
        }

        private static void ConfigureWindsor()
        {
            var container = new WindsorContainer()
                .Install(new WebWindsorInstaller());

            GlobalConfiguration.Configuration.DependencyResolver =
                new WindsorDependencyResolver(container);
        }
    }
}