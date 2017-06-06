﻿using System.Web.Mvc;
using System.Web.Routing;

namespace LojaVirtual.Web.V2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Nav", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}