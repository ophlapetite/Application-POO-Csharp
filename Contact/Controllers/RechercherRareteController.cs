using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionPioches.Models
{
    public class RechercherRareteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RechercherRarete()
        {
            ManagerFBR mg = ManagerFBR.Instance; //singleton
            List <Pioche> lp= new List<Pioche>();
            ViewBag.error = "0";
            String rarete = Request.QueryString["rareteRecherche"];
           
            if (rarete != null && rarete != "")
            {
                lp = mg.Lpi.GetByRarete((categorieRarete)Enum.Parse(typeof(categorieRarete), rarete, false)).Liste;
                if ( lp.Count== 0)
                    ViewBag.error = "1";
            }

            return View("RechercherRarete", lp);
        }
    }
}