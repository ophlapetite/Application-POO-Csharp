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
    public partial class Form1 : Form
    {   private ManagerFBR mg;          // attribut de type ManagerFBR pour travailler sur les équipements d"un joueur et avoir les méthodes associées
        private ImageList imgList;      // attribut de type ImageList pour stocker les images à mettre dans la ListBox listePhotos
        
        
        //constructeur par défaut
        public Form1()
        {   
            InitializeComponent();                //initialisation des composants/contrôles de la fenêtre
            imgList =new ImageList();             //création nouvelle instance d'ImageList
            mg = new ManagerFBR();                //création nouvelle instance de ManagerFBR
            mg.Nom = "SuperToto";                 //attribution d'une valeur à l'attribut Nom du ManagerFBR
            mg.Mail = mg.Nom + "@gmail.com";      //attribution d'une valeur à l'attribut email du ManagerFBR
            mg.InitSkins(); // appel à la fonction InitSkin() de la classe ManagerFBR qui remplit automatiquement la collection des skins
            mg.InitPioche();  // appel à la fonction InitPioche() de la classe ManagerFBR qui remplit automatiquement la collection des pioches
            mg.InitPlanneur();  // appel à la fonction InitPlanneur() de la classe ManagerFBR qui remplit automatiquement la collection des planneurs
            InitListeRarete();                                 //appel à la méthode InitListeRarete() de Form1
            InitListeEquipements();                            //appel à la méthode InitListeEquipements() de Form1
            InitListePhotos();                                 //appel à la méthode InitListePhotos() de Form1
            InitProfil();                                      //appel à la méthode InitProfil() de Form1
            InitIcone();                                       //appel à la méthode InitIcone() de Form1
        }



    //Méthode qui va remplir la ComboBox ListeRarete
    public void InitListeRarete()
    {
        ListeRarete.DataSource = Enum.GetValues(typeof(categorieRarete));    //récupération des valeurs du type énuméré categorieRarete et ajout de celles-ci dans la comboBox
    }



    //Méthode qui va remplir la ListBox ListeEquipements
    public void InitListeEquipements()
        {
            ListeEquipements.Items.Clear();                //remise à zéro de la liste

            if (RBSkin.Checked == true)                    // si le RadioButton RBSkin est coché
            {
                foreach (Skin sk in mg.Ls.Liste)            // parcours de la liste des skins du manager
                {
                    ListeEquipements.Items.Add(sk.Nom);     // ajout du nom de chaque skin à la ListBox
                }
            }

            if (RBPioche.Checked == true)                    // si le RadioButton RBPioche est coché
            {
                foreach (Pioche p in mg.Lpi.Liste)           // parcours de la liste des pioches du manager
                {
                    ListeEquipements.Items.Add(p.Nom);      // ajout du nom de chaque pioche à la ListBox
                }
            }

            if (RBPlanneur.Checked == true)                  // si le RadioButton RBPlanneur est coché
            {
                foreach (Planneur p in mg.Lpa.Liste)         // parcours de la liste des planneurs du manager
                {
                    ListeEquipements.Items.Add(p.Nom);      // ajout du nom de chaque planneur à la ListBox
                }
            }
        }




    //Méthode qui remplit la listBox ListePhotos avec des Skins évolutifs
    public void InitListePhotosSE()
        {
            //remise à zéro de la listBox et de l'attribut ImageList
            listePhotos.Items.Clear();
            imgList.Images.Clear();

            foreach (Skin sk in mg.Ls.Liste)                    // parcours de la liste de skins du manager
            {
                if (sk is SkinEvolutif)                              // si le skin est de type skinEvolutif
                {
                    imgList.Images.Add(sk.Photo);                   //ajout de sa photo à la liste d'image
                    listePhotos.Items.Add(sk.Nom);              // ajout de son nom à la listBox

                    foreach (Image i in ((SkinEvolutif)sk).LPhotos)   // parcours de la liste de photos d'évolutions du skin
                    {
                        imgList.Images.Add(i);                        //ajout des photos de chaque évolution à la liste d'image

                    }
                    foreach (String n in ((SkinEvolutif)sk).LNoms)   // parcours de la liste de nom d'évolutions du skin
                    {
                        listePhotos.Items.Add(n);                  //ajout des noms de chaque évolution à la listBox

                    }
                }
            }

        }


        //Méthode qui remplit la listBox ListePhotos avec les images d'un type d'équipement
        public void InitListePhotos()
        {

            //remise à zéro de la listBox et de l'attribut ImageList
            listePhotos.Items.Clear();
            imgList.Images.Clear();

            if (RBSkin.Checked == true)                     // si le RadioButton RBSkin est coché
            {
                foreach (Skin sk in mg.Ls.Liste)            // parcours de la liste des skins du manager
                {
                    imgList.Images.Add(sk.Photo);           //ajout de la photo de chaque skin à la liste d'images
                    listePhotos.Items.Add(sk.Nom);          // ajout du nom de chaque skin à la ListeBox

                }
            }

            if (RBPioche.Checked == true)                   // si le RadioButton RBPioche est coché
            {
                foreach (Pioche p in mg.Lpi.Liste)          // parcours de la liste des pioches du manager
                {
                    imgList.Images.Add(p.Photo);            //ajout de la photo de chaque pioche à la liste d'images
                    listePhotos.Items.Add(p.Nom);           // ajout du nom de chaque pioche à la ListeBox

                }
            }

            if (RBPlanneur.Checked == true)                 // si le RadioButton RBPlanneur est coché
            {
                foreach (Planneur p in mg.Lpa.Liste)        // parcours de la liste des pioches du manager
                {
                    imgList.Images.Add(p.Photo);            //ajout de la photo de chaque pioche à la liste d'images
                    listePhotos.Items.Add(p.Nom);           // ajout du nom de chaque pioche à la ListeBox

                }
            }

            imgList.ImageSize = new Size(200, 100);         //definition de la taille des images dans ImageList
            listePhotos.ItemHeight = 100;                   // Définition de la hauteur des images dans ListePhotos
            listePhotos.DrawMode=DrawMode.OwnerDrawVariable;  // Paramètre DrawMode fixé à OwnerDrawVariable
        }

   
        //Méthode qui va dessiner les images dans la ListBox listePhotos
        private void ListePhotos_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            Point p = e.Bounds.Location;                //récupération de la position 
            if(e.Index<imgList.Images.Count)
            imgList.Draw(e.Graphics, p,e.Index);        // dessin de l'image ImageList
            
            
        }


        //Méthode évènement déclenché par le clic sur le bouton BTSkin qui va afficher les informations relatives à un type d'équipement
        private void BTSkin_Click(object sender, EventArgs e)
        {   
            if (RBSkin.Checked == true)             // si le RadioButton RBSkin est coché
            {
                Edition.Text = mg.Ls.ToString();        // remplissage de la RichTextBox Edition avec les informations de tous les skins
                //réinitialisation de la liste de photos (qui peut être remplie avec les skins évolutifs)
                InitListePhotos();
            }

            if (RBPioche.Checked == true)           // si le RadioButton RBPioche est coché
            {
                Edition.Text = mg.Lpi.ToString();       // remplissage de la RichTextBox Edition avec les informations de toutes les pioches
            }

            if (RBPlanneur.Checked == true)         // si le RadioButton RBPlanneur est coché
            {
                Edition.Text = mg.Lpa.ToString();       // remplissage de la RichTextBox Edition avec les informations de tous les planneurs
            }
           
        }

        //Méthode évènement déclenchée par le clic sur le bouton BESkin qui va afficher les informations relatives aux skins evolutifs
        private void BESkin_Click(object sender, EventArgs e)
        {   
            Edition.Text = mg.RechSkinEvolutif().ToString();  // remplissage de la RichTextBox Edition avec les informations de tous les skins évolutifs

            //réinitialisation de la listePhotos (qui est remplie avec les photos de tous les Skins)
            InitListePhotosSE();  //appel à la méthode InitListePhotosSE() qui remplit la listePhotos avec les photos des skins évolutifs
        }


        //Méthode évènement déclenchée par sélection dans la ComboBox ListeRarete
        private void ListeRarete_SelectedIndexChanged(object sender, EventArgs e)
        {
            categorieRarete cat = (categorieRarete)ListeRarete.SelectedItem;  // récupération de la rareté sélectionnée dans la liste


            if (RBSkin.Checked == true)                         // si le RadioButton RBSkin est coché
            {
                Edition.Text = mg.GetSkinsRarete(cat).ToString(); // affichage des skins de la rareté corespondante dans la RichtextBox Edition
            }

            if(RBPioche.Checked==true)                          // si le RadioButton RBPioche est coché
            {
                Edition.Text = mg.GetPiocheRarete(cat).ToString(); // affichage des pioches de la rareté corespondante dans la RichtextBox Edition
            }

            if (RBPlanneur.Checked == true)                        // si le RadioButton RBPlanneur est coché
            {
                Edition.Text = mg.GetPlanneurRarete(cat).ToString(); // affichage des planneurs de la rareté corespondante dans la RichtextBox Edition
            }
        }

       
        //Méthode évènement clic sur l'option ajouter du MenuStrip
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaisieDlg ssd = new SaisieDlg();                                     //création d'une nouvelle instance de fenêtre SaisieDlg
            DialogResult res = ssd.ShowDialog();                                 // affichage de la fenêtre et récupération de son paramètre DialogResult
            if (res == DialogResult.OK)                                          // si le résultat de la fenêtre renvoie OK
            {
                if (ssd.Coché == "Skin")                                         // si la propriété Coché de la fenêtre SaisieDlg est égale à Skin
                {
                    mg.Ls.Ajoute(ssd.LeSkin);                                    // récupération du skin de la propriété LeSkin de SaisieDlg et ajout à la collection du manager
                    InitListeEquipements();                                      // mise à jour de la listeEquipements
                    InitListePhotos();                                           // mise à jour de la listePhotos
                }
                else
                { if (ssd.Coché == "Pioche")                                     // si la propriété Coché de la fenêtre SaisieDlg est égale à Pioche
                    {
                        mg.Lpi.Ajoute(ssd.LaPioche);                             // récupération de la pioche de la propriété LaPioche de SaisieDlg et ajout à la collection du manager
                        InitListeEquipements();                                  // mise à jour de la listeEquipements
                        InitListePhotos();                                       // mise à jour de la listePhotos
                    }
                                                                                 // si la propriété Coché de la fenêtre SaisieDlg est égale à planneur
                    else
                    {
                        mg.Lpa.Ajoute(ssd.LePlanneur);                           // récupération du planneur de la propriété LePlanneur de SaisieDlg et ajout à la collection du manager
                        InitListeEquipements();                                  // mise à jour de la listeEquipements
                        InitListePhotos();                                       // mise à jour de la listePhotos
                    }
                }
            }
        }


        //Méthode évènement clic sur l'option LesEquipements du MenuStrip
        private void lesEquipementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisuDlg vsd = new VisuDlg(mg);          //création d'une nouvelle instance de fenêtre VisuDlg
            DialogResult res = vsd.ShowDialog();    // affichage de la fenêtre et récupération de son paramètre DialogResult
        }


        //Méthode évènement clic sur l'option modifier du MenuStrip
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajDlg md = new MajDlg(mg);                //création d'une nouvelle instance de fenêtre MajDlg
            DialogResult res = md.ShowDialog();       // affichage de la fenêtre et récupération de son paramètre DialogResult
        }

        //Méthode évènement clic sur l'option supprimer du MenuStrip
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppDlg sd = new SuppDlg(mg);               //création d'une nouvelle instance de fenêtre SuppDlg
            DialogResult res = sd.ShowDialog();         // affichage de la fenêtre et récupération de son paramètre DialogResult
            if (res==DialogResult.OK)                   // si le résultat de la fenêtre renvoie OK
            {
                InitListePhotos();                      // mise à jour de la listePhotos
                InitListeEquipements();                  // mise à jour de la listeEquipements
            }
        }


        //Méthode évènement déclenchée par sélection dans la ListBox ListeEquipements
        private void ListeEquipements_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = ListeEquipements.SelectedItem.ToString();                // récupération de la valeur sélectionnée 

            if (RBSkin.Checked == true)                                         // Si le RadioButton RBSkin est coché
            {
                Skin sk = mg.Ls.GetByNom(n);                                    // recherche du skin au nom correspondant
                if (sk != null)                                                 // si le skin existe
                {
                    Edition.Text = sk.ToString();                               // affichage des informations du skin dans la RichTextBox Edition
                    PhotoSkin.Image = sk.Photo.GetThumbnailImage(PhotoSkin.Width, PhotoSkin.Height, null, IntPtr.Zero); // Affichage de la photo du skin dans la PictureBox PhotoSkin
                }
            }

            if (RBPioche.Checked == true)                                         // Si le RadioButton RBPioche est coché
            {
                Pioche p = mg.Lpi.GetByNom(n);                                     // recherche de la pioche au nom correspondant
                if (p != null)                                                     // si la pioche existe
                {
                    Edition.Text = p.ToString();                                    // affichage des informations de la pioche dans la RichTextBox Edition
                    PhotoSkin.Image = p.Photo.GetThumbnailImage(PhotoSkin.Width, PhotoSkin.Height, null, IntPtr.Zero);      // Affichage de la photo de la pioche dans la PictureBox PhotoSkin
                }
            }

            if (RBPlanneur.Checked == true)                                     // Si le RadioButton RBPlanneur est coché
            {
                Planneur p = mg.Lpa.GetByNom(n);                                // recherche du planneur au nom correspondant
                if (p != null)                                                  // si le planneur existe
                {
                    Edition.Text = p.ToString();                                // affichage des informations du planneur dans la RichTextBox Edition
                    PhotoSkin.Image = p.Photo.GetThumbnailImage(PhotoSkin.Width, PhotoSkin.Height, null, IntPtr.Zero);     // Affichage de la photo du planneur dans la PictureBox PhotoSkin
                }
            }
        }


        // Méthode évènement le RadioButton RBSkin est coché
        private void RBSkin_CheckedChanged(object sender, EventArgs e)
        {
            Edition.Text = "";                      //réinitialisation RichTextBox Edition
            InitListeEquipements();                 // mise à jour de la ListeEquipements
            InitListePhotos();                      // mise à jour de la ListePhotos
            BESkin.Visible = true;                  // bouton BESkin "Skins Evolutifs" visible
            BTSkin.Text = "Tous les skins";         // changement du texte du bouton BTSkin
            PhotoSkin.Image = null;                 // réinitialisation de la pictureBox PhotoSkin
        }

        // Méthode évènement le RadioButton RBPioche est coché
        private void RBPioche_CheckedChanged(object sender, EventArgs e)
        {
            Edition.Text = "";                      //réinitialisation RichTextBox Edition
            InitListeEquipements();                 // mise à jour de la ListeEquipements
            InitListePhotos();                      // mise à jour de la ListePhotos
            BESkin.Visible = false;                 // bouton BESkin "Skins Evolutifs" non visible
            BTSkin.Text = "Toutes les pioches";     // changement du texte du bouton BTSkin
            PhotoSkin.Image = null;                 // réinitialisation de la pictureBox PhotoSkin
        }

        // Méthode évènement le RadioButton RBPlanneur est coché
        private void RBPlanneur_CheckedChanged(object sender, EventArgs e)
        {
            Edition.Text = "";                  //réinitialisation RichTextBox Edition
            InitListeEquipements();             // mise à jour de la ListeEquipements
            InitListePhotos();                  // mise à jour de la ListePhotos
            BESkin.Visible = false;             // bouton BESkin "Skins Evolutifs" non visible
            BTSkin.Text = "Tous les planneurs"; // changement du texte du bouton BTSkin
            PhotoSkin.Image = null;             // réinitialisation de la pictureBox PhotoSkin
        }

        //*******************************************************************************************************
        //Partie TabPage Profil


        //Méthode qui initalise la tabPage2
        public void InitProfil()
        {
            //initialisation PictureBox profil
            Image i = Properties.Resources.avatarpardefaut;             //récupération de l'image par défaut pour l'avatar dans les ressources
            PBAvatar.Image=i.GetThumbnailImage(i.Width, i.Height, null, IntPtr.Zero); //affichage de l'image dans la PictureBox PBAvatar
            
            TBNom.Text= mg.Nom;             //Remplissage de la RichTextBox TBNom avec le nom du manager
            TBEmail.Text =mg.Mail;          //Remplissage de la RichTextBox TBEmail avec le mail du manager
        }
         

        //Méthode qui initialise l'icone associée à la TabPage2
        public void InitIcone() { 
            ImageList imageList1 = new ImageList();             //création d'une nouvelle liste d'image
            imageList1.Images.Add("key1", PBAvatar.Image);      // ajout de l'image identique à celle placée dans la PictureBox PBAvatar et son identifiant key1
            tabControl1.ImageList = imageList1;                 //ajout de la liste d'image au TabControl1
            tabPage2.ImageKey = "key1";                         //Ajout de l'image icone d'identifiant key1 à tabPage2
        }

        //Méthode évènement clic sur le bouton button1 "changer d'avatar"
        private void button1_Click(object sender, EventArgs e)
        {
            AvatarDlg ad = new AvatarDlg();                       // création d'une nouvelle instance de la fenetre AvatarDlg
            DialogResult res = ad.ShowDialog();                   // affichage de la fenêtre et récupération de son paramètre DialogResult
            if (res == DialogResult.OK)                           // si le résultat de la fenêtre renvoie OK
            {
                PBAvatar.Image = ad.Avatar;                       //récupération de l'image contenue dans la propriété Avatar de AvatarDlg et affichage dans la PictureBox PBAvatar
                InitIcone();                                      //mise à jour de l'icone
            }
        }

        
    }
}
