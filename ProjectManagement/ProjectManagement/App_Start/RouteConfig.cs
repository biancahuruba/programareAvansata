using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Project", 
            //    url: "Project/doanaction", 
            //    defaults: new { controller = "Project", action = "doanaction", name = UrlParameter.Optional });

            routes.MapRoute(
                name: "Projectalpha",
                url: "Project/{alpha}",
                defaults: new { controller = "Project", action = "hellouser", name = UrlParameter.Optional });

            routes.MapRoute(
               name: "Projectsearch",
               url: "Project/search/{alpha}",
               defaults: new { controller = "Project", action = "search", name = UrlParameter.Optional });


            routes.MapRoute(
                   name: "Default",
                   url: "{controller}/{action}/{id}",
                  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
               );

        }
    }
}
