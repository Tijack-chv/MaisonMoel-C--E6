using Maison_moel.Entities;
using Maison_moel.Model;
using Maison_moel.vue;

namespace Maison_moel
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
            labelErreurEmail.Visible = false;
            labelErreurMdp.Visible = false;
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            //Enlève le fond blanc sur l'image
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;

            //Charger les images
            pictureBox1.Load("http://192.168.143.9/images/FOND_ACCUEIL.png");
            pictureBox2.Load("http://192.168.143.9/images/LOGO_TRANS.png");

            //Adapter l'image à la taille de la PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            //la PictureBox est en arrière-plan
            pictureBox1.SendToBack();
        }


        private void buttonConnecter_Click_1(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_mdp.Text == "" || txt_id.Text == "email" || txt_mdp.Text == "password") //revoir si verif de l'adresse mail et du nombre de caractère dans le mdp
            {
                if (txt_id.Text == "" || txt_id.Text == "email")
                {
                    labelErreurEmail.Visible = true;
                }
                else
                {
                    labelErreurEmail.Visible = false;
                }
                if (txt_mdp.Text == "" || txt_mdp.Text == "password")
                {
                    labelErreurMdp.Visible = true;
                }
                else
                {
                    labelErreurMdp.Visible = false;
                }
            }
            else
            {
                labelErreurEmail.Visible = false;
                labelErreurMdp.Visible = false;

                if (ModConnexion.ConnexionAdmin(txt_id.Text, txt_mdp.Text))
                {
                    Personne personne = new();
                    personne = ModConnexion.RecupererPersonne(txt_id.Text);

                    Accueil formaccueil = new();
                    formaccueil.Show();

                    this.Hide();
                }
            }

        }

      
    }
}
