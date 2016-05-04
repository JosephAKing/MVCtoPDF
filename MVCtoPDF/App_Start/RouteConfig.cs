using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCtoPDF
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "GeneratePDF",
                url: "{controller}/{action}/{parm}/{parm2}",
                defaults: new { parm = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{parm}",
                defaults: new { controller = "Home", action = "Index", parm = UrlParameter.Optional }
            );

        }
    }
}
