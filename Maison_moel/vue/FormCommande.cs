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
    public partial class FormCommande : Form
    {
        public FormCommande()
        {
            InitializeComponent();
        }

        private void FormCommande_Load(object sender, EventArgs e)
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

            dataGridViewCommande.DataSource = bindingSourceCommande;
            dataGridViewCommande.Columns["IdCommande"].Visible = false;
            dataGridViewCommande.Columns["IdPlat"].Visible = false;
            dataGridViewCommande.Columns["IdEtat"].Visible = false;
        }

        private void timerCommande_Tick(object sender, EventArgs e)
        {
            FormCommande_Load(sender, e);
        }
    }
}
