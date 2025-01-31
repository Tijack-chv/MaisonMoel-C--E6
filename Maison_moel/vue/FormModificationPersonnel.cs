using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maison_moel.Model;
using Maison_moel.Entities;
using Microsoft.EntityFrameworkCore;

namespace Maison_moel.vue
{
    public partial class FormModificationPersonnel : Form
    {   
        private int id = 0;

        public FormModificationPersonnel()
        {
            InitializeComponent();
        }

        public FormModificationPersonnel(int currentId)
        {
            InitializeComponent();
            id = currentId;
            Personne personne = ModelPersonne.GetPersonneById(currentId);
            if (personne == null)
            {
                MessageBox.Show("Aucune Personne ne correspond à cet identifiant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (personne.Cuisinier == null && personne.Cuisinier == null)
                {
                    textBox_nom.Text = personne.Nom;
                    textBox_prenom.Text = personne.Prenom;
                    textBox_email.Text = personne.Email;
                    dtp_datenaissance.Value = personne.DateNaiss.ToDateTime(TimeOnly.Parse("00:00"));
                    label_salaire.Visible = false;
                    numericUpDown_salaire.Visible = false;
                    label_role.Visible = false;
                    comboBox_role.Visible = false;
                    button_valider.Location = new System.Drawing.Point(39, 276);
                    button_annuler.Location = new System.Drawing.Point(146, 276);
                }
                else
                {
                    if (personne.Cuisinier != null)
                    {
                        textBox_nom.Text = personne.Nom;
                        textBox_prenom.Text = personne.Prenom;
                        textBox_email.Text = personne.Email;
                        dtp_datenaissance.Value = personne.DateNaiss.ToDateTime(TimeOnly.Parse("00:00"));
                        numericUpDown_salaire.Value = personne.Cuisinier.Salaires;
                    }
                    if (personne.Serveur != null)
                    {
                        textBox_nom.Text = personne.Nom;
                        textBox_prenom.Text = personne.Prenom;
                        textBox_email.Text = personne.Email;
                        dtp_datenaissance.Value = personne.DateNaiss.ToDateTime(TimeOnly.Parse("00:00"));
                        numericUpDown_salaire.Value = personne.Serveur.Salaires;
                        label_role.Visible = false;
                        comboBox_role.Visible = false;
                        button_valider.Location = new System.Drawing.Point(39, 339);
                        button_annuler.Location = new System.Drawing.Point(147, 339);
                    }

                }

            }

        }

        private void button_annuler_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            Personne personne = ModelPersonne.GetPersonneById(id);
            if (personne.Cuisinier != null) 
            {
                personne.Nom = textBox_nom.Text;
                personne.Prenom = textBox_prenom.Text;
                personne.Email = textBox_email.Text;
                personne.DateNaiss = DateOnly.FromDateTime(dtp_datenaissance.Value.Date);
                personne.Cuisinier.Salaires = Convert.ToInt32(numericUpDown_salaire.Value);

                Model.Model.MonModel.SaveChanges();
                MessageBox.Show("Les modifications ont été prise en compte", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (personne.Admin != null) 
            {
                personne.Nom = textBox_nom.Text;
                personne.Prenom = textBox_prenom.Text;
                personne.Email = textBox_email.Text;
                personne.DateNaiss = DateOnly.FromDateTime(dtp_datenaissance.Value.Date);

                Model.Model.MonModel.SaveChanges();
                MessageBox.Show("Les modifications ont été prise en compte", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (personne.Serveur != null) 
            {
                personne.Nom = textBox_nom.Text;
                personne.Prenom = textBox_prenom.Text;
                personne.Email = textBox_email.Text;
                personne.DateNaiss = DateOnly.FromDateTime(dtp_datenaissance.Value.Date);
                personne.Serveur.Salaires = Convert.ToInt32(numericUpDown_salaire.Value);

                Model.Model.MonModel.SaveChanges();
                MessageBox.Show("Les modifications ont été prise en compte", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
