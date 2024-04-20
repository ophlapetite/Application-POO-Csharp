using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFBRWF
{
    public partial class MajDlg : Form
    {
        private ManagerFBR mg;              //attribut de type ManagerFBR pour travailler sur les collections d'équipements
       
        
        //constructeur avec paramètre
        public MajDlg(ManagerFBR m) //récupération du paramètre managerFBR de Form1
        {
            InitializeComponent(); //initalisation des composants/contrôles de la fenêtre
            this.mg = m;
            initGrille();           //appel à la méthode InitGrille() de cette classe
        }



        //Méthode d'initialisation du composant DataGridView
        public void initGrille()
        {
            if (RBSkin.Checked == true)                 //si le bouton RBSkin est coché
            {
                // création des colonnes
                DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn DateParution = new DataGridViewTextBoxColumn();
                DataGridViewComboBoxColumn Rarete = new DataGridViewComboBoxColumn();
                DataGridViewComboBoxColumn Evolutions = new DataGridViewComboBoxColumn();
                DataGridViewCheckBoxColumn Evolutif = new DataGridViewCheckBoxColumn();
                DataGridViewImageColumn Image = new DataGridViewImageColumn();

                //paramétrage des colonnes
                Description.HeaderText = "Description"; // texte de la colonne 
                Description.Name = "Description"; // nom interne
                Description.ReadOnly = true; // non modifiable

                Nom.HeaderText = "Nom";
                Nom.Name = "Nom";
                Nom.ReadOnly = true;

                Prix.HeaderText = "Prix";
                Prix.Name = "Prix";
                Prix.ReadOnly = false; // modifiable

                DateParution.HeaderText = "Date de Parution";
                DateParution.Name = "DateParution";
                DateParution.ReadOnly = true;

                Evolutif.HeaderText = "Evolutif ?";
                Evolutif.Name = "Evolutif";
                Evolutif.ReadOnly = true;

                Image.HeaderText = "Photo";
                Image.Name = "Image";
                Image.ReadOnly = true;

                Evolutions.HeaderText = "Evolutions";
                Evolutions.Name = "Evolutions";

                Rarete.HeaderText = "Rareté";
                Rarete.Name = "Rarete";
                Rarete.DataSource = Enum.GetNames(typeof(categorieRarete)); //remplissage de la comboBoxColumn avec les valeurs de CategorieRarete (sous forme string)
                Rarete.ReadOnly = false; //modifiable


                //ajout des colonnes au dataGridView
                Grille.Columns.AddRange(new DataGridViewColumn[] { Nom, Description, Prix, DateParution, Rarete, Evolutif, Evolutions, Image });
                
                //ajout du nombre de lignes en fonction du nombre de skins dans la liste
                Grille.Rows.Add(mg.Ls.Liste.Count);

                //on démarre à la ligne i=0
                int i = 0;
                foreach (Skin sk in mg.Ls.Liste)
                {   

                    //ajout des informations du skin dans les colonnes correspondantes 
                    Grille.Rows[i].Cells["Description"].Value = sk.Description; 
                    Grille.Rows[i].Cells["Nom"].Value = sk.Nom;
                    Grille.Rows[i].Cells["Prix"].Value = sk.Prix;
                    Grille.Rows[i].Cells["DateParution"].Value = sk.DateParution.ToString("dd/MM/yyyy");
                    Grille.Rows[i].Cells["Rarete"].Value = sk.RareteS;
                    Grille.Rows[i].Cells["Image"].Value = sk.Photo.GetThumbnailImage(40, 30, null, IntPtr.Zero);

                    //si le skin est de type SkinEvolutif
                    if (sk is SkinEvolutif)
                    {
                        Grille.Rows[i].Cells["Evolutif"].Value = true;     //on coche la case Evolutif 
                        DataGridViewComboBoxCell cc = new DataGridViewComboBoxCell();  //création d'une nouvelle cellule de type ComboBox 
                        cc.DataSource = ((SkinEvolutif)sk).LNoms;                   //ajout de la liste des noms d'évolutions à la comboBox
                        Grille.Rows[i].Cells["Evolutions"] = cc;                    // ajout de la comboBoxCell à la cellule du tableau
                    }
                    else
                    //le skin n'est pas de type SkinEvolutif
                    {
                        Grille.Rows[i].Cells["Evolutif"].Value = false;         // on ne coche pas la case Evolutif 
                    }
                    i++; //on incrémente l'index de la ligne
                }
            }

            if(RBPioche.Checked==true)                          //si le bouton RBPioche est coché
            {
                // création des colonnes
                DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn DateParution = new DataGridViewTextBoxColumn();
                DataGridViewComboBoxColumn Rarete = new DataGridViewComboBoxColumn();
                DataGridViewImageColumn Image = new DataGridViewImageColumn();

                //paramétrage des colonnes
                Description.HeaderText = "Description"; // texte de la colonne 
                Description.Name = "Description"; // nom interne
                Description.ReadOnly = true; // non modifiable

                Nom.HeaderText = "Nom";
                Nom.Name = "Nom";
                Nom.ReadOnly = true;

                Prix.HeaderText = "Prix";
                Prix.Name = "Prix";
                Prix.ReadOnly = false; // modifiable

                DateParution.HeaderText = "Date de Parution";
                DateParution.Name = "DateParution";
                DateParution.ReadOnly = true;

                Image.HeaderText = "Photo";
                Image.Name = "Image";
                Image.ReadOnly = true;

                Rarete.HeaderText = "Rareté";
                Rarete.Name = "Rarete";
                Rarete.DataSource = Enum.GetNames(typeof(categorieRarete));
                Rarete.ReadOnly = false;


                Grille.Columns.AddRange(new DataGridViewColumn[] { Nom, Description, Prix, DateParution, Rarete, Image });
                Grille.Rows.Add(mg.Lpi.Liste.Count);
                int i = 0;
                foreach (Pioche p in mg.Lpi.Liste)
                {
                    Grille.Rows[i].Cells["Description"].Value = p.Description;
                    Grille.Rows[i].Cells["Nom"].Value = p.Nom;
                    Grille.Rows[i].Cells["Prix"].Value = p.Prix;
                    Grille.Rows[i].Cells["DateParution"].Value = p.DateParution.ToString("dd/MM/yyyy");
                    Grille.Rows[i].Cells["Rarete"].Value = p.RareteS;
                    Grille.Rows[i].Cells["Image"].Value = p.Photo.GetThumbnailImage(40, 30, null, IntPtr.Zero);
                    i++;
                }
            }

            if(RBPlanneur.Checked==true)            //si le bouton RBPlanneur est coché
            {
                // création des colonnes
                DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn DateParution = new DataGridViewTextBoxColumn();
                DataGridViewComboBoxColumn Rarete = new DataGridViewComboBoxColumn();
                DataGridViewImageColumn Image = new DataGridViewImageColumn();

                //paramétrage des colonnes
                Description.HeaderText = "Description"; // texte de la colonne 
                Description.Name = "Description"; // nom interne
                Description.ReadOnly = true; // non modifiable

                Nom.HeaderText = "Nom";
                Nom.Name = "Nom";
                Nom.ReadOnly = true;

                Prix.HeaderText = "Prix";
                Prix.Name = "Prix";
                Prix.ReadOnly = false; // modifiable

                DateParution.HeaderText = "Date de Parution";
                DateParution.Name = "DateParution";
                DateParution.ReadOnly = true;

                Image.HeaderText = "Photo";
                Image.Name = "Image";
                Image.ReadOnly = true;

                Rarete.HeaderText = "Rareté";
                Rarete.Name = "Rarete";
                Rarete.DataSource = Enum.GetNames(typeof(categorieRarete));
                Rarete.ReadOnly = false;


                Grille.Columns.AddRange(new DataGridViewColumn[] { Nom, Description, Prix, DateParution, Rarete, Image });
                Grille.Rows.Add(mg.Lpa.Liste.Count);
                int i = 0;
                foreach (Planneur p in mg.Lpa.Liste)
                {
                    Grille.Rows[i].Cells["Description"].Value = p.Description;
                    Grille.Rows[i].Cells["Nom"].Value = p.Nom;
                    Grille.Rows[i].Cells["Prix"].Value = p.Prix;
                    Grille.Rows[i].Cells["DateParution"].Value = p.DateParution.ToString("dd/MM/yyyy");
                    Grille.Rows[i].Cells["Rarete"].Value = p.RareteS;
                    Grille.Rows[i].Cells["Image"].Value = p.Photo.GetThumbnailImage(40, 30, null, IntPtr.Zero);
                    i++;
                }
            }
        }

        

        //méthode évènement clic sur le bouton Valider
        private void Valider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //dialogResult de la fenetre fixé à OK
            this.Close();                               //fermeture de la fenêtre
        }

        

        //Méthode Evenement déclenché quand une cellule a été modifiée
        private void Grille_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int lig = e.RowIndex;           //récupération de l'indice de la ligne modifiée
            int col = e.ColumnIndex;        //récupération de l'indice de la colonne modifiée


            if (RBSkin.Checked == true)         //si le RadioButton RBSkin est coché
            {
                //récupération du skin à modifier
                Skin sk = mg.Ls.Liste[lig];
                switch (col)
                {
                    case 2:
                        sk.Prix = Int32.Parse(Grille.Rows[lig].Cells[col].Value.ToString()); //si la colonne prix est modifiée on récupère la valeur et on l'affecte au skin
                        break;
                    case 4:
                        sk.RareteS = Grille.Rows[lig].Cells[col].Value.ToString(); //si la colonne rareté est modifiée on récupère la valeur sélectionnée et on l'affecte au skin
                        break;
                        break;
                }
            }
            if(RBPioche.Checked==true)          //si le RadioButton RBPioche est coché
            {
                //récupération de la pioche à modifier
                Pioche p = mg.Lpi.Liste[lig];
                switch (col)
                {
                    case 2:
                        p.Prix = Int32.Parse(Grille.Rows[lig].Cells[col].Value.ToString()); //si la colonne prix est modifiée on récupère la valeur et on l'affecte a la pioche
                        break;
                    case 4:
                        p.RareteS = Grille.Rows[lig].Cells[col].Value.ToString();    //si la colonne rareté est modifiée on récupère la valeur sélectionnée et on l'affecte a la pioche 
                        break;
                }
            }

            if(RBPlanneur.Checked==true)          //si le RadioButton RBPlanneur est coché
            {
                //récupération du planneur à modifier
                Planneur p = mg.Lpa.Liste[lig];
                switch (col)
                {
                    case 2:
                        p.Prix = Int32.Parse(Grille.Rows[lig].Cells[col].Value.ToString());     //si la colonne prix est modifiée on récupère la valeur et on l'affecte au planneur
                        break;
                    case 4:
                        p.RareteS = Grille.Rows[lig].Cells[col].Value.ToString();       //si la colonne rareté est modifiée on récupère la valeur sélectionnée et on l'affecte au planneur
                        break;
                }
            }
        }


        //méthode évènement le RadioButton RBSkin est coché
        private void RBSkin_CheckedChanged(object sender, EventArgs e)
        {   
            //réinitialisation du DataGridView
            Grille.Columns.Clear();
            Grille.Rows.Clear();
            //remplissage de la grille
            initGrille();
        }


        //méthode évènement le RadioButton RBPioche est coché
        private void RBPioche_CheckedChanged(object sender, EventArgs e)
        {   //réinitialisation du DataGridView
            Grille.Columns.Clear();
            Grille.Rows.Clear();
            //remplissage de la grille
            initGrille();
        }


        //méthode évènement le RadioButton RBPlanneur est coché
        private void RBPlanneur_CheckedChanged(object sender, EventArgs e)
        {   //réinitialisation du DataGridView
            Grille.Columns.Clear();
            Grille.Rows.Clear();
            //remplissage de la grille
            initGrille();
        }
    }
}
