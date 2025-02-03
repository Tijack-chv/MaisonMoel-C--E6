using Maison_moel.Entities;
using Maison_moel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace Maison_moel.vue
{
    public partial class FormAjoutMembre : Form
    {
        public FormAjoutMembre()
        {
            InitializeComponent();

            comboBox_metier.Items.Add("");
            comboBox_metier.Items.Add("Serveurs");
            comboBox_metier.Items.Add("Administrateurs");
            comboBox_metier.Items.Add("Cuisiniers");

            bindingSource_role = new BindingSource();
            bindingSource_role.DataSource = ModelRole.ListeRole();
            comboBox_role.DataSource = bindingSource_role;
            comboBox_role.DisplayMember = "libelleRole";
            comboBox_role.ValueMember = "IdRole";

            comboBox_role.SelectedValue = 0;

            label_role.Visible = false;
            comboBox_role.Visible = false;
            label_salaire.Visible = false;
            nud_salaire.Visible = false;

            textBox_mdp.UseSystemPasswordChar = true;
            textBox_confirmMdp.UseSystemPasswordChar = true;



        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            Personne personne = new Personne();
            // Récupération des valeurs des champs
            string nom = textBox_nom.Text.Trim();
            string prenom = textBox_prenom.Text.Trim();
            string email = textBox_email.Text.Trim();
            string mdp = textBox_mdp.Text;
            string confirmMdp = textBox_confirmMdp.Text;
            DateTime dateNaissance = dateTimePicker_naissance.Value;
            string metier = comboBox_metier.Text;

            // Vérification des champs obligatoires
            if (string.IsNullOrWhiteSpace(nom) ||
                string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(mdp) ||
                string.IsNullOrWhiteSpace(confirmMdp) ||
                string.IsNullOrWhiteSpace(metier))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérification du mot de passe et de sa confirmation
            if (mdp != confirmMdp)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TestValidation.EstEmailValide(email))
            {
                MessageBox.Show("L'email n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TestValidation.EstAgeValide(dateNaissance))
            {
                MessageBox.Show("La personne doit avoir au minimum 16 ans.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Vérification de la sécurité du mot de passe
            if (!TestValidation.EstMotDePasseValide(mdp))
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères, une majuscule, une minuscule, un chiffre et un caractère spécial.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (metier)
            {
                case "Serveurs":

                    {
                        personne.Nom = nom;
                        personne.Prenom = prenom;
                        personne.Email = email;
                        personne.DateNaiss = DateOnly.FromDateTime(dateNaissance);
                        personne.Password = BC.HashPassword(mdp);
                        personne.Token = Guid.NewGuid().ToString();
                        personne.Serveur = new Serveur();
                        personne.Serveur.IdPersonne = personne.IdPersonne;
                        personne.Serveur.Salaires = Convert.ToInt32(nud_salaire.Value);
                        ModelPersonne.ajouterPersonne(personne);


                    };
                    break;

                case "Administrateurs":

                    {
                        personne.Nom = nom;
                        personne.Prenom = prenom;
                        personne.Email = email;
                        personne.DateNaiss = DateOnly.FromDateTime(dateNaissance); ;
                        personne.Password = BC.HashPassword(mdp);
                        personne.Token = Guid.NewGuid().ToString();
                        personne.Admin = new Admin();
                        personne.Admin.IdPersonne = personne.IdPersonne;
                        ModelPersonne.ajouterPersonne(personne);
                    };
                    break;

                case "Cuisiniers":

                    {
                        personne.Nom = nom;
                        personne.Prenom = prenom;
                        personne.Email = email;
                        personne.DateNaiss = DateOnly.FromDateTime(dateNaissance);
                        personne.Password = BC.HashPassword(mdp);
                        personne.Token = Guid.NewGuid().ToString();
                        personne.Cuisinier = new Cuisinier();
                        personne.Cuisinier.IdPersonne = personne.IdPersonne;
                        personne.Cuisinier.Salaires = Convert.ToInt32(nud_salaire.Value);
                        personne.Cuisinier.IdRole = Convert.ToInt32(comboBox_role.SelectedValue);
                        ModelPersonne.ajouterPersonne(personne);
                    };

                    break;

                default:

                    personne.Nom = nom;
                    personne.Prenom = prenom;
                    personne.Email = email;
                    personne.DateNaiss = DateOnly.FromDateTime(dateNaissance);
                    personne.Password = BC.HashPassword(mdp);
                    personne.Token = Guid.NewGuid().ToString();
                    ModelPersonne.ajouterPersonne(personne);

                    break;
            }

            // Si tout est valide
            MessageBox.Show("Utilisateur ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_nom.Text = "";
            textBox_prenom.Text = "";
            textBox_email.Text = "";
            textBox_mdp.Text = "";
            textBox_confirmMdp.Text = "";
            comboBox_metier.SelectedIndex = 0;
            nud_salaire.Value = 0;
            comboBox_role.SelectedIndex = -1;
        }

        private void comboBox_metier_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (comboBox_metier.Text == "")
            {
                label_role.Visible = false;
                comboBox_role.Visible = false;
                label_salaire.Visible = false;
                nud_salaire.Visible = false;
            }
            if (comboBox_metier.Text == "Serveurs")
            {
                label_salaire.Visible = true;
                nud_salaire.Visible = true;
                label_role.Visible = false;
                comboBox_role.Visible = false;
            }
            if (comboBox_metier.Text == "Administrateurs")
            {
                label_role.Visible = false;
                comboBox_role.Visible = false;
                label_salaire.Visible = false;
                nud_salaire.Visible = false;
            }
            if (comboBox_metier.Text == "Cuisiniers")
            {
                label_role.Visible = true;
                comboBox_role.Visible = true;
                label_salaire.Visible = true;
                nud_salaire.Visible = true;
            }

        }
    }

}

