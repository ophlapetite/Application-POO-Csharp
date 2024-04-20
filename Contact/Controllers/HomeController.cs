using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contact.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Gestionnaire d'équipements du jeu Fortnite.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Page de contact du support.";

            return View();
        }
    }
}