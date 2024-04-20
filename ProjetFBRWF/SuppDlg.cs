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
    public partial class SuppDlg : Form
    {
        private ManagerFBR mg;          //attribut de type ManagerFBR
        private string nom;             //atribut de type Nom qui contiendra le nom de l'équipement à supprimer

        //constructeur avec paramètre ManagerFBR donné par Form1
        public SuppDlg(ManagerFBR m)
        {
            InitializeComponent();      //initialisation des composants/contrôles de la fenêtre
            this.mg = m;        
            initLabel();                //appel à la méthode InitLabel() de cette classe
        }


        //Méthode qui va initialiser le label1 de la fenêtre
        public void initLabel()
        {
            if(RBSkin.Checked==true)                        //Si le RadioButton RBSkin est coché
            {
                label1.Text = "Entrez le nom du Skin à supprimer :"; //on change le texte du label1
            }
            if (RBPioche.Checked == true)
            {
                label1.Text = "Entrez le nom de la Pioche à supprimer :";
            }
            if (RBPlanneur.Checked == true)
            {
                label1.Text = "Entrez le nom du Planneur à supprimer :";
            }
        }

        //Méthode évènement valeur saisie dans RichTextBox1
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.nom = richTextBox1.Text;               // on affecte la valeur saisie dans la RichTextBox1 à l'attibut nom
        }


        //Méthode évènement clic sur le bouton BRech
        private void BRech_Click(object sender, EventArgs e)
        {
            if(RBSkin.Checked==true)                    //Si le RadioButton RBSkin est coché
            {
                if (mg.Ls.GetByNom(this.nom) != null)       //on cherche s'il existe un skin à ce nom dans la collection du manager
                {
                    richTextBox2.Text = mg.Ls.GetByNom(this.nom).ToString();    //On remplit la RichTextBox avec les informations du skin correspondant
                    Image i = mg.Ls.GetByNom(this.nom).Photo;                   //On récupère l'image du skin correspondant
                    pictureBox1.Image = i.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, null, IntPtr.Zero); //on affiche l'image dans la PictureBox1
                }
                else
                {       
                    richTextBox2.Text = "Il n'existe pas de skin à ce nom"; //sinon on affiche un message d'erreur dans la RichTextBox2
                    pictureBox1.Image = null;                               //On réinitialise l'image de la PictureBox
                }
            }
            if (RBPioche.Checked == true)
            {
                if (mg.Lpi.GetByNom(this.nom) != null)
                {
                    richTextBox2.Text = mg.Lpi.GetByNom(this.nom).ToString();
                    Image i = mg.Lpi.GetByNom(this.nom).Photo;
                    pictureBox1.Image = i.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, null, IntPtr.Zero);
                }
                else
                {
                    richTextBox2.Text = "Il n'existe pas de pioche à ce nom";
                    pictureBox1.Image = null;
                }
            }
            if (RBPlanneur.Checked == true)
            {
                if (mg.Lpa.GetByNom(this.nom) != null)
                {
                    richTextBox2.Text = mg.Lpa.GetByNom(this.nom).ToString();
                    Image i = mg.Lpa.GetByNom(this.nom).Photo;
                    pictureBox1.Image = i.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, null, IntPtr.Zero);
                }
                else
                {
                    richTextBox2.Text = "Il n'existe pas de planneur à ce nom";
                    pictureBox1.Image = null;
                }
            }
        }


        //Méthode évènement clic sur le bouton BValider
        private void BValider_Click(object sender, EventArgs e)
        {
            

            if (RBSkin.Checked == true)         //Si le RadioButton RBSkin est coché
            {
                mg.SupprimeTenue(this.nom);     // on fait appel à la méthode SupprimeTenue pour supprimer le Skin dont le nom est stocké dans l'attribut nom
                
            }
            if (RBPioche.Checked == true)
            {
                mg.SupprimePioche(this.nom);
                
            }
            if (RBPlanneur.Checked == true)
            {
                mg.SupprimePlanneur(this.nom);
                
            }

            this.DialogResult = DialogResult.OK;        //le résultat de la fenêtre est fixé à OK
            this.Close();                               // On ferme la fenêtre
        }

        //Méthode évènement clic sur le bouton BAnnuler
        private void BAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        //Méthode évènement le RadioButton RBSkin est coché
        private void RBSkin_CheckedChanged(object sender, EventArgs e)
        {   //on réinitialise les différents composants de la fenêtre
            initLabel();
            richTextBox2.Clear();
            richTextBox1.Clear();
            pictureBox1.Image = null;
        }

        //Méthode évènement le RadioButton RBPioche est coché
        private void RBPioche_CheckedChanged(object sender, EventArgs e)
        {   //on réinitialise les différents composants de la fenêtre
            initLabel();
            richTextBox2.Clear();
            richTextBox1.Clear();
            pictureBox1.Image = null;
        }

        //Méthode évènement le RadioButton RBPlanneur est coché
        private void RBPlanneur_CheckedChanged(object sender, EventArgs e)
        {   //on réinitialise les différents composants de la fenêtre
            initLabel();
            richTextBox2.Clear();
            richTextBox1.Clear();
            pictureBox1.Image = null;
        }
    }
}
