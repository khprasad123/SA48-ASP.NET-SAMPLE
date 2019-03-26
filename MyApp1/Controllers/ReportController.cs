using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp1.Controllers
{
    public class ReportController : Controller
    {
     
       // [Route["/Report/Staff/2/Glendon]]
        public ActionResult Staff(int id,string name)
        {

            Debug.WriteLine(id + " " + name);
            return View();
        }
        // Answer for Question 3 Routing
            [Route("Department/{name}/")]
        public ActionResult Department(string name)
        {
            Debug.WriteLine(name);
            return View();
        }
        
    }
}