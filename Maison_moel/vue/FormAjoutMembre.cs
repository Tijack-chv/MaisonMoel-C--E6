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
            string prenom = textBox_nom.Text.Trim();
            string email = textBox_email.Text.Trim();
            string mdp = textBox_email.Text;
            string confirmMdp = textBox_confirmMdp.Text;
            string dateNaissance = dateTimePicker_naissance.Text;
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
                        personne.DateNaiss = DateOnly.Parse(dateNaissance);
                        personne.Password = BC.HashPassword(mdp);

                    };
                    break;

                case "Administrateurs":

                    {
                        personne.Nom = nom;
                        personne.Prenom = prenom;
                        personne.Email = email;
                        personne.DateNaiss = DateOnly.Parse(dateNaissance);
                        personne.Password = BC.HashPassword(mdp);
            };
                    break;

                case "Cuisiniers":

                    {
                        personne.Nom = nom;
                        personne.Prenom = prenom;
                        personne.Email = email;
                        personne.DateNaiss = DateOnly.Parse(dateNaissance);
                        personne.Password = BC.HashPassword(mdp);
            };

                    break;

                default:

                    personne.Nom = nom;
                    personne.Prenom = prenom;
                    personne.Email = email;
                    personne.DateNaiss = DateOnly.Parse(dateNaissance);
                    personne.Password = BC.HashPassword(mdp);

                    return;
            }

            // Si tout est valide
            MessageBox.Show("Utilisateur ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}

