using System.Web.Http.Controllers;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Queue.Controllers;
using Queue.Models;

namespace Queue.Windsor
{
    internal class WebWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IClientService>().ImplementedBy<ClientService>().LifestyleScoped());
         
            container.Register(Classes
                .FromAssemblyContaining<ClientController>()
                .BasedOn<IHttpController>()
                .LifestyleScoped());
        }

    }
}