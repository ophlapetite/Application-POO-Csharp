using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionPioches.Models
{
    public class RechercherPiocheController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RechercherPioche()
        {
            ManagerFBR mg = ManagerFBR.Instance; //singleton
            Pioche p = null;

            ViewBag.error = "0";

            String nom = Request.QueryString["nomRecherche"];

            if(nom != null && nom!= "")
            {
                p = mg.Lpi.GetByNom(nom);
                if (p==null)
                    ViewBag.error = "1";
            }

            return View("RechercherPioche", p);
        }
    }
}