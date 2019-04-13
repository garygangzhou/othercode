using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMApp
{
    public class IOC
    {
        public static void InitialUnity() {

            UnityContainer container = new UnityContainer();
            container.RegisterType<DALTools.IUnitOfWork, DALTools.UnitOfWork>(new ContainerControlledLifetimeManager());

            DependencyResolver.SetResolver(new UnityResolver(container));

        }

    }
}