using ApplicationC.Controller;
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

        #region Attributs
        SFormulaire sousF;

        public FormAdministration()
        {
            InitializeComponent();


            comboBox_Metier.Items.Add("");
            comboBox_Metier.Items.Add("Serveurs");
            comboBox_Metier.Items.Add("Administrateurs");
            comboBox_Metier.Items.Add("Cuisiniers");


        }
        #endregion

        #region LoadDataGridView
        private void FormAdministration_Load(object sender, EventArgs e)
        {

            bindingSourcePersonnes.DataSource = ModelPersonne.ListePersonne().Select(static x => new
            {
                x.IdPersonne,
                x.Nom,
                x.Prenom,
                x.DateNaiss,
                x.Email,
            });

            dataGridPersonne.DataSource = bindingSourcePersonnes;


            // Configuration des colonnes
            dataGridPersonne.Columns[0].HeaderText = "Identifiant";
            dataGridPersonne.Columns[1].HeaderText = "Nom";
            dataGridPersonne.Columns[2].HeaderText = "Prénom";
            dataGridPersonne.Columns[3].HeaderText = "Date de Naissance";
            dataGridPersonne.Columns[4].HeaderText = "Email";
            dataGridPersonne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            radioButton_non.Checked = true;

        }

        private void Form_AdministrationFiltre_Load(List<Personne> personne)
        {
            bindingSourcePersonnes.DataSource = personne.Select(static x => new
            {
                x.IdPersonne,
                x.Nom,
                x.Prenom,
                x.DateNaiss,
                x.Email,
            });

            dataGridPersonne.DataSource = bindingSourcePersonnes;


            // Configuration des colonnes
            dataGridPersonne.Columns[0].HeaderText = "Identifiant";
            dataGridPersonne.Columns[1].HeaderText = "Nom";
            dataGridPersonne.Columns[2].HeaderText = "Prénom";
            dataGridPersonne.Columns[3].HeaderText = "Date de Naissance";
            dataGridPersonne.Columns[4].HeaderText = "Email";
            dataGridPersonne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        #endregion

        #region AppliquerFiltres

        private void AppliquerFiltres()
        {
            if (radioButton_oui.Checked == true)
            {
                List<Personne> query = new List<Personne>();
                List<Personne> query1 = ModelPersonne.ListePersonneArchiver().ToList();
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
                        query2 = ModelPersonne.ListeServeurArchiver();
                        query = query1.Intersect(query2).ToList();
                    }
                    if (comboBox_Metier.SelectedIndex == 2)
                    {
                        query2 = ModelPersonne.ListeAdminArchiver();
                        query = query1.Intersect(query2).ToList();
                    }
                    if (comboBox_Metier.SelectedIndex == 3)
                    {
                        query2 = ModelPersonne.ListeCuisinierArchiver();
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
                    reinitialiserFiltre();
                }
            }
            else
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
                    reinitialiserFiltre();
                }
            }


        }

        #endregion

        #region reinitialiserFiltre
        private void reinitialiserFiltre()
        {
            comboBox_Metier.SelectedIndex = 0;
            txtbx_filtreNom.Text = "";
            txtbx_filtrePrenom.Text = "";
            dateTimePicker_DateNaissance.Value = Convert.ToDateTime("01/01/1975");
            radioButton_oui.Checked = false;
            radioButton_non.Checked = true;
        }

        #endregion

        #region Filtres

        private void comboBox_Metier_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
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

        private void buttonRenitialiserFiltre_Click(object sender, EventArgs e)
        {
            reinitialiserFiltre();
        }

        private void radioButton_oui_CheckedChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        #endregion

        #region MenuStrip

        private void ModifierPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridPersonne.SelectedRows.Count > 0)
            {
                if (dataGridPersonne.SelectedRows.Count == 1)
                {
                    int currentId = Convert.ToInt32(dataGridPersonne.SelectedRows[0].Cells[0].Value.ToString());
                    sousF = new(panel_admin);
                    sousF.openChildForm(new FormModificationPersonnel(currentId));
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un seul et unique membre du personnel", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un membre du personnel", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void archiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridPersonne.SelectedRows.Count > 0)
            {
                if (dataGridPersonne.SelectedRows.Count == 1)
                {
                    int currentId = Convert.ToInt32(dataGridPersonne.SelectedRows[0].Cells[0].Value.ToString());
                    sousF = new(panel_admin);
                    sousF.openChildForm(new FormModificationMDP(currentId));
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un seul et unique membre du personnel", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un membre du personnel", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region ArchiverPersonne
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridPersonne.SelectedRows.Count > 0)
            {
                if (dataGridPersonne.SelectedRows.Count == 1)
                {
                    int currentId = Convert.ToInt32(dataGridPersonne.SelectedRows[0].Cells[0].Value.ToString());
                    ModelPersonne.ArchiverPersonne(currentId);
                    MessageBox.Show("La personne sélectionner vient d'être archivée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un seul et unique membre du personnel", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un membre du personnel", "Erreur de selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion



    }
}
