using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPioches
{
     public class LesPlanneurs
    {

        private List<Planneur> liste;               // attribut de type List<> qui va contenir les planneurs de la collection


        //constructeur par défaut
        public LesPlanneurs()
        {
            this.liste = new List<Planneur>();      //initialisation des attributs
        }

        //Propriétés sur les attributs
        public List<Planneur> Liste
        {
            get { return this.liste; }               // propriété en lecture
        }


        //Propriété qui renvoie le nombre de planneurs dans la collection
        public int NbPlanneurs
        {
            get { return this.liste.Count; }            // utilisation de la propriété Count de la classe List<>
        }

        // Méthode qui ajoute un planneur à la collection
        public void Ajoute(Planneur p)
        {
            this.liste.Add(p);                          //appel de la méthode Add() de la classe List<>
        }


        //Méthode qui supprime un planneur de la collection
        public void Supprime(string nom)
        {
            if (GetByNom(nom) != null)
                this.liste.Remove(GetByNom(nom));// appel à la méthode GetByNom() de la classe LesSkins pour retrouver le skin à supprimer et appel de la méthode Remove() de la classe List<>
        }


        //Méthode d'initialisation de la collection avec valeurs concrètes tirées du jeu
        public void Init()
        {
            Planneur p1 = new Planneur("Sky Stripe", "Signature stripe glider", 500, categorieRarete.Atypique);
            p1.DateParution = (DateTime.Parse("2019,10,5"));
            //p1.Photo = Properties.Resources.planeur1;
            Liste.Add(p1);
            Planneur p2 = new Planneur("Magic Wings", "Soaring and spellbound.", 1200, categorieRarete.Epique);
            p2.DateParution = (DateTime.Parse("2018,11,15"));
            //p2.Photo = Properties.Resources.planeur2;
            Liste.Add(p2);
            Planneur p3 = new Planneur("Frostwing","Awoken from ageless slumber.",1500,categorieRarete.Legendaire);
            p3.DateParution = (DateTime.Parse("2018,9,19"));
            //p3.Photo = Properties.Resources.planeur3;
            Liste.Add(p3);
            Planneur p4 = new Planneur("Dark Glyph", "Indecipherable", 500, categorieRarete.Autre);
            p4.DateParution = (DateTime.Parse("2018,10,4"));
            //p4.Photo = Properties.Resources.planeur4;
            Liste.Add(p4);
        }

        //Méthode qui renvoie un objet Planneur de la collection selon son nom
        public Planneur GetByNom(string n)
        {
            foreach (Planneur p in this.liste)
            {
                if (p.Nom == n)
                    return p;
            }
            return null;
        }


        // Méthode qui teste si le planneur en paramètre est contenu dans la collection
        public Boolean Exist(Planneur p)
        {
            if (Liste.Contains(p))
                return true;
            else
                return false;
        }


        //Méthode qui renvoie la collection des planneurs d'une rareté donnée
        public LesPlanneurs GetByRarete(categorieRarete cat)
        {
            LesPlanneurs lp = new LesPlanneurs();
            foreach (Planneur p in this.liste)
            {
                if (p.Rarete == cat)
                    lp.Ajoute(p);                               // appel à la méthode Ajoute() de la classe LesPlanneurs
            }
            return lp;
        }

        //Méthode qui renvoie la collection des planneurs selon un prix donné
        public LesPlanneurs GetByPrix(int p)
        {
            LesPlanneurs lp = new LesPlanneurs();
            foreach (Planneur pl in this.liste)
            {
                if (pl.Prix == p)
                    lp.Ajoute(pl);                              // appel à la méthode Ajoute() de la classe LesPlanneurs
            }
            return lp;

        }

        // Méthode d'affichage de la collection de Planneurs dans la console
        public void Affiche()
        {
            if (this.NbPlanneurs != 0)
                Console.WriteLine(this.ToString());                 // appel à la méthode ToString() de la classe LesPlanneurs
            else
                Console.WriteLine("La liste est vide.");            // message d'erreur console si liste vide
        }


        //Surcharge de la méthode ToString() de la classe object
        public override string ToString()
        {
            string s = "";
            foreach (Planneur p in this.liste)
            {
                s += "\n" + p.ToString();                       // appel à la méthode ToString() de la classe Planneur
            }

            return s;
        }

        //Méthode qui renvoie la collection de planneurs triée par ordre alphabétique
        public LesPlanneurs TriAlphabetique()
        {
            LesPlanneurs lesPlanneurs2 = new LesPlanneurs();
            lesPlanneurs2 = this;
            Planneur temp = new Planneur();
            int compt = lesPlanneurs2.NbPlanneurs;
            do
            {
                for (int i = 1; i < lesPlanneurs2.NbPlanneurs; i++)
                {
                    if ((lesPlanneurs2.Liste[i - 1] >= lesPlanneurs2.Liste[i]) == true)   // appel à la surcharge des opérateurs de comparaison de la classe Equipement
                    {
                        temp = lesPlanneurs2.Liste[i];
                        lesPlanneurs2.Liste[i] = lesPlanneurs2.Liste[i - 1];
                        lesPlanneurs2.Liste[i - 1] = temp;
                    }
                }
                compt--;
            } while (compt != 0);
            return lesPlanneurs2;
        }

        
    }
}
