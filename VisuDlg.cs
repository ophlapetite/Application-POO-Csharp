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
    public partial class VisuDlg : Form
    {
        private ManagerFBR mg;          //Attribut de type ManagerFBR


        //Constructeur avec paramètre ManagerFBR fourni par Form1
        public VisuDlg(ManagerFBR m)
        {
            InitializeComponent(); //Initialisation des composants/contrôles de la fenêtre
            this.mg=m;  
            initArbre();           //appel à la méthode InitArbre() de cette classe

        }


        //Méthode permettant d'initilaiser le composant TreeView ArbreSkins
        public void initArbre()
        {
            if (RBSkin.Checked == true)         // si le radioButton RBSkin est coché
            {
                foreach (categorieRarete cat in Enum.GetValues(typeof(categorieRarete)))  //on parcours les valeurs de Categorie Rarete
                {
                    TreeNode nd = new TreeNode(cat.ToString());  //On crée un noeud avec la valeur de categorieRarete
                    LesSkins li = mg.Ls.GetByRarete(cat);       //On récupère la liste des skins de la rareté correspondante
                    foreach (Skin sk in li.Liste)               //on parcours cette liste de skins
                    {
                        TreeNode na = new TreeNode(sk.Nom);     // on crée un noeud avec le nom de chaque skin
                        nd.Nodes.Add(na);                       //on ajoute les noeuds à l'arbre
                    }
                    ArbreSkins.Nodes.Add(nd);               //on ajoute les noeuds de rareté à l'arbre
                }
            }
            if (RBPioche.Checked == true)
            {
                foreach (categorieRarete cat in Enum.GetValues(typeof(categorieRarete)))
                {
                    TreeNode nd = new TreeNode(cat.ToString());
                    LesPioches li = mg.Lpi.GetByRarete(cat);
                    foreach (Pioche p in li.Liste)
                    {
                        TreeNode na = new TreeNode(p.Nom);
                        nd.Nodes.Add(na);
                    }
                    ArbreSkins.Nodes.Add(nd);
                }
            }
            if (RBPlanneur.Checked == true)
            {
                foreach (categorieRarete cat in Enum.GetValues(typeof(categorieRarete)))
                {
                    TreeNode nd = new TreeNode(cat.ToString());
                    LesPlanneurs lp = mg.Lpa.GetByRarete(cat);
                    foreach (Planneur p in lp.Liste)
                    {
                        TreeNode na = new TreeNode(p.Nom);
                        nd.Nodes.Add(na);
                    }
                    ArbreSkins.Nodes.Add(nd);
                }
            }
        }


        //Méthode évènement équipement sélectionné dans l'arbre
        private void ArbreSkins_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nd = e.Node;                   //on récupère le noeud sélectionné
            if (nd.Level > 0)                       // signifie qu'un noeud équipement est selectionné ( et pas une rareté)
            {
                if (RBSkin.Checked == true)         // si le RadioButton RBSkin est coché 
                {
                    Skin sk = this.mg.Ls.GetByNom(nd.Text);             //on récupère le skin au nom correspondant
                    Edition.Text = sk.ToString();                       //on affiche les informations de ce skin dans la RichTextBox Edition
                    Photo.Image = sk.Photo.GetThumbnailImage(Photo.Width, Photo.Height, null, IntPtr.Zero); // On affiche l'image de ce skin dans la PictureBox Photo
                }
                if (RBPioche.Checked == true)
                {
                    Pioche p = this.mg.Lpi.GetByNom(nd.Text);
                    Edition.Text = p.ToString();
                    Photo.Image = p.Photo.GetThumbnailImage(Photo.Width, Photo.Height, null, IntPtr.Zero);
                }

                if (RBPlanneur.Checked == true)
                {
                    Planneur p = this.mg.Lpa.GetByNom(nd.Text);
                    Edition.Text = p.ToString();
                    Photo.Image = p.Photo.GetThumbnailImage(Photo.Width, Photo.Height, null, IntPtr.Zero);
                }
            }


        }
        //Méthode évènement le radioButton RBSkin est coché
        private void RBSkin_CheckedChanged(object sender, EventArgs e)
        {   //réinitialisation du TreeView
            ArbreSkins.Nodes.Clear();
            initArbre();
        }

        //Méthode évènement le radioButton RBPioche est coché
        private void RBPioche_CheckedChanged(object sender, EventArgs e)
        {   //réinitialisation du TreeView
            ArbreSkins.Nodes.Clear();
            initArbre();
        }

        //Méthode évènement le radioButton RBPlanneur est coché
        private void RBPlanneur_CheckedChanged(object sender, EventArgs e)
        {   //réinitialisation du TreeView
            ArbreSkins.Nodes.Clear();
            initArbre();
        }
    }
}
