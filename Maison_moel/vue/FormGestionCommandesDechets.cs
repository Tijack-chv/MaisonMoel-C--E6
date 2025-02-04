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
    public partial class FormGestionCommandesDechets : Form
    {
        public FormGestionCommandesDechets()
        {
            InitializeComponent();
        }

        private void FormGestionDechets_Load(object sender, EventArgs e)
        {
            DechetsLoad();
            CommandesLoad();
        }

        public void DechetsLoad()
        {
            bindingSourceDechets.DataSource = ModelDechets.GetDechets().Select(static x => new
            {
                x.IdDechets,
                x.Poids,
                x.DateSaisie,
            }).ToList();

            dataGridViewDechets.DataSource = bindingSourceDechets;
            dataGridViewDechets.Columns["IdDechets"].Visible = false;
        }

        public void CommandesLoad()
        {
            bindingSourceCommande.DataSource = ModelCommande.ListeComporter().Select(static x => new
            {
                x.IdCommande,
                x.IdPlat,
                x.IdPlatNavigation.DescriptionPlat,
                x.Prix,
                x.NbCommander,
                x.IdEtat,
                x.IdEtatNavigation.LibelleEtat,

            }).ToList();

            dataGridViewCommandes.DataSource = bindingSourceCommande;
            dataGridViewCommandes.Columns["IdCommande"].Visible = false;
            dataGridViewCommandes.Columns["IdPlat"].Visible = false;
            dataGridViewCommandes.Columns["IdEtat"].Visible = false;
        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ModelDechets.getDechetbyDate(DateTime.Now))
            {
                bool choix = MessageBox.Show("Voulez-vous ajouter " + numericUpDownDechets.Value + "kg de dechet ?", "Déchet du " + DateOnly.FromDateTime(DateTime.Now), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

                if (choix)
                {
                    ModelDechets.AddDechet(new Entities.Dechet
                    {
                        Poids = (float)numericUpDownDechets.Value,
                        DateSaisie = DateTime.Now
                    });
                    DechetsLoad();
                }
            } else
            {
                MessageBox.Show("Vous avez déjà ajouté des déchets aujourd'hui", "Déchet du " + DateOnly.FromDateTime(DateTime.Now), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bindingSourceDechets.Current.GetType();
            DateTime dateDechet = (DateTime)type.GetProperty("DateSaisie").GetValue(bindingSourceDechets.Current, null);

            if (dateDechet.Date == DateTime.Now.Date)
            {
                float poids = (float)type.GetProperty("Poids").GetValue(bindingSourceDechets.Current, null);
                bool choix = MessageBox.Show("Voulez-vous modifier le poids de "+ poids + "kg à " + numericUpDownDechets.Value + "kg du déchet du " + DateOnly.FromDateTime(dateDechet) + " ?", "Déchet du " + DateOnly.FromDateTime(dateDechet), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                
                if (choix)
                {
                    ModelDechets.UpdateDechet((int)type.GetProperty("IdDechets").GetValue(bindingSourceDechets.Current, null), (float)numericUpDownDechets.Value);
                    DechetsLoad();
                }
            } 
            else
            {
                MessageBox.Show("Vous ne pouvez pas modifier un déchet d'un autre jour", "Déchet du " + DateOnly.FromDateTime(dateDechet), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bindingSourceDechets.Current.GetType();
            DateTime dateDechet = (DateTime)type.GetProperty("DateSaisie").GetValue(bindingSourceDechets.Current, null);

            if (dateDechet.Date == DateTime.Now.Date)
            {
                bool choix = MessageBox.Show("Voulez-vous supprimer le déchet du " + DateOnly.FromDateTime(dateDechet) + " ?", "Déchet du " + DateOnly.FromDateTime(dateDechet), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

                if (choix)
                {
                    int idDechet = (int)type.GetProperty("IdDechets").GetValue(bindingSourceDechets.Current, null);
                    ModelDechets.DeleteDechet(idDechet);
                    DechetsLoad();
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer un déchet d'un autre jour", "Déchet du " + DateOnly.FromDateTime(dateDechet), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewCommandes_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
