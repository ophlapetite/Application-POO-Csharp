using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetFBRWF
{
    public class LesSkins
    {
        private List<Skin> liste;                   // attribut de type List<> qui va contenir les skins de la collection


        //constructeur par défaut
        public LesSkins()
        {                                       //initialisation des attributs 
            this.liste = new List<Skin>();
        }


        //Propriétés sur les attributs
        public List<Skin> Liste
        {
            get { return this.liste; }              // propriété en lecture
        }

        //Propriété qui renvoie le nombre de skins dans la collection
        public int NbSkins
        {
            get { return this.liste.Count; }   // utilisation de la propriété Count de la classe List<>
        }

        // Méthode qui ajoute un skin à la collection
        public void Ajoute(Skin s)
        {
            this.liste.Add(s);          //appel de la méthode Add() de la classe List<>
        }


        //Méthode qui supprime un skin de la collection
        public void Supprime(string nom)
        {
            if (GetByNom(nom) != null)
                this.liste.Remove(GetByNom(nom)); // appel à la méthode GetByNom() de la classe LesSkins pour retrouver le skin à supprimer et appel de la méthode Remove() de la classe List<>
        }


        //Méthode qui renvoie un objet Skin de la collection selon son nom
        public Skin GetByNom(string n)
        {
            foreach (Skin sk in this.liste)
            {
                if (sk.Nom == n)
                    return sk;
            }
            return null;
        }


        //Méthode qui renvoie la collection des skins d'une rareté donnée
        public LesSkins GetByRarete(categorieRarete cat)
        {
            LesSkins ls = new LesSkins();
            foreach (Skin sk in this.liste)
            {
                if (sk.Rarete == cat)
                    ls.Ajoute(sk);              // appel à la méthode Ajoute() de la classe LesSkins
            } 
                return ls;
        }

        //Méthode qui renvoie la collection des skins selon un prix donné
        public LesSkins GetByPrix(int p)
        {
            LesSkins ls = new LesSkins();
            foreach (Skin sk in this.liste)
            {
                if (sk.Prix == p)
                    ls.Ajoute(sk);              // appel à la méthode Ajoute() de la classe LesSkins
            }
            return ls;

        }

        //Méthode qui renvoie la collection de SkinsEvolutifs
        public LesSkins RechSkinsEvolutifs()
        {
            LesSkins ls = new LesSkins();
            foreach (Skin sk in Liste)
            {
                if (sk.GetType().Equals(typeof(SkinEvolutif))) // appel à la méthode Equals() de la classe Type
                    ls.Ajoute(sk);                             // appel à la méthode Ajoute() de la classe LesSkins
            }
            return ls;
        }


        // Méthode qui teste si le skin en paramètre est contenu dans la collection
        public Boolean Exist(Skin s)
        {
            if (Liste.Contains(s))              // appel à la méthode Contains() de la classe List<>
                return true;
            else
                return false;
        }


        // Méthode d'affichage de la collection de Skins dans la console
        public void Affiche()
        {   if(this.NbSkins!=0)
                Console.WriteLine(this.ToString());                     // appel à la méthode ToString() de la classe LesSkins
            else
                Console.WriteLine("La liste de skins est vide.");        // message d'erreur console si liste vide
        }

        //Surcharge de la méthode ToString() de la classe object
        public override string ToString()
        {
            string s = "";
            foreach (Skin sk in this.liste)
            {
                s += "\n" + sk.ToString();             // appel à la méthode ToString() de la classe Skin
            }

            return s;
        }

        //Méthode qui renvoie la collection de skins triée par ordre alphabétique
        public LesSkins TriAlphabetique()
        {
            LesSkins lesSkins2 = new LesSkins();
            lesSkins2 = this;
            Skin skintemp = new Skin();
            int compt = lesSkins2.NbSkins;
            do
            {
                for (int i = 1; i < lesSkins2.NbSkins; i++)
                {
                    if ((lesSkins2.Liste[i - 1] >= lesSkins2.Liste[i]) == true)     // appel à la surcharge des opérateurs de comparaison de la classe Equipement
                    {
                        skintemp = lesSkins2.Liste[i];
                        lesSkins2.Liste[i] = lesSkins2.Liste[i - 1];
                        lesSkins2.Liste[i - 1] = skintemp;
                    }
                }
                compt--;
            } while (compt != 0);
            return lesSkins2;
        }

        //Méthode d'initialisation de la collection avec valeurs concrètes tirées du jeu
        public void init()
        {
            Skin s1 = new Skin("Zero Absolu", "Jettez un froid chez vos adversaires.", 1200, categorieRarete.Rare);
            s1.DateParution = (DateTime.Parse("2018,1,7"));
            s1.Photo = Properties.Resources.image1;
            Liste.Add(s1);
            Skin s2 = new Skin("Assaillant Lapinesque", "l'effroi a un nouveau visage.", 1500, categorieRarete.Epique);
            s2.DateParution = (DateTime.Parse("2018,5,13"));
            s2.Photo = Properties.Resources.image2;
            Liste.Add(s2);
            Skin s3 = new Skin("Mitrailleuse", "une tenue de mitrailleuse atypique", 800, categorieRarete.Atypique);
            s3.DateParution = (DateTime.Parse("2019,9,30"));
            s3.Photo = Properties.Resources.image3;
            Liste.Add(s3);
            Skin s4 = new Skin("Homme-Poisson", " Il vient des profondeurs de... la réserve d'accesoires du studio B.", 2000,categorieRarete.Legendaire);
            s4.DateParution = (DateTime.Parse("2018,12,26"));
            s4.Photo = Properties.Resources.image4;
            Liste.Add(s4);
            SkinEvolutif s5 = new SkinEvolutif("Drift", "Journey into the unknown, and find your way to victory", 0, categorieRarete.Legendaire);
            s5.DateParution = (DateTime.Parse("2018,7,12"));
            s5.Photo = Properties.Resources.driftbase;
            s5.AjoutEvolution("Drift-stage1", Properties.Resources.driftevol1);
            s5.AjoutEvolution("Drift-stage2", Properties.Resources.driftevol2);
            s5.AjoutEvolution("Drift-stage3", Properties.Resources.driftevol3);
            s5.AjoutEvolution("Drift-stage4", Properties.Resources.driftevol4);
            Liste.Add(s5);
            Skin s6 = new Skin("Casse-Noisette", "Peut également se montrer casse-bonbons.", 2000, categorieRarete.Legendaire);
            s6.DateParution = (DateTime.Parse("2019,7,6"));
            s6.Photo = Properties.Resources.image5;
            Liste.Add(s6);
            
            SkinEvolutif s7 = new SkinEvolutif("Sparkle Supreme", "The supreme queen of sparkle.", 0, categorieRarete.Epique);
            s7.DateParution = (DateTime.Parse("2019,8,1"));
            s7.Photo = Properties.Resources.sparklebase;
            s7.AjoutEvolution("Disco Style", Properties.Resources.sparkleevol1);
            s7.AjoutEvolution("Starlite Style", Properties.Resources.sparkleevol2);
            s7.AjoutEvolution("Style #4", Properties.Resources.sparkleevol3);
            s7.AjoutEvolution("Bob Cut Style", Properties.Resources.sparkleevol4);
            Liste.Add(s7);


        }


        // Méthode d'initialisation aléatoire de la collection: crée n skins aléatoires et les ajoute à la liste de skins
        public void InitAleatoire(int n)
        {

            Random aleatoire = new Random(); //déclaration variable de type Random
            Random aleatoire2 = new Random();
            for (int i = 0; i < n; i++)
            {
                Skin s = new Skin();                // déclaration d'un objet de type Skin
                s.Nom = "skin" + i;
                s.Prix = aleatoire.Next(800, 1500); // génère prix aléatoire entre 800 et 1500 VBucks
                Array values = Enum.GetValues(typeof(categorieRarete)); // création d'un tableau contenant les différentes valeurs de categorieRarete
                s.Rarete = (categorieRarete)values.GetValue(aleatoire2.Next(values.Length));//génère valeur aléatoire dans tableau de raretés
                s.Description = "ceci est la description du " + s.Nom;
                Ajoute(s);

            }

        }
    }
}
