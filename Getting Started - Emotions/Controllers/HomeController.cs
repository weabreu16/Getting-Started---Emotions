using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Getting_Started___Emotions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to contact emotion.";

            return View();
        }

        public ActionResult Meeting()
        {
            ViewBag.Message = "Meeting tutorial page.";

            return View();
        }
        public ActionResult Article()
        {
            ViewBag.Message = "Article tutorial page.";

            return View();
        }

        public ActionResult Profiles()
        {
            ViewBag.Message = "Profile tutorial page";

            return View();
        }

    }
}