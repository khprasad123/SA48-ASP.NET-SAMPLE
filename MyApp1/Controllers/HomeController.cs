using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using MyApp1.Models;

namespace MyApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Debug.WriteLine("Debug okay!");
            Demo one = new Demo();
            one.name = "Hello";

         
            return View();
        }

        public ActionResult About()
        {
           
            Data two = new Data();
            two.Greeting = "Hello there";
            two.From = "This is Home controller";

            ViewData["msg1"] = two;

            ViewBag.msg = two.Greeting + " " + two.From;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult GetDepartment(string Department, string course)
        {
            Debug.WriteLine(Department + " " + course);


            return View("../Report/Department");
        }
        public ActionResult GetDepartment2(string Department, string course)
        {
            Debug.WriteLine(Department + "  inside  getDepartment2 " + course);


            return View("../Report/Department");
        }


        public ActionResult CreateDepartment(Entity entity)
        {
            Debug.WriteLine(entity.department + "  inside  CreateDepartment      " + entity.course);

            return View();
        }
    }
}