using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortFolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TechnicalSkills()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Experience()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PersonalSkills()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Education()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Educations()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}