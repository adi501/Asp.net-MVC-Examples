using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["Message"] = "Hi, This is TempData example";
            return RedirectToAction("Index1");
        }
        public ActionResult Index1()
        {
            return View();
        }
    }
}