using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Attribute_Routing.Controllers
{
    //ref: https://blogs.msdn.microsoft.com/webdev/2013/10/17/attribute-routing-in-asp-net-mvc-5/
    //ref:http://www.dotnettricks.com/learn/mvc/understanding-attribute-routing-in-aspnet-mvc
    [RoutePrefix("MyHome")]
    [Route("{action=About}")] //default action 
    public class Controller_level_attribute_routing_Controller : Controller
    {
        //new route: /MyHome/Index 
        public ActionResult Index()
        {
            return View();
        }

        //new route: /MyHome/About 
        public ActionResult About()
        {
            return View();
        }

        //new route: /MyHome/Contact 
        public ActionResult Contact()
        {
            return View();
        }
	}
}