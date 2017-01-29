using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;
using Calcualtor.Controllers;
using Calcualtor.Models;
using Castle.MicroKernel;
using Castle.MicroKernel.Context;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Calcualtor.Windsor
{
    internal class WebWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ICounter>().ImplementedBy<Plus>().LifestyleScoped());
            container.Register(Component.For<ICounter>().ImplementedBy<Minus>().LifestyleScoped());
            container.Register(Component.For<ICounter>().ImplementedBy<Multiplication>().LifestyleScoped());
            container.Register(Component.For<ICounter>().ImplementedBy<Division>().LifestyleScoped());
            container.Register(Component.For<IResultFactory>().ImplementedBy<ColorResultFactory>().LifestyleScoped());
            container.Register(Component.For<IResultFactory>().ImplementedBy<NumberResultFactory>().LifestyleScoped());
            container.Register(Component.For<IResultFactory>().ImplementedBy<ParityResultFactory>().LifestyleScoped());

            container.Register(Component.For<IActionManager>()
                .ImplementedBy<ActionManager>().LifestyleScoped());


            container.Register(Component.For<IDictionary<string, ICounter>>()
                .UsingFactoryMethod(CreateOperations)
                .LifestyleScoped());

            container.Register(Component.For<IDictionary<string, IResultFactory>>()
                .UsingFactoryMethod(CreateResults)
                .LifestyleScoped());

            container.Register(Classes
                .FromAssemblyContaining<CalculateController>()
                .BasedOn<IHttpController>()
                .LifestyleScoped());
        }

        private IDictionary<string, ICounter> CreateOperations(IKernel kernel, CreationContext creationContext)
        {
            var operations = kernel.ResolveAll<ICounter>().ToDictionary(x => x.Type, x => x);
            return operations;
        }
        private IDictionary<string, IResultFactory> CreateResults(IKernel kernel, CreationContext creationContext)
        {
            var results = kernel.ResolveAll<IResultFactory>().ToDictionary(x => x.Type, x => x);
            return results;
        }
    }
}