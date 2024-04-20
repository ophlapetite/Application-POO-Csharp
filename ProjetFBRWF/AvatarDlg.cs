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
    public partial class AvatarDlg : Form
    {
        private Image avatar;                                   // attribut de type image qui contiendra l'image sélectionnée
        private ImageList iml;     // attribut de type ImageList pour stocker les images à mettre dans la ListView listView1
        
        //constructeur par défaut
        public AvatarDlg()
        {
            InitializeComponent(); //initialisation des composants/controles de la fenêtre
            iml = new ImageList(); // création d'une nouvelle instance d'ImageList
            InitListeAvatar();      // appel à la méthode InitListeAvatar() de cette classe
        }


        //propriété sur l'attribut Avatar pour pouvoir transmettre l'image à Form1
        public Image Avatar
        {
            get { return this.avatar; }  //lecture seule
        }



        //Méthode qui remplit la listView1 avec des images
        public void InitListeAvatar()
        {
           //Ajout d'images des ressources dans l'attribut liste d'image
            iml.Images.Add(Properties.Resources.avatarpardefaut);
            iml.Images.Add(Properties.Resources.b1);
            iml.Images.Add(Properties.Resources.b2);
            iml.Images.Add(Properties.Resources.b3);
            iml.Images.Add(Properties.Resources.b4);
            iml.Images.Add(Properties.Resources.b5);
            iml.Images.Add(Properties.Resources.b6);
            iml.Images.Add(Properties.Resources.b7);
            iml.Images.Add(Properties.Resources.b8);
            iml.Images.Add(Properties.Resources.b9);
            iml.Images.Add(Properties.Resources.b10);
            iml.Images.Add(Properties.Resources.b11);
            iml.Images.Add(Properties.Resources.b12);
            iml.Images.Add(Properties.Resources.b13);
            iml.Images.Add(Properties.Resources.b14);
            iml.Images.Add(Properties.Resources.b15);
            iml.Images.Add(Properties.Resources.b16);
            iml.Images.Add(Properties.Resources.b17);
            iml.Images.Add(Properties.Resources.b18);
            iml.Images.Add(Properties.Resources.b19);
            iml.Images.Add(Properties.Resources.b20);
            iml.Images.Add(Properties.Resources.b21);
            iml.Images.Add(Properties.Resources.b22);
            iml.Images.Add(Properties.Resources.b23);
            iml.Images.Add(Properties.Resources.b24);
            iml.Images.Add(Properties.Resources.b25);
            //initialisation de la taille des images dans la liste d'image
            iml.ImageSize = new Size(100,100);

            //ajout de la liste d'image dans la ListView1
            listView1.LargeImageList = iml;

            //ajout d'un libellé à chaque image dans la listeView1
            for (int i=0;i<25;i++)
            {
                listView1.Items.Add(new ListViewItem("", i));

            }
        }



        //méthode évènement clic sur le bouton BValider
        private void Bvalider_Click(object sender, EventArgs e)
        {
            this.avatar =iml.Images[listView1.FocusedItem.Index];   //récupération de l'élément sélectionné dans la listeView et stockage dans l'attribut Avatar
            this.DialogResult = DialogResult.OK;                    // DialogResult de la fenêtre fixé à OK
            this.Close();                                           //fermeture de la fenêtre
        }

        
    }
}
