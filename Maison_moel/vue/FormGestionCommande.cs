using ApplicationC.Controller;
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
using System.Windows.Forms.VisualStyles;

namespace Maison_moel.vue
{
    public partial class FormGestionCommande : Form
    {
        private int idCommande;
        private string etat;
        private string serveur;
        private string table;

        public FormGestionCommande(int id, string etat, string serveur, string table)
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


            this.idCommande = id;
            this.etat = etat;
            this.serveur = serveur;
            this.table = table;

            comboEtat.Text = etat;
            comboBoxServeur.Text = serveur;
            comboBoxTable.Text = table;
        }

        public FormGestionCommande()
        {
            // Initialiser les champs non-nullables avec des valeurs par défaut
            this.etat = string.Empty;
            this.serveur = string.Empty;
            this.table = string.Empty;
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les nouvelles valeurs des contrôles
                int nouvelEtatId = (int)comboEtat.SelectedValue;  // Utiliser SelectedValue pour récupérer l'ID
                int nouveauServeurId = (int)comboBoxServeur.SelectedValue;
                int nouvelleTableId = (int)comboBoxTable.SelectedValue;

                // Utiliser le contexte depuis Model
                var commande = Model.Model.MonModel.Commandes.FirstOrDefault(c => c.IdCommande == idCommande);
                if (commande != null)
                {
                    commande.IdEtat = nouvelEtatId;  
                    commande.IdPersonne = nouveauServeurId;
                    commande.IdReservationNavigation.IdTable = nouvelleTableId;

                    Model.Model.MonModel.SaveChanges(); 
                }
                else
                {
                    MessageBox.Show("Commande non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    
                }

                MessageBox.Show("La commande a été modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHome fhome = (FormHome)Application.OpenForms["FormHome"];
                /*
                if (fhome != null)
                {
                    fhome.sousF.closeChildForm(); // pas obligatoire mais mieux
                    fhome.sousF.openChildForm(new Formcuisine());
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormHome fhome = (FormHome)Application.OpenForms["FormHome"];
                /*
                if (fhome != null)
                {
                    fhome.sousF.closeChildForm(); // pas obligatoire mais mieux
                    fhome.sousF.openChildForm(new Formcuisine());
                }
                */
            }
        }



    }
}
