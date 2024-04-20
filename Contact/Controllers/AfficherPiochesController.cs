using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionPioches.Models
{
    public class AfficherPiochesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AfficherPioches()
        {
            ManagerFBR mg= ManagerFBR.Instance;                 //singleton
            return View("AfficherPioches", mg.Lpi.Liste);       //appel vue correspondante
        }
    }
}