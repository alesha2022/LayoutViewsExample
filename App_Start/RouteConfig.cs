using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LayoutViewsExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();// -- Enabling Attribute Routing
            // routes.MapRoute(
            //    name: "Products",
            //    url: "{controller}/{action}/{productName}",
            //    defaults: new { }
            //);
            //routes.MapRoute(
            //    name: "Products",
            //    url: "products/getproductid/{productName}",
            //    defaults: new { controller = "Products", action = "GetProductId" }
            //);
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",          
            //    defaults: new { controller = "Home", action = "Index", id=UrlParameter.Optional }
            //);
        }
    }
}
