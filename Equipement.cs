using System;
using System.Drawing; //importation bibliothèque permettant de gérer objets de type Image
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFBRWF
{
    public enum categorieRarete { Atypique, Legendaire, Rare, Epique, Autre } // déclaration variable de type énuméré
   public  abstract class Equipement : IEquatable<Equipement>, IComparable<Equipement> // implémentation de deux interfaces
    {

        private string nom;                             // déclaration d'un attribut de type string représentant le nom de l'équipement
        private string description;                     // déclaration d'un attribut de type string représentant la description de l'équipement
        private categorieRarete rarete;                 // déclaration d'un attribut de type categorieRarete représentant la rareté de l'équipement
        private DateTime dateParution;                  // déclaration d'un attribut de type DateTime représentant la date de parution de l'équipement dans le jeu
        private int prix;                               // déclaration d'un attribut de type int représentant le prix de l'équipement
        private Image photo;                            // déclaration d'un attribut de type Image représentant la photo de l'équipement


        //Propriétés sur les attributs
        public categorieRarete Rarete
        {
            get { return this.rarete; }                     //Propriété en lecture
            set { this.rarete = value; }                    //Propriété en écriture
        }
        public string Nom
        {
            get { return nom; }                             //Propriété en lecture
            set { nom = value; }                            //Propriété en écriture
        }
        public string Description
        {
            get { return description; }                     //Propriété en lecture
            set { description = value; }                    //Propriété en écriture
        }
        public DateTime DateParution
        {
            get { return dateParution; }                    //Propriété en lecture
            set { dateParution = value; }                   //Propriété en écriture
        }
        public int Prix
        {
            get { return prix; }                            //Propriété en lecture
            set { prix = value; }
        }

        public Image Photo
        {
            get { return photo; }                           //Propriété en lecture
            set { photo = value; }                          //Propriété en écriture
        }


        //autres Propriétés

        public string RareteS
        {
            get { return Enum.Format(typeof(categorieRarete), this.rarete, "g"); }
            set { this.rarete = (categorieRarete)Enum.Parse(typeof(categorieRarete), value, false); }
        }



        //surcharge de la fonction ToString() de la classe object
        public override string ToString()
        {
            string s = "";
            s += "\n Nom : " + this.nom;
            s += "\n Description : " + this.description;
            s += "\n Rareté : " + this.RareteS;
            s += "\n Prix : " + this.prix;
            s += "\n Date de parution : " + this.dateParution;
            return s;

        }

        //Méthode qui affiche l'équipement dans la console
        public void Affiche()
        {
            Console.WriteLine(this.ToString());         //appel à la méthode ToString() de l'objet courant
        }




        // Méthode equals de la classe Equipement, surcharge de la méthode Equals() de la classe object
        public bool Equals(Equipement other)
        {
            if (other == null)
                return false;
            return (this.nom.Equals(other.nom)); //on fait appel à méthode Equals() de la classe String;
        }


        // implémentation de la méthode Equals() de l'interface IEquatable
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Equipement objAsEquipement = obj as Equipement; // on convertit notre objet de type object en type Equipement
            if (objAsEquipement == null)
                return false;
            return Equals(objAsEquipement); // fait appel à la méthode Equals() de Equipement
        }


        //Surcharge des opérateurs d'égalité == et !=

        public static bool operator ==(Equipement e1, Equipement e2)
        {
            if ((Object)e1 == null)
                return ((Object)e2 == null);
            return e1.Equals(e2);
        }

        public static bool operator !=(Equipement e1, Equipement e2)
        {
            return !(e1 == e2);
        }

        //implémentation de la méthode GetHashCode de l'interface IEquatable
        public override int GetHashCode()
        {
            return this.nom.GetHashCode();              //hashCode sur l'attribut nom
        }





        //implémentation de la méthode CompareTo() de l'interface IComparable
        public int CompareTo(Equipement other)
        {
            return string.Compare(this.nom, other.Nom); // appel à la méthode Compare() de la classe string
        }


        //surcharge des opérateurs de comparaison 
        public static bool operator >=(Equipement e1, Equipement e2)
        {
            if (e1.CompareTo(e2) < 0)               // appel à la méthode CompareTo() de la classe Equipement
                return false;
            else
                return true;
        }

        public static bool operator <=(Equipement e1, Equipement e2)
        {
            if (e1.CompareTo(e2) > 0)                   // appel à la méthode CompareTo() de la classe Equipement
                return false;
            else
                return true;
        }

        public static bool operator >(Equipement e1, Equipement e2)
        {
            if (e1.CompareTo(e2) < 0 | e1.CompareTo(e2) == 0)           // appel à la méthode CompareTo() de la classe Equipement
                return false;
            else
                return true;
        }

        public static bool operator <(Equipement e1, Equipement e2)
        {
            if (e1.CompareTo(e2) > 0 | e1.CompareTo(e2) == 0)           // appel à la méthode CompareTo() de la classe Equipement
                return false;
            else
                return true;
        }


        //Méthode abstraite de saisie utilisateur d'un équipement
            public abstract void Saisie();
    }
}
