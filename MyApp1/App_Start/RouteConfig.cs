using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyApp1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
   //------t
            routes.MapMvcAttributeRoutes();


            //for Routing Second Question--below
            routes.MapRoute(
             name: "Custom-1",
             url: "{controller}/{action}/{id}/{name}");


            ///for model binding ----1
            routes.MapRoute(
             name: "GetDepartment1",
             url: "{controller}/GetDepartment/{Department}/{course}"
             );

            //Routing First question

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "File", action = "Image", id = UrlParameter.Optional }
            );


       
        }
    }
}
