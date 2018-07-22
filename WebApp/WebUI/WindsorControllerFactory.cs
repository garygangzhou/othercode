using Castle.Core.Resource;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebUI.Controllers;

namespace WebUI
{
    public class WindsorControllerFactory : System.Web.Mvc.DefaultControllerFactory
    {
        WindsorContainer container;
        public WindsorControllerFactory()
        {
            // Instantiate a container, taking configuration from web.config
            container = new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));

            // Also register all the controller types as transient
            //var controllerTypes = from t in Assembly.GetExecutingAssembly().GetTypes()
            //                      where typeof(System.Web.Mvc.IController).IsAssignableFrom(t)
            //                      select t;

            //foreach (Type t in controllerTypes)
            //    // container.AddComponent(t.FullName, t);
            //    container.Register(Castle.MicroKernel.Registration.Component.For<IController>().ImplementedBy<ProductsController>().LifeStyle.Transient );

            container.Register(Castle.MicroKernel.Registration.Classes.FromThisAssembly().BasedOn(typeof(IController)).WithServiceSelf().LifestyleTransient());
        }

        // Constructs the controller instance needed to service each request
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext,Type controllerType)
        {
            var controller = container.Resolve(controllerType);
            return (IController)controller;
        }
    }
}
