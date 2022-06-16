using Autofac;
using Autofac.Integration.Mvc;
using ColleagueManagement_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColleagueManagement_MVC
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            //goal of autofac is to tell the container about the different components
            //and abstractions that you have in your project

            var builder = new ContainerBuilder();

            //Dependecy resolver for colleague
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SqlColleagueData>()
                .As<IColleague>()
                .InstancePerRequest();

            builder.RegisterType<ColleagueDbContext>().InstancePerRequest();

            //Dependecy resolver for Address model
            builder.RegisterType<SqlAddressData>()
                .As<IAddress>()
                .InstancePerRequest();

            builder.RegisterType<SqlDepartmentData>()
                .As<IDepartment>()
                .InstancePerRequest();

            builder.RegisterType<SqlDeptColleague>()
                .As<IDeptColleague>()
                .InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            

            

            



        }
    }
}