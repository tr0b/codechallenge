using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace codechallenge
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                /**
                 * 
                 * On default, the page will redirect the user to the User Projects page
                 * 
                 * **/
                name: "tbUserProjects",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "tbUserProjects", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
