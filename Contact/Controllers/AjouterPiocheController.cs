using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionPioches.Models
{
    public class AjouterPiocheController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AjouterPioche()
        {
            return View("AjouterPioche", new Pioche());
        }

        [HttpPost]
        public ActionResult AjouterPioche(Pioche p)
        {
            ManagerFBR mg = ManagerFBR.Instance; //singleton
            mg.AjoutPioche(p);
            return RedirectToAction("AfficherPioches", "AfficherPioches", "AfficherPioches");
        }
    }
}