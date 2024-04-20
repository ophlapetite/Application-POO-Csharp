using System;
using System.Collections.Generic;
using System.Drawing;               //importation bibliothèque permettant de gérer objets de type Image
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFBRWF
{
    public class SkinEvolutif: Skin        //héritage de la classe Skin
    {
        private List<string> lNoms;           // déclaration d'un attribut de type liste de string représentant la liste des noms des évolutions
        private List<Image> lPhotos;          // déclaration d'un attribut de type liste d'Image représentant la liste des photos des évolutions


        //Constructeur par defaut 
        public SkinEvolutif()                //initialisation des attributs hérités de Skin et donc de Equipement avec des valeurs par défaut
        {
            this.Nom = "";
            this.lNoms = new List<string>();
            this.lPhotos = new List<Image>();
            this.Rarete = categorieRarete.Autre;
            this.Prix = 0;
            this.DateParution = new DateTime(2017, 7, 1);
        }

        public SkinEvolutif(string n, string d, int p, categorieRarete cat)
        {                                       //initialisation des attributs hérités de Equipement avec des valeurs passées en paramètre
            this.Nom = n;
            this.Description = d;
            this.Prix = p;
            this.DateParution = new DateTime(2017, 7, 1);
            this.Rarete = cat;
            this.Photo=null;
            this.lNoms = new List<string>();
            lNoms.Add(n);
            this.lPhotos = new List<Image>();
        }



        // Propriétés sur les attributs

        public List<string> LNoms
        {
            get { return this.lNoms; }                      //propriété en lecture
        }

        public List<Image> LPhotos
        {
            get { return lPhotos; }                         //propriété en lecture
        }


        //Surcharge de la méthode toString() de la classe parent Skin
        public override string ToString()
        {
            string s=" \n Liste des Evolutions : ";
            foreach (string snom in this.lNoms)
            {
                s += snom.ToString()+ " ";
            }
            return base.ToString() + s;                 //récupération du toString() de la classe Skin + ajout du ToString() redéfini à la suite
        }



        //Surcharge de la méthode saisie de la classe Skin
        public override void Saisie()
        {
            base.Saisie();                      // récupération de la méthode Saisie() de la classe Skin
            string saisie = ""; 
            while (saisie != "0")
            {
                Console.WriteLine("Entrez la liste des noms du Skin Evolutif, tapez 0 pour arrêter");
                saisie= Console.ReadLine();
                if (saisie != "0")
                    lNoms.Add(saisie);

            }
        }

        //Méthode d'ajout d'une évolution au skin évolutif
        public void AjoutEvolution(string n,Image p)
        {
            LNoms.Add(n);                           // ajout d'un nom à la liste des noms d'évolutions via la méthode Add() de la classe List<>
            LPhotos.Add(p);                         //ajout d'une photo à la liste des photos d'évolutions via la méthode Add() de la classe List<>
        }
    }
}
