using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Attribute_Routing.Controllers
{
    public class Action_level_attribute_routingController : Controller
    {
        [Route("users/{id:int:min(100)}")] //route: /users/100
        public ActionResult Index(int id)
        {
            //TO DO:
            return View();
        }

        [Route("users/about")] //route" /users/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        //route: /Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
	}
}