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
    public partial class FormGestionDechets : Form
    {
        public FormGestionDechets()
        {
            InitializeComponent();
        }

        private void FormGestionDechets_Load(object sender, EventArgs e)
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

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
