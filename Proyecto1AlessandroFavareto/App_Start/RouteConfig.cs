using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proyecto1AlessandroFavareto
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Create Colaboladors",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Colaboladors", action = "Create", id = UrlParameter.Optional }

            );
            routes.MapRoute(
                name: "Crear Herramientas",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Herramientas", action = "Create", id = UrlParameter.Optional }
            );
        }
    }
}
