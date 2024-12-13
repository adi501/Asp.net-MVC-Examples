using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Security.Principal;
using System.Web.Mvc.Filters;

namespace MVC_filters_Authorization_filters.Controllers
{
    public class ExampleController : Controller
    {
        public ActionResult login()
        {
           // FormsAuthentication.SetAuthCookie("adi", false);
            AuthenticationContext context;
            context.HttpContext.User.Identity.IsAuthenticated = true;
          string aa=  User.Identity.Name;
            string roles = string.Empty;
            roles ="admin";
            return RedirectToAction("Index");
            //return View();
        }
        // GET: Example
         [Authorize(Roles = "admin")] 
        public ActionResult Index()
        {
            return View();
        }

        // GET: Example/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Example/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Example/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Example/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Example/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Example/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Example/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
