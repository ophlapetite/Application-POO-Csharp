using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFBRWF
{
    public class LesPioches
    {
        private List<Pioche> liste;             // attribut de type List<> qui va contenir les Pioches de la collection


        //constructeur par défaut
        public LesPioches()
        {
            this.liste = new List<Pioche>();        //initialisation des attributs
        }

        //Propriétés sur les attributs
        public List<Pioche> Liste
        {
            get { return this.liste; }               // propriété en lecture
        }

        //Propriété qui renvoie le nombre de pioches dans la collection
        public int NbPioches
        {
            get { return this.liste.Count; }            // utilisation de la propriété Count de la classe List<>
        }

        // Méthode qui ajoute une pioche à la collection
        public void Ajoute(Pioche p)
        {
            this.liste.Add(p);                          //appel de la méthode Add() de la classe List<>
        }

        //Méthode qui supprime une pioche de la collection
        public void Supprime(string nom)
        {
            if (GetByNom(nom) != null)
                this.liste.Remove(GetByNom(nom));// appel à la méthode GetByNom() de la classe LesSkins pour retrouver le skin à supprimer et appel de la méthode Remove() de la classe List<>
        }


        //Méthode d'initialisation de la collection avec valeurs concrètes tirées du jeu
        public void Init()
        {
            Pioche p1 = new Pioche("Skull Sickle", "Skeleton's choice.", 1200, categorieRarete.Epique);
            p1.DateParution = (DateTime.Parse("2018,10,10"));
            p1.Photo = Properties.Resources.pioche1;
            Liste.Add(p1);
            Pioche p2 = new Pioche("Candy Axe", "Deck the walls with festive mayhem!", 1500, categorieRarete.Epique);
            p2.DateParution = (DateTime.Parse("2017,12,24"));
            p2.Photo = Properties.Resources.pioche2;
            Liste.Add(p2);
            Pioche p3 = new Pioche("Vision", "Unending gaze", 800, categorieRarete.Rare);
            p3.DateParution = (DateTime.Parse("2019,1,12"));
            p3.Photo = Properties.Resources.pioche3;
            Liste.Add(p3);
            Pioche p4 = new Pioche("Ice Breaker", "A great way to meet your fellow combatants", 500, categorieRarete.Atypique);
            p4.DateParution = (DateTime.Parse("2018,1,16"));
            p4.Photo = Properties.Resources.pioche4;
            Liste.Add(p4);
        }


        //Méthode qui renvoie un objet Pioche de la collection selon son nom
        public Pioche GetByNom(string n)
        {
            foreach (Pioche p in this.liste)
            {
                if (p.Nom == n)
                    return p;
            }
            return null;
        }


        // Méthode qui teste si la pioche en paramètre est contenu dans la collection
        public Boolean Exist(Pioche p)
        {
            if (Liste.Contains(p))
                return true;
            else
                return false;
        }


        //Méthode qui renvoie la collection des pioches d'une rareté donnée
        public LesPioches GetByRarete(categorieRarete cat)
        {
            LesPioches lp = new LesPioches();
            foreach (Pioche p in this.liste)
            {
                if (p.Rarete == cat)
                    lp.Ajoute(p);                       // appel à la méthode Ajoute() de la classe LesPioches
            }
            return lp;
        }



        //Méthode qui renvoie la collection des pioches selon un prix donné
        public LesPioches GetByPrix(int p)
        {
            LesPioches lp = new LesPioches();
            foreach (Pioche pi in this.liste)
            {
                if (pi.Prix == p)
                    lp.Ajoute(pi);                          // appel à la méthode Ajoute() de la classe LesPioches
            }
            return lp;

        }

        // Méthode d'affichage de la collection de Pioches dans la console
        public void Affiche()
        {
            if (this.NbPioches != 0)
                Console.WriteLine(this.ToString());         // appel à la méthode ToString() de la classe LesPioches
            else
                Console.WriteLine("La liste est vide.");    // message d'erreur console si liste vide
        }


        //Surcharge de la méthode ToString() de la classe object
        public override string ToString()
        {
            string s = "";
            foreach (Pioche p in this.liste)
            {
                s += "\n" + p.ToString();                       // appel à la méthode ToString() de la classe Pioche
            }

            return s;
        }



        //Méthode qui renvoie la collection de pioches triée par ordre alphabétique
        public LesPioches TriAlphabetique()
        {
            LesPioches lesPioches2 = new LesPioches();
            lesPioches2 = this;
            Pioche temp = new Pioche();
            int compt = lesPioches2.NbPioches;
            do
            {
                for (int i = 1; i < lesPioches2.NbPioches; i++)
                {
                    if ((lesPioches2.Liste[i - 1] >= lesPioches2.Liste[i]) == true)         // appel à la surcharge des opérateurs de comparaison de la classe Equipement
                    {
                        temp = lesPioches2.Liste[i];
                        lesPioches2.Liste[i] = lesPioches2.Liste[i - 1];
                        lesPioches2.Liste[i - 1] = temp;
                    }
                }
                compt--;
            } while (compt != 0);
            return lesPioches2;
        }


    }
}
