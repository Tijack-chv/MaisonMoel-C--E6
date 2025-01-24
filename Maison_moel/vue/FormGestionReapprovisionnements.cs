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
    public partial class FormGestionReapprovisionnements : Form
    {
        private int quantiteCritiqueReapro;

        public FormGestionReapprovisionnements()
        {
            InitializeComponent();

            quantiteCritiqueReapro = 10;
            arrondirBordureObjet(labelNotification);
        }

        private void arrondirBordureObjet(Control component)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(0, 0, component.Width - 3, component.Height - 3);
            Region rg = new Region(graphicsPath);
            component.Region = rg;
        }

        private void FormGestionReapprovisionnements_Load(object sender, EventArgs e)
        {
            labelNotification.Text = ModelReaprovisionnement.NombreReaprovisionnement(quantiteCritiqueReapro).ToString();
            labelNotification.Text = Convert.ToInt32(labelNotification.Text) > 9 ? "9+" : labelNotification.Text;
            pictureBoxNotification.Enabled = labelNotification.Text != "0" ? true : false;

            bindingSourceReapprovisionnement.DataSource = ModelReaprovisionnement.ListeReaprovisionnement().Select(static x => new
            {
                x.IdPlat,
                x.IdPlatNavigation.NomPlat,
                x.QuantiteReapro,
                x.DateHeureReapro
            }).ToList();

            dataGridViewReapprovisionnement.DataSource = bindingSourceReapprovisionnement;
            dataGridViewReapprovisionnement.Columns[0].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewReapprovisionnement.Columns)
            {
                dataGridViewReapprovisionnement.Columns[column.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void pictureBoxNotification_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez " + labelNotification.Text + " reapprovisionnements à traiter");
        }
    }
}
