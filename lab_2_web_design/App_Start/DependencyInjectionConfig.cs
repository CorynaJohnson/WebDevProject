﻿using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using lab_2_web_design.Data;
using lab_2_web_design.Services;

namespace lab_2_web_design.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void Register()
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Register your types, for instance:
            container.Register<IRepository, EfRepository>(Lifestyle.Scoped);
            container.Register<IUser, UserService>(Lifestyle.Scoped); //*********************************************************************

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}