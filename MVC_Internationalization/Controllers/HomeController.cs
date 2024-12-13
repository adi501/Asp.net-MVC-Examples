using MVC_Internationalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using MVC_Internationalization.Models;

namespace MVC_Internationalization.Controllers
{
    public class HomeController : Controller
    {
        //initilizing culture on controller initialization
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (Session["CurrentCulture"] != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("hi");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("hi");
            }
        }

        // changing culture
        public ActionResult ChangeCulture(string ddlCulture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hi");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("hi");

            Session["CurrentCulture"] = ddlCulture;
            return View("Index");
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                //TO DO:
            }
            return View();
        }
    }
}