using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OdeToFood.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            // Let's use AutoFac API and invoke the Container builder class
            ContainerBuilder builder = new ContainerBuilder();

            // now let's register our controllers,so AutoFac knows about them
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // besides regular MVC controller we also need to register Web Api controllers
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            // now let's instruct the Container Builder about the data type we need
            // 
            builder.RegisterType<InMemoryRestaurantData>()
                   .As<IRestaurantData>()
                   .SingleInstance();

            IContainer container = builder.Build();
            
            // Finally instruct the MVC how to resolve the dependency injection whenever it is needed
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            
            // Also we need to Instruct the Web API Framework how to resolve the dependency injection 
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //throw new NotImplementedException();
        }
    }
}