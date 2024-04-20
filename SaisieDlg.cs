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
    public partial class SaisieDlg : Form
    {   //attributs de type équipement qui contiendront l'équipement saisi (ou non)
        private Skin sk;
        private Pioche pi;
        private Planneur pla;
        private Image ph;                         //photo de l'équipement
        private DateTime dp;                      //date création de l'équipement
        private String coché;                     // attribut pour spécifier quel type d'équipement récupérer dans Form1

        private SkinEvolutif ske;
        private Image tempEvol;                  //photo des évolutions

        //constructeur par défaut
        public SaisieDlg()
        {
            InitializeComponent(); //initalisation des composants/contrôles de la fenêtre
            
            //création des nouvelles instances d'équipements
            this.sk = new Skin();
            this.pi = new Pioche();
            this.pla = new Planneur();
            ske = new SkinEvolutif();
            //initalisation des atributs image à null
            this.ph = null;
            this.tempEvol = null;
            //date de création de l'équipement par défaut définie sur la date d'aujourd'hui
            this.dp = DateTime.Now;
            //Initalisation du Text de la TextBox Date à la date d'aujourd'hui
            Date.Text = this.dp.ToString("dd-MM-yyyy");

            //Appel aux méthodes d'initialisation de la classe
            InitListeRarete();
            InitListeRareteE();
        }

        //propriété pour récupérer le skin dans Form1
        public Skin LeSkin
        {
            get { return this.sk; }                             //Propriété en lecture
        }

        //propriété pour récupérer la pioche dans Form1
        public Pioche LaPioche
        {
            get { return this.pi; }                             //Propriété en lecture
        }

        //propriété pour récupérer le planneur dans Form1
        public Planneur LePlanneur
        {
            get { return this.pla; }                             //Propriété en lecture
        }

        //Propriété pour récupérer le type d'équipement à ajouter dans Form1
        public String Coché
        {
            get { return this.coché; }                             //Propriété en lecture
        }


        //Méthode d'initialisation de la ComboBox ListeRarete
        public void InitListeRarete()
        {
            LRarete.Text="Rareté?";                                         // changement du texte du label LRarete
            ListeRarete.DataSource = Enum.GetValues(typeof(categorieRarete)); //récupération des valeurs de type CategorieRarete et ajout dans la ComboBox
        }


        //Méthode évènement clic sur le bouton BAnnuler
        private void BAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;                          // résultat de la fenêtre fixé à Cancel
            this.Close();                                                     //fermeture de la fenêtre
        }

        //Méthode évènement clic sur le bouton BValider
        private void BValider_Click(object sender, EventArgs e)
        {   if (RBSkin.Checked == true)                                  //si le RadioButton RBSkin est coché
            {
                sk.Photo = ph;                                              //on ajoute à notre attribut skin la photo de l'attribut ph
                sk.DateParution = dp;                                       //on ajoute à notre attribut skin la date de l'attribut dp
                coché = "Skin";                                             //on définit l'attribut coché sur Skin pour préciser que l'on envoie un objet de type skin
            }
            else
            { if (RBPioche.Checked == true)
                {
                    pi.Photo = ph;
                    pi.DateParution = dp;
                    coché = "Pioche";
                }
                else
                { pla.Photo = ph;
                  pla.DateParution = dp;
                    coché = "Planneur";
                }
             }
            this.DialogResult = DialogResult.OK;                             //resultat de la fenêtre fixé à OK
            this.Close();                                                    //fermeture de la fenêtre

        }


        //Evenement clic sur le bouton BParcourir
        private void BParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();          //création d'une nouvelle fenêtre de type OpenFileDialog
            DialogResult res = dlg.ShowDialog();                //affichage de la fenêtre et récupération de son résultat
            if(res==DialogResult.OK)                            //si le résultat de la fenêtre est OK
            {
                string fich = dlg.FileName;                     //on récuypère le nom du fichier 
                NomFich.Text = fich;                            // on affiche le nom du fichier dans la TextBox NomFich
                this.ph = Image.FromFile(fich);                 // on attribue à ph l'image récupérée
                PBPhoto.Image = this.ph.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height, null, IntPtr.Zero); //on affiche l'image dans la PictureBox PBPhoto
            }
        }


        //Méthode évènement valeur sélectionnée dans la ComboBox ListeRarete
        private void ListeRarete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RBSkin.Checked == true)                         // si le RadioButton RBSkin est coché
            {
                sk.Rarete = (categorieRarete)ListeRarete.SelectedItem;  //On récupère la valeur de rareté sélectionnée dans la comboBox et on l'affecte à l'attribut de type Skin
            }
            else
            {
                if (RBPioche.Checked == true)                   // si le RadioButton RBPioche est coché
                {
                    pi.Rarete = (categorieRarete)ListeRarete.SelectedItem;  //On récupère la valeur de rareté sélectionnée dans la comboBox et on l'affecte à l'attribut de type Pioche
                }
                else
                                                                 // si le RadioButton RBPlanneur est coché
                {
                    pla.Rarete = (categorieRarete)ListeRarete.SelectedItem;   //On récupère la valeur de rareté sélectionnée dans la comboBox et on l'affecte à l'attribut de type Planneur
                }
            }
            
        }


        //Méthode évènement valeur saisie dans la TextBox Nom
        private void Nom_TextChanged(object sender, EventArgs e)
        {
            if (RBSkin.Checked == true)         // si le RadioButton RBSkin est coché
            {
                sk.Nom = Nom.Text;              //On récupère le texte saisi dans la TextBox et on l'affecte à l'attribut nom du skin sk
            }
            else
            {
                if (RBPioche.Checked == true)
                {
                    pi.Nom = Nom.Text;
                }
                else
                {
                    pla.Nom = Nom.Text;
                }
            }
            
        }


        //Méthode évènement valeur saisie dans la TextBox Description
        private void Description_TextChanged(object sender, EventArgs e)
        {
            if (RBSkin.Checked == true)                 // si le RadioButton RBSkin est coché
            {
                sk.Description = Description.Text;      //On récupère le texte saisi dans la TextBox et on l'affecte à l'attribut description du skin sk
            }
            else
            {
                if (RBPioche.Checked == true)
                {
                    pi.Description = Description.Text;
                }
                else
                {
                    pla.Description = Description.Text;
                }
            }
            
        }

        //Méthode évènement valeur saisie dans la TextBox Prix
        private void Prix_TextChanged(object sender, EventArgs e)
        {
            if (RBSkin.Checked == true)                 // si le RadioButton RBSkin est coché
            {
                sk.Prix = int.Parse(Prix.Text);         //On récupère le texte saisi dans la TextBox et on l'affecte à l'attribut prix du skin sk après l'avoir convertit en entier
            }
            else
            {
                if (RBPioche.Checked == true)
                {
                    pi.Prix = int.Parse(Prix.Text);
                }
                else
                {
                    pla.Prix = int.Parse(Prix.Text);
                }
            }
            
        }

        //Méthode évènement valeur sélectionnée dans le DateTimePicker1
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy"); //remplissage de la textBox Date avec la date sélectionnée dans le DateTimePicker au format spécifié
            this.dp= dateTimePicker1.Value;                         // attribution de la valeur sélectionnée à l'attribut dp
        }



        //**************************************************************************************************************
        //partie saisie skin évolutif 
        

        //Initialisation de la ComboBox ListeRareteE
        public void InitListeRareteE()
        {
            ListeRareteE.DataSource = Enum.GetValues(typeof(categorieRarete));
        }


        //Evenement clic sur le bouton BParcourirE
        private void BParcourirE_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fich = dlg.FileName;
                TBPhoto.Text = fich;
                this.ph = Image.FromFile(fich);
                PBPhotoE.Image = this.ph.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height, null, IntPtr.Zero);
            }
        }

        //Evenement clic sur le bouton BAnnulerE
        private void BAnnulerE_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //Evenement clic sur le bouton BValiderE
        private void BValiderE_Click(object sender, EventArgs e)
        {
            sk = ske;                           // on attribue à l'objet Skin notre skin évolutif 
            sk.Photo = ph;                      //on attribue à sk la photo contenue dans ph
            sk.DateParution = dp;               //on attribue à sk la date contenue dans dp
            this.coché = "Skin";                //on définit l'attribut coché sur Skin pour spécifier que l'on renvoie un objet de type Skin
            this.DialogResult = DialogResult.OK;// résultat de la fenêtre fixé à OK
            this.Close();                       //Fermeture de la fenêtre
        }

        //Evenement clic sur le bouton BParcourirEvol
        private void BParcourirEvol_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fich = dlg.FileName;
                this.tempEvol = Image.FromFile(fich); //Stockage de l'image choisie pour l'évolution dans l'attribut tempEvol
                PBPhotoEvol.Image = this.tempEvol.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height, null, IntPtr.Zero); 
            }
        }

        //Evenement clic sur le bouton BAjouter
        private void BAjouter_Click(object sender, EventArgs e)
        {
            ske.AjoutEvolution(NomEvol.Text, tempEvol);         //Ajout d'une évolution à ske avec le text contenu dans la TextBox NomEvol et l'image contenue dans l'attribut tempEvol
            ListeEvol.Items.Add(NomEvol.Text);                  //Ajout du nom de l'évolution à la ListBox ListeEvol
        }

        //Evenement clic sur le bouton BEvolution
        private void BEvolution_Click(object sender, EventArgs e)
        {   //réinitialisation du Texte de la listBox, de l'attribut tempEvol et de la PictureBox PBPhotoEvol
            NomEvol.Text = null;
            tempEvol = null;
            PBPhotoEvol.Image = null;
        }


        //Méthode évènement valeur sélectionnée dans le DateTimePicker2
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateCreation.Text = dateTimePicker2.Value.ToString("dd-MM-yyyy");
            this.dp = dateTimePicker2.Value;
        }

        //Méthode évènement valeur saisie dans la TextBox NomE
        private void NomE_TextChanged(object sender, EventArgs e)
        {
            ske.Nom = NomE.Text;
        }

        //Méthode évènement valeur saisie dans la TextBox DescriptionE
        private void DescriptionE_TextChanged(object sender, EventArgs e)
        {
            ske.Description = DescriptionE.Text;
        }

        //Méthode évènement valeur saisie dans la TextBox PrixE
        private void PrixE_TextChanged(object sender, EventArgs e)
        {
            ske.Prix= int.Parse(PrixE.Text);
        }

        //Méthode évènement valeur sélectionnée dans la ComboBox ListeRareteE
        private void ListeRareteE_SelectedIndexChanged(object sender, EventArgs e)
        {
            ske.Rarete = (categorieRarete)ListeRareteE.SelectedItem;
        }

        
    }
}
