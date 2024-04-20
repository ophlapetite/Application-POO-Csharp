using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFBRWF
{
   public class ManagerFBR
    {
        private string nom;                     //attribut nom de type chaine de caractères
        private string mail;                    //attribut mail de type chaine de caractères
        private LesSkins ls;                    // attribut de type lesSkins : la collection des skins du managerFBR
        private LesPioches lpi;                 // attribut de type lesPioches : la collection des pioches du managerFBR
        private LesPlanneurs lpa;               // attribut de type lesPlanneurs : la collection des planneurs du managerFBR


        //propriété sur l'attribut nom
        public string Nom
        {
            get { return this.nom; }                    //propriété en lecture
            set { this.nom = value; }                   //propriété en écriture
        }

        // propriété sur l'attribut Mail
        public string Mail
        {
            get { return this.mail; }                   //propriété en lecture
            set { this.mail = value; }                  //propriété en écriture 
        }


       // Propriété sur l'attribut liste de Skins
        public LesSkins Ls
        {
            get { return this.ls; }                     //propriété en lecture     
        }

        // Propriété sur l'attribut liste de Pioches
        public LesPioches Lpi
        {
            get { return this.lpi; }                    //propriété en lecture
        }

        // Propriété sur l'attribut liste de planneurs
        public LesPlanneurs Lpa
        {
            get { return this.lpa; }                     //propriété en lecture
        }

        //Constructeur par défaut
        public ManagerFBR()                             //initialisation des différents attributs avec des valeurs par défaut
        {
            this.nom = "";
            this.mail = "";
            this.ls = new LesSkins();
            this.lpa = new LesPlanneurs();
            this.lpi = new LesPioches();
        }


        //**************************************************************************************************************************************



        // Méthode d'initialisation de la collection des Skins
        public void InitSkins()
        {
            Ls.init();                              // appel à la méthode init() de la classe LesSkins
        }

        // Méthode d'ajout d'un skin à la collection
        public void AjoutTenue(Skin s)
        {
            Ls.Ajoute(s);                          // appel à la méthode Ajoute() de la classe LesSkins
        }

        // Méthode de suppression d'un skin de la collection par son nom
        public void SupprimeTenue(string nom)
        {
            Ls.Supprime(nom);                       // appel à la méthode Supprime() de la classe LesSkins
        }

        // Méthode qui renvoie la liste des skins de la collection
        public List<Skin> GetAllSkins()
        {
            return Ls.Liste;                        // utilisation de la propriété Liste de la classe LesSkins
        }

        // Méthode de recherche d'un Skin par le nom
        public Skin GetSkinNom(string n)
        {
            return Ls.GetByNom(n);                  //appel à la méthode GetByNom() de la classe LesSkins
        }

        // Méthode de recherche des skins par leur rareté
        public LesSkins GetSkinsRarete(categorieRarete cat)
        {
            return Ls.GetByRarete(cat);             // appel à la méthode GetByRarete() de la classe LesSkins
        }

        // Méthode de recherche des skins par leur prix
        public LesSkins GetSkinsPrix(int p)
        {
            return Ls.GetByPrix(p);                 // appel à la méthode GetByPrix() de la classe LesSkins
        }

        //Méthode qui renvoie la collection de skins évolutifs
        public LesSkins RechSkinEvolutif()
        {
            return Ls.RechSkinsEvolutifs();         // appel à la méthode RechSkinsEvolutifs() de la classe LesSkins
        }

        // Méthode qui teste l'existence d'un skin dans la collection
        public Boolean SkinExist(Skin s)
        {
            return Ls.Exist(s);                     // appel à la méthode Exist() de la classe LesSkins
        }

        //Méthode qui renvoie la collection des skins triée par ordre alphabétique
        public LesSkins SkinTriAlphabetique()
        {
            return Ls.TriAlphabetique();            // appel à la méthode TriAlphabétique() de la classe LesSkins
        }



        //**************************************************************************************************************************************



        // Méthode d'initialisation de la collection des Pioches
        public void InitPioche()
        {
            Lpi.Init();                                         // appel à la méthode init() de la classe LesPioches
        }


        // Méthode d'ajout d'une pioche à la collection
        public void AjoutPioche(Pioche p)
        {
            Lpi.Ajoute(p);                                      // appel à la méthode Ajoute() de la classe LesPioches
        }

        //Méthode de suppression d'une pioche de la collection par son nom
        public void SupprimePioche(string nom)
        {
            Lpi.Supprime(nom);                                  // appel à la méthode Supprime() de la classe LesPioches
        }

        // Méthode qui renvoie la liste des pioches de la collection
        public List<Pioche> GetAllPioches()
        {
            return Lpi.Liste;                                   // utilisation de la propriété Liste de la classe LesPioches
        }

        // Méthode de recherche d'une pioche par le nom
        public Pioche GetPiocheNom(string n)
        {
            return Lpi.GetByNom(n);                             //appel à la méthode GetByNom() de la classe LesPioches
        }

        // Méthode de recherche des pioches par leur rareté
        public LesPioches GetPiocheRarete(categorieRarete cat)
        {
            return Lpi.GetByRarete(cat);                        // appel à la méthode GetByRarete() de la classe LesPioches
        }

        // Méthode de recherche des pioches par leur prix
        public LesPioches GetPiochePrix(int p)
        {
            return Lpi.GetByPrix(p);                            // appel à la méthode GetByPrix() de la classe LesPioches
        }

       

        // Méthode qui teste l'existence d'une pioche dans la collection
        public Boolean PiocheExist(Pioche p)
        {
            return Lpi.Exist(p);                                // appel à la méthode Exist() de la classe LesPioches
        }

        //Méthode qui renvoie la collection des pioches triée par ordre alphabétique
        public LesPioches PiocheTriAlphabetique()
        {
            return Lpi.TriAlphabetique();                       // appel à la méthode TriAlphabétique() de la classe LesPioches
        }



        //***************************************************************************************************************************************



        // Méthode d'initialisation de la collection des Planneurs
        public void InitPlanneur()
        {
            Lpa.Init();                                                    // appel à la méthode init() de la classe LesPlanneurs

        }
        // Méthode d'ajout d'un planneur à la collection
        public void AjoutPlanneur(Planneur p)
        {
            Lpa.Ajoute(p);                                                  // appel à la méthode Ajoute() de la classe LesPlanneurs
        }

        // Méthode de suppression d'un planneur de la collection par son nom
        public void SupprimePlanneur(string nom)
        {
            Lpa.Supprime(nom);                                              // appel à la méthode Supprime() de la classe LesPlanneurs
        }

        // Méthode qui renvoie la liste des planneurs de la collection
        public List<Planneur> GetAllPlanneurs()
        {
            return Lpa.Liste;                                               // utilisation de la propriété Liste de la classe LesPlanneur
        }

        // Méthode de recherche d'un planneur par le nom
        public Planneur GetPlanneurNom(string n)
        {
            return Lpa.GetByNom(n);                                         // appel à la méthode GetByNom() de la classe LesPlanneurs
        }

        // Méthode de recherche des planneurs par leur rareté
        public LesPlanneurs GetPlanneurRarete(categorieRarete cat)
        {
            return Lpa.GetByRarete(cat);                                    // appel à la méthode GetByRarete() de la classe LesPlanneurs
        }

        // Méthode de recherche des planneurs par leur prix
        public LesPlanneurs GetPlanneurPrix(int p)
        {
            return Lpa.GetByPrix(p);                                        // appel à la méthode GetByPrix() de la classe LesPlanneurs
        }



        // Méthode qui teste l'existence d'un planneur dans la collection
        public Boolean PlanneurExist(Planneur p)
        {
            return Lpa.Exist(p);                                            // appel à la méthode Exist() de la classe LesPlanneurs
        }

        //Méthode qui renvoie la collection des planneurs triée par ordre alphabétique
        public LesPlanneurs PlanneurTriAlphabetique()
        {
            return Lpa.TriAlphabetique();                                  // appel à la méthode TriAlphabétique() de la classe LesPlanneurs 
        }



        //*************************************************************************************************************************************




        // Méthode surchargée de la méthode ToString() de la classe object
        public override string ToString()
        {
            string s = "";
            s += "\n Nom : " + this.nom;
            s += "\n Mail : " + this.mail;
            s += "\n \n liste des skins: " +this.ls.ToString();             //appel à la méthode ToString() de la classe LesSkins
            s += "\n \n liste des pioches: " + this.lpi.ToString();         //appel à la méthode ToString() de la classe LesPioches
            s += "\n \n liste des planneurs: " + this.lpa.ToString();       //appel à la méthode ToString() de la classe LesPlanneurs
            return s;
        }

        // Méthode qui affiche les informations relatives au managerFBR dans la console
        public void Affiche()
        {
            Console.WriteLine(this.ToString());                     // affichage console, appel de la méthode ToString() de la classe ManagerFBR
        }

    }
}
