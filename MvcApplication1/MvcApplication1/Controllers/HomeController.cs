using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Steve App to support claim mgmt program for Touchpoint.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Claim App for Touchpoint";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Submit your claim here";

            return View();
        }
    }
}
