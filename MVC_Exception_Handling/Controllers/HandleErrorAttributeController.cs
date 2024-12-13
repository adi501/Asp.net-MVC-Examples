using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Exception_Handling.Controllers
{
    public class HandleErrorAttributeController : Controller
    {
        //
        // GET: /HandleErrorAttribute/
        [HandleError()]
        [HandleError(ExceptionType = typeof(ArithmeticException), View = "Arthimetic")]
        [HandleError(ExceptionType = typeof(NotImplementedException), View = "Error1")]
        public ActionResult SomeError()
        {
            throw new Exception("test");
        }
	}
}