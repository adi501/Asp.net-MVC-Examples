using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Types_of_Action_Results.Controllers
{
    public class HomeController : Controller
    {

        //ref:http://www.dotnetfunda.com/articles/show/2831/different-ways-to-produce-output-in-aspnet-mvc-using-action-methods
        //ref:http://www.c-sharpcorner.com/UploadFile/dacca2/various-return-types-from-mvc-controller/
        //ref:http://www.careerride.com/view/what-are-the-different-return-type-controllers-action-method-supports-in-asp-net-mvc-3840.aspx
        //ref:https://www.eduonix.com/blog/web-programming-tutorials/learn-different-types-of-action-results-in-mvc/



        //Return View:This is a most common and very frequently used type. We see that we can pass eight parameters when we return the view. We can specify the view name explicitly or may not.
        public ActionResult Return_View_EXP()
        {
            return View();
        }

        //Return partial View:The concept of a partial view is very similar to the master page concept in Web Form applications. The partial view is nothing but  pagelet, that we can return from the controller and that merges with the main view and generates one concrete HTML page.
        public ActionResult Return_partial_View_EXP()
        {
            return View();
        }
        public PartialViewResult PartialDemo()
        {
            return PartialView();
        }

        //Redirect:This is equivalent to Response.redirect() or Server.Transfer() functions. It takes the URL path to be redirect , though we can use Response.Redirect() or Server.Transfer() in MVC too.
        public ActionResult Redirect_EXP()
        {
            return Redirect("http://www.allinoneweb.net/");
        }

        //Redirect To Action:Sometimes it is necessary to call another action after completion of one action, this is very similar to a function call in traditional function oriented programming or Object Oriented Programming. It may take 6 parameters. The first parameter is very simple, only action name.
        public ActionResult Redirect_To_Action_EXP()
        {
            return RedirectToAction("Redirect_To_Action_EXP1");
        }
        public ActionResult Redirect_To_Action_EXP1()
        {
            return View();
        }

        //Return content:This is useful when we want to return a small amount of strings from a controller/action. It takes three parameters. The first one is a simple string and the remaining two are strings with little information.
        public ActionResult Return_content_EXP()
        {
            return Content("This is useful when we want to return a small amount of strings from a controller/action. It takes three parameters. The first one is a simple string and the remaining two are strings with little information.");
        }

        //Return JSON:This is very useful when we don't want an entire HTML page but only want a value. Generally in AJAX-based single-page applications we do not load an entire page again and again but load fresh data from the DB using AJAX. In this scenario we can return only a JSON object and in the success function of jQuery ajax (let's assume we are using the jQuery library to implement AJAX) we can just manipulate data.
        public ActionResult Return_JSON_EXP()
        {
            UserData obj = new UserData() { UserName = "Test Name", Email = "test@test.com", Phone = "34234234" };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public class UserData
        {
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }

        //Return JavaScript:When we wanted to return a JavaScript string , we may use this function. It takes only one parameter, the string only.
        public ActionResult Return_JavaScript_EXP()
        {
            return View();
        }
        public JavaScriptResult Return_JavaScript_EXP1()
        {
            string a = "alert('this is alert')";
            return JavaScript(a);
        }

        //Return File:We are allowed to return a binary file if needed from a controller. It takes 6 parameters maximum.
        public FileResult Return_File_EXP()
        {
            string path = Server.MapPath("~/Views/Home/Return_File_EXP.cshtml");
            return File(path, "text/html");
        }
    }
}