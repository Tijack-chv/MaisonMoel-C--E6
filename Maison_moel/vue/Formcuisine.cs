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
    public partial class Formcuisine : Form
    {
        public Formcuisine()
        {
            InitializeComponent();

           
            bindingSourceEtat.DataSource = (ModelEtat.ListeEtat());
            comboEtat.DataSource = bindingSourceEtat;
            comboEtat.SelectedIndex = -1;
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

        
    }
}
