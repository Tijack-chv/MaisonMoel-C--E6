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

            comboBox_Metier.Items.Add("Serveurs");
            comboBox_Metier.Items.Add("Administrateurs");
            comboBox_Metier.Items.Add("Cuisiniers");
            comboBox_Metier.SelectedIndex = -1;
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

        private void AppliquerFiltres()
        {
            if (comboBox_Metier.SelectedIndex == 0)
            {
                bindingSourcePersonnes.DataSource = ModelPersonne.ListeServeur().Select(static x => new
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
            if (comboBox_Metier.SelectedIndex == 1)
            {
                bindingSourcePersonnes.DataSource = ModelPersonne.ListeAdmin().Select(static x => new
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
            if (comboBox_Metier.SelectedIndex == 2)
            {
                bindingSourcePersonnes.DataSource = ModelPersonne.ListeCuisinier().Select(static x => new
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
        }

        private void comboBox_metier_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
