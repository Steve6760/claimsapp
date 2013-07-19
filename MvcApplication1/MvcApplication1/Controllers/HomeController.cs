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
            ViewBag.Message = "TouchStone application for claim management for GE Capital and Touchpoint.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Demo for setting up on Azure";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Submit your claim here";

            return View();
        }
    }
}
