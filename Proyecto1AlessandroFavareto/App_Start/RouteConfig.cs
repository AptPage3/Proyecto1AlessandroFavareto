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
                name: "index Colaboradors",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Colaboradors", action = "Index", id = UrlParameter.Optional }

            );
            routes.MapRoute(
                name: "Create Colaboradors",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Colaboradors", action = "Create", id = UrlParameter.Optional }

            );
            routes.MapRoute(
                name: "Ingreso Colaboradors",
                url: "{controller}/{action}",
                defaults: new { controller = "Colaboradors", action = "Ingresar", id = UrlParameter.Optional }

            );
            routes.MapRoute(
                name: "Crear Herramientas",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Herramientas", action = "Create", id = UrlParameter.Optional }
            );
            
        }
    }
}
