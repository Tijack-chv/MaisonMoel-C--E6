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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Maison_moel.vue
{
    public partial class Formcuisine : Form
    {
        public Formcuisine()
        {
            InitializeComponent();

            comboEtat.ValueMember = "idEtat";
            comboEtat.DisplayMember = "libelleEtat";

            bindingSourceEtat.DataSource = (ModelEtat.ListeEtat());
            comboEtat.DataSource = bindingSourceEtat;
            comboEtat.SelectedIndex = -1;

            comboBoxServeur.ValueMember = "idPersonne";
            comboBoxServeur.DisplayMember = "nom";

            bindingSourceServeur.DataSource = (ModelPersonne.ListeServeur());
            comboBoxServeur.DataSource = bindingSourceServeur;
            comboBoxServeur.SelectedIndex = -1;

            comboBoxTable.ValueMember = "idTable";
            comboBoxTable.DisplayMember = "NomTable";

            bindingSourceTable.DataSource = (ModelTable.ListeTable());
            comboBoxTable.DataSource = bindingSourceTable;
            comboBoxTable.SelectedIndex = -1;
        }

        private void FormCuisine_Load(List<Commande> liste)
        {
            bindingSourceCuisine.DataSource = liste.Select(static x => new
            {
                x.IdCommande,
                x.IdEtatNavigation.LibelleEtat,
                x.IdReservationNavigation.IdTableNavigation.NomTable,
                x.IdPersonneNavigation.IdPersonneNavigation.Nom,
                x.DateCommande,
            });

            DataGridCuisine.DataSource = bindingSourceCuisine;

            // Configuration des colonnes
            DataGridCuisine.Columns[0].HeaderText = "Commande";
            DataGridCuisine.Columns[1].HeaderText = "État";
            DataGridCuisine.Columns[2].HeaderText = "Numéro de table";
            DataGridCuisine.Columns[3].HeaderText = "Serveur";
            DataGridCuisine.Columns[4].HeaderText = "Date de commande";
        }
        private void FormCuisine_Load(object sender, EventArgs e)
        {
            bindingSourceCuisine.DataSource = ModelCommande.ListeCommande().Select(static x => new
            {
                x.IdCommande,
                x.IdEtatNavigation.LibelleEtat,
                x.IdReservationNavigation.IdTableNavigation.NomTable,
                x.IdPersonneNavigation.IdPersonneNavigation.Nom,
                x.DateCommande,
            });

            DataGridCuisine.DataSource = bindingSourceCuisine;

            // Configuration des colonnes
            DataGridCuisine.Columns[0].HeaderText = "Commande";
            DataGridCuisine.Columns[1].HeaderText = "État";
            DataGridCuisine.Columns[2].HeaderText = "Numéro de table";
            DataGridCuisine.Columns[3].HeaderText = "Serveur";
            DataGridCuisine.Columns[4].HeaderText = "Date de commande";
        }

        private void comboEtat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEtat.SelectedIndex != -1)
            {
                int etatSelectionne = (int)comboEtat.SelectedValue;
                List<Commande> commandes = ModelCommande.ListeCommande();

                var commandesFiltrees = commandes
                .Where(c => c.IdEtat == etatSelectionne)
                .ToList();

                if (commandesFiltrees.Any())
                {
                    FormCuisine_Load(commandesFiltrees);
                }
                else
                {
                    // Si la liste est vide, vide le DataGridView et affiche un message
                    DataGridCuisine.DataSource = null;
                    MessageBox.Show("Aucun résultat!", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void buttonRenitialiserFiltre_Click(object sender, EventArgs e)
        {
            FormCuisine_Load(sender, EventArgs.Empty);
        }
    }


}

