using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marvles_of_Irving.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About The Marvels of Irving";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact The Marvels of Irving";

            return View();
        }
        public ActionResult Team()
        {
            ViewBag.Message = "The Marvels of Irving Robotics Club";

            return View();
        }

        public ActionResult Coaches()
        {
            ViewBag.Message = "The Marvels of Irving Coaches";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Image Gallery for Marvels of Irving";

            return View();
        }
    }
}