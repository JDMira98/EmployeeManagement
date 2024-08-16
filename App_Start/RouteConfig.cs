using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Ruta para manejar 404 - Not Found (opcional)
            routes.MapRoute(
                name: "NotFound",
                url: "NotFound",
                defaults: new { controller = "Error", action = "NotFound" }
            );

            // Ruta por defecto con validación de id numérico
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional },
                constraints: new { id = @"\d*" } // El id debe ser numérico o vacío (opcional)
            );

            // Ruta para manejar errores genéricos
            routes.MapRoute(
                name: "CatchAll",
                url: "{*url}",
                defaults: new { controller = "Error", action = "Index" }
            );
        }
    }
}
