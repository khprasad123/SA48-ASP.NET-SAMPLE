using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp1.Controllers
{
    public class FileController : Controller
    {
        // GET: File

        public ActionResult Image()
        {
            var dir = Server.MapPath("/App_Data/Messi.png");
            return File(dir, "image/png");
                
         }
   
    }
}