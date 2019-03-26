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

            ///for model binding ----1
            routes.MapRoute(
              name: "GetDepartment1",
              url: "{controller}/{action}/{Department}/{course}"
              );

            //for Routing Second Question--below
            routes.MapRoute(
             name: "Custom-1",
             url: "{controller}/{action}/{id}/{name}");


            routes.MapRoute(
              name: "GetDepartment3",
              url: "{controller}/{action}"
              );

      
            //Routing First question

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


       
        }
    }
}
