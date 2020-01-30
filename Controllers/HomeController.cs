using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyChoice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Buy Trees off the internet.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me if you want a special delivery. ";

            return View();
        }
    }
}