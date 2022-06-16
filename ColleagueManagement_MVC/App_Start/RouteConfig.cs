﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ColleagueManagement_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Colleague", action = "AddNewColleague", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Address",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Address", action = "AddNewAddress", id = UrlParameter.Optional }
            );
        }
    }
}
