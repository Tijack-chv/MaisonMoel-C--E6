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

namespace Maison_moel.vue
{
    public partial class FormAdministration : Form
    {
        public FormAdministration()
        {
            InitializeComponent();

            comboBox_Metier.Items.Add("");
            comboBox_Metier.Items.Add("Serveurs");
            comboBox_Metier.Items.Add("Administrateurs");
            comboBox_Metier.Items.Add("Cuisiniers");

        }

        private void Form_Administration_Load(object sender, EventArgs e)
        {

            bindingSourcePersonnes.DataSource = ModelPersonne.ListePersonne().Select(static x => new
            {
                x.Nom,
                x.Prenom,
                x.DateNaiss,
                x.Email,
            });

            dataGridPersonne.DataSource = bindingSourcePersonnes;


            // Configuration des colonnes
            dataGridPersonne.Columns[0].HeaderText = "Nom";
            dataGridPersonne.Columns[1].HeaderText = "Prénom";
            dataGridPersonne.Columns[2].HeaderText = "Date de Naissance";
            dataGridPersonne.Columns[3].HeaderText = "Email";
            dataGridPersonne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Form_AdministrationFiltre_Load(List<Personne> personne)
        {
            bindingSourcePersonnes.DataSource = personne.Select(static x => new
            {
                x.Nom,
                x.Prenom,
                x.DateNaiss,
                x.Email,
            });

            dataGridPersonne.DataSource = bindingSourcePersonnes;


            // Configuration des colonnes
            dataGridPersonne.Columns[0].HeaderText = "Nom";
            dataGridPersonne.Columns[1].HeaderText = "Prénom";
            dataGridPersonne.Columns[2].HeaderText = "Date de Naissance";
            dataGridPersonne.Columns[3].HeaderText = "Email";
            dataGridPersonne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void AppliquerFiltres()
        {
            List<Personne> query = new List<Personne>();
            List<Personne> query1 = ModelPersonne.ListePersonne().ToList();
            List<Personne> query2 = new List<Personne>();

            if (!string.IsNullOrEmpty(txtbx_filtreNom.Text))
                query1 = query1.Where(x => x.Nom.Contains(txtbx_filtreNom.Text)).ToList();
            if (!string.IsNullOrEmpty(txtbx_filtrePrenom.Text))
                query1 = query1.Where(x => x.Prenom.Contains(txtbx_filtrePrenom.Text)).ToList();
            if (dateTimePicker_DateNaissance.Value != dateTimePicker_DateNaissance.MinDate)
                query1 = query1.Where(x => x.DateNaiss >= DateOnly.FromDateTime(dateTimePicker_DateNaissance.Value)).ToList();
            if (comboBox_Metier.SelectedIndex != 0)
            {
                if (comboBox_Metier.SelectedIndex == 1)
                {
                    query2 = ModelPersonne.ListeServeur();
                    query = query1.Intersect(query2).ToList();
                }
                if (comboBox_Metier.SelectedIndex == 2)
                {
                    query2 = ModelPersonne.ListeAdmin();
                    query = query1.Intersect(query2).ToList();
                }
                if (comboBox_Metier.SelectedIndex == 3)
                {
                    query2 = ModelPersonne.ListeCuisinier();
                    query = query1.Intersect(query2).ToList();
                }
            }
            else
            {
                query = query1;
            }

            if (query.Any())
            {
                Form_AdministrationFiltre_Load(query);
            }
            else
            {
                // Si la liste est vide, vide le DataGridView et affiche un message
                dataGridPersonne.DataSource = null;
                MessageBox.Show("Aucun membre ne correspond aux critères des filtres !", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void comboBox_metier_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_filtreNom_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void txtbx_filtrePrenom_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void dateTimePicker_DateNaissance_ValueChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }
    }
}
