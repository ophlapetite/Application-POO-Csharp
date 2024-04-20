using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFBRWF
{
    public class Planneur : Equipement         //héritage de la classe Equipement
    {
        // constructeur par défaut
        public Planneur()                           //initialisation des attributs hérités de Equipement avec des valeurs par défaut
        {
            Nom = ""; Description = "";
            Rarete = categorieRarete.Autre;
            Prix = 0;
            DateParution = new DateTime(2017, 7, 1);
            Photo = null;

        }

        //constructeur avec paramètres
        public Planneur(string n, string d, int p, categorieRarete cat)
        {                                                //initialisation des attributs hérités de Equipement avec des valeurs passées en paramètre
            this.Nom = n;
            this.Description = d;
            this.Prix = p;
            this.DateParution = new DateTime(2017, 7, 1);
            this.Rarete = cat;
            this.Photo = null;
        }

        // surcharge de la méthode abstraite Saisie de la classe parent Equipement
        public override void Saisie()
        {
            Console.WriteLine("Entrez le nom du planneur");                 //affichage console
            string saisie = Console.ReadLine();                             // récupération de la saisie clavier utilisateur
            this.Nom = saisie;                                              // affectation de la valeur saisie à l'attribut nom via la propriété Nom
            Console.WriteLine("Entrez la description du planneur");
            saisie = Console.ReadLine();
            this.Description = saisie;
            Console.WriteLine("Entrez le prix du planneur");
            int saisie2 = (int.Parse(Console.ReadLine()));// saisie de type chaine de caractère string convertie en type entier
            this.Prix = saisie2;
            Console.WriteLine("Entrez la rareté du planneur");
            this.Rarete = (categorieRarete)Enum.Parse(typeof(categorieRarete), Console.ReadLine());// saisie de type chaine de caractère string convertie en type categorieRarete
            Console.WriteLine("Entrez la Date de Parution comme ceci: année, mois, jour");
            this.DateParution = (DateTime.Parse(Console.ReadLine()));// saisie de type chaine de caractère string convertie en type DateTime

        }
    }
}
