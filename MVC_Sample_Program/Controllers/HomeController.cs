using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sample_Program.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //ref:http://www.aspsnippets.com/Articles/ASPNet-MVC-Hello-World-Tutorial-with-Sample-Program-example.aspx
            ViewBag.Message = "Hi, This is my 1st MVC Project";
            return View();
        }
    }
}