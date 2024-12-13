using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Exception_Handling.Controllers
{
    public class Simple_WayController : Controller
    {
        //Ref: https://www.codeproject.com/Articles/850062/Exception-handling-in-ASP-NET-MVC-methods-explaine
        // GET: /Simple_Way/
        public ActionResult Index()
        {
            try
            {
                int a = 0;
                int b = 2 / a;
                return View();
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }
    }
}
