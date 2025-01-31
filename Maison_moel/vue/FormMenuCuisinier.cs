using ApplicationC.Controller;
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
    public partial class FormMenuCuisinier : Form
    {
        SFormulaire sousForm;

        public FormMenuCuisinier()
        {
            InitializeComponent();
            sousForm = new SFormulaire(panelSousAffichage);

            //ouverture par défaut
            //sousForm.openChildForm(new FormGestionCommande());
        }

        private void gestionReaprovisionnementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousForm.openChildForm(new FormGestionReapprovisionnements());
        }

        private void gestionDechetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousForm.openChildForm(new FormGestionDechets());
        }

        private void gestionCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousForm.openChildForm(new FormGestionCommandes());
        }
    }
}
