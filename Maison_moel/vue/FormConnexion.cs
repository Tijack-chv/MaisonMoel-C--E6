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
            labelErreurPassword.Visible = false;
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.Load("http://192.168.143.9:8080/images/LOGO_TRANS.png");
            panelUnderComponent.BackColor = Color.FromArgb(120, 127, 127, 127);
            this.ControlBox = false;
        }


        private void buttonConnecter_Click_1(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBoxPassword.Text == "" || textBoxEmail.Text == "Adresse-email" || textBoxPassword.Text == "Mot de passe") //revoir si verif de l'adresse mail et du nombre de caractère dans le mdp
            {
                if (textBoxEmail.Text == "" || textBoxEmail.Text == "Adresse-email")
                {
                    labelErreurEmail.Visible = true;
                }
                else
                {
                    labelErreurEmail.Visible = false;
                }
                if (textBoxPassword.Text == "" || textBoxPassword.Text == "Mot de passe")
                {
                    labelErreurPassword.Visible = true;
                }
                else
                {
                    labelErreurPassword.Visible = false;
                }
            }
            else
            {
                labelErreurEmail.Visible = false;
                labelErreurPassword.Visible = false;
                
                if (ModConnexion.ConnexionAdmin(textBoxEmail.Text, textBoxPassword.Text))
                {
                    bool est_admin = false;
                    Personne personne = new();
                    personne = ModConnexion.RecupererPersonne(textBoxEmail.Text);
                    List<Admin> lesadmins = ModConnexion.RecupererAdmins();
                    foreach (Admin unadmin in lesadmins)
                    {
                        if (unadmin.IdPersonne == personne.IdPersonne)
                        {
                            est_admin = true;
                        }
                    }
                    FormHome Formcuisine = new(est_admin);
                    Formcuisine.Show();

                    this.Hide();
                }
            }

        }

        #region Placeholder
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Adresse-email")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Adresse-email";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Mot de passe")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Mot de passe";
            }
        }

        #endregion

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelExit_MouseHover(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.FromArgb(120, 127, 127, 127);
            labelExit.ForeColor = Color.Black;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            panelExit.BackColor = Color.Transparent;
            labelExit.ForeColor = Color.White;
        }

        private void buttonConnecter_MouseHover(object sender, EventArgs e)
        {
            buttonConnecter.BackColor = Color.FromArgb(255, 255, 235, 113);
        }

        private void buttonConnecter_MouseLeave(object sender, EventArgs e)
        {
            buttonConnecter.BackColor = Color.FromArgb(255, 255, 235, 133);
        }
    }
}