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
            comboBoxServeur.DisplayMember = "NomComplet";

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

            AppliquerFiltres();
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {

            AppliquerFiltres();
        }

        private void buttonRenitialiserFiltre_Click(object sender, EventArgs e)
        {
            FormCuisine_Load(sender, EventArgs.Empty);
        }

        private void AppliquerFiltres()
        {
            // Récupérer la liste de base des commandes
            List<Commande> query = ModelCommande.ListeCommande();

            // Filtrer par état si un état est sélectionné
            if (comboEtat.SelectedIndex != -1)
            {
                int etatSelectionne = Convert.ToInt32(comboEtat.SelectedValue);
                List<Commande> commandesParEtat = ModelEtat.ListeCommandeParEtat(etatSelectionne);
                query = query.Intersect(commandesParEtat).ToList();  // Applique le filtre par état
            }

            // Filtrer par table si une table est sélectionnée
            if (comboBoxTable.SelectedIndex != -1)
            {
                int tableSelectionnee = Convert.ToInt32(comboBoxTable.SelectedValue);
                List<Commande> commandesParTable = ModelTable.ListeCommandeParTable(tableSelectionnee);
                query = query.Intersect(commandesParTable).ToList();  // Applique le filtre par table
            }

            // Vérifier si la liste filtrée contient des résultats
            if (query.Any())
            {
                FormCuisine_Load(query);  // Recharger les données dans le DataGridView
            }
            else
            {
                // Si la liste est vide, vider le DataGridView et afficher un message
                DataGridCuisine.DataSource = null;
                MessageBox.Show("Aucune commande ne correspond aux critères des filtres !", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        private void DataGridCuisine_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifie qu'une ligne a été sélectionnée
            {
                DataGridViewRow selectedRow = DataGridCuisine.Rows[e.RowIndex];

                int idCommande = Convert.ToInt32(selectedRow.Cells[0].Value);
                string etat = selectedRow.Cells[1].Value?.ToString() ;
                string numeroTable = selectedRow.Cells[2].Value?.ToString() ;
                string serveur = selectedRow.Cells[3].Value?.ToString() ;

                // Ouvrir un formulaire de gestion de commande
                FormHome fhome = (FormHome)Application.OpenForms["FormHome"];
                if (fhome != null)
                {
                    fhome.sousF.closeChildForm(); // pas obligatoire mais mieux
                    fhome.sousF.openChildForm(new FormGestionCommande(idCommande, etat, serveur, numeroTable));
                }
            }
        }

        
    }
}

