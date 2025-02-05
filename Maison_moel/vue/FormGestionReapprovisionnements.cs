using ApplicationC.Controller;
using Maison_moel.controller;
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
using System.Xml.Linq;

namespace Maison_moel.vue
{
    public partial class FormGestionReapprovisionnements : Form
    {
        private int quantiteCritiqueReapro;
        private int minPage;
        private int maxPage;
        private int nbElementParPage = 20;
        private String dgvOpen;

        public FormGestionReapprovisionnements()
        {
            InitializeComponent();
            dgvOpen = "reapprovisionnement";
            quantiteCritiqueReapro = 10;
            minPage = 1;
            nbPages();
            ComponentStyle componentStyle = new();
            componentStyle.arrondirBordureObjet(labelNotification);
        }

        private void nbPages()
        {
            int count = ModelReaprovisionnement.NombreDemandeReaprovisionnement();
            if (count % nbElementParPage == 0)
            {
                maxPage = count / nbElementParPage;
            }
            else
            {
                maxPage = (count / nbElementParPage) + 1;
            }
        }

        private void FormGestionReapprovisionnements_Load(object sender, EventArgs e)
        {
            LoadNotif();

            panelReappro.Visible = false;
            chargerDGV("reapprovisionnement");
        }

        private void LoadNotif()
        {
            labelNotification.Text = ModelReaprovisionnement.NombreReaprovisionnement(quantiteCritiqueReapro).ToString();
            pictureBoxNotification.Enabled = Convert.ToInt32(labelNotification.Text) >= 0 ? true : false;
            labelNotification.Text = Convert.ToInt32(labelNotification.Text) > 9 ? "9+" : labelNotification.Text;
        }

        #region DataGridViewDataLoad
        private void chargerDGV(string type)
        {
            if (type == "plat")
            {
                dgvOpen = "plat";
                chargerDataGridViewPlat();
            }
            else if (type == "platAReapro")
            {
                dgvOpen = "platAReapro";
                chargerDataGridViewPlatAReapro();
            }
            else
            {
                dgvOpen = "reapprovisionnement";
                chargerDataGridViewReapprovisionnement();
            }
            dataGridView.DataSource = bindingSource;
            dataGridView.Columns[0].Visible = false;

            int totalWidth = dataGridView.Width;
            int columnCount = dataGridView.Columns.Count - 1;
            int columnWidth = totalWidth / columnCount;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                column.Width = columnWidth;
            }
        }

        private void chargerDataGridViewReapprovisionnement()
        {
            bindingSource.DataSource = ModelReaprovisionnement.ListeReapprovisionnementParPage(nbElementParPage, Convert.ToInt32(textBoxPage.Text)).Select(static x => new
            {
                x.IdPlat,
                x.IdPlatNavigation.NomPlat,
                x.QuantiteReapro,
                x.DateHeureReapro
            }).ToList();

            dataGridView.ContextMenuStrip = null;
        }

        private void chargerDataGridViewPlatAReapro()
        {
            bindingSource.DataSource = ModelReaprovisionnement.ListePlatAReapro(10).Select(static x => new
            {
                x.IdPlat,
                x.NomPlat,
                x.Quantite
            }).ToList();

            dataGridView.ContextMenuStrip = null;
        }

        private void chargerDataGridViewPlat()
        {
            bindingSource.DataSource = ModelPlat.ListePlat().Select(static x => new
            {
                x.IdPlat,
                x.NomPlat,
                x.Quantite,
            }).ToList();
        }
        #endregion

        private void buttonPlats_Click(object sender, EventArgs e)
        {
            panelReappro.Visible = true;
            panelPage.Visible = false;
            chargerDGV("plat");
        }

        private void buttonReapprovisionnements_Click(object sender, EventArgs e)
        {
            panelReappro.Visible = false;
            panelPage.Visible = true;
            chargerDGV("reapprovisionnement");
        }

        private void pictureBoxNotification_Click(object sender, EventArgs e)
        {
            panelReappro.Visible = true;
            panelPage.Visible = false;
            chargerDGV("platAReapro");
        }

        private void buttonSuiv_Click(object sender, EventArgs e)
        {
            int tempoPage = Convert.ToInt32(textBoxPage.Text);
            tempoPage++;
            textBoxPage.Text = tempoPage.ToString();
        }

        private void buttonPrec_Click(object sender, EventArgs e)
        {
            int tempoPage = Convert.ToInt32(textBoxPage.Text);
            tempoPage--;
            textBoxPage.Text = tempoPage.ToString();
        }

        private void textBoxPage_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPage.Text != "")
            {
                if (int.TryParse(textBoxPage.Text, out int pageNumber))
                {
                    if (pageNumber <= minPage)
                    {
                        textBoxPage.Text = minPage.ToString();
                        buttonPrec.Enabled = false;
                    }
                    else
                    {
                        buttonPrec.Enabled = true;
                    }

                    if (pageNumber >= maxPage)
                    {
                        textBoxPage.Text = maxPage.ToString();
                        buttonSuiv.Enabled = false;
                    }
                    else
                    {
                        buttonSuiv.Enabled = true;
                    }
                }
                else
                {
                    textBoxPage.Text = minPage.ToString();
                    buttonPrec.Enabled = false;
                    buttonSuiv.Enabled = true;
                }
            }
            else
            {
                textBoxPage.Text = minPage.ToString();
                buttonPrec.Enabled = false;
                buttonSuiv.Enabled = true;
            }

            nbPages();
            chargerDGV("reapprovisionnement");
        }

        private void textBoxPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void réapprovisionnerLePlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bindingSource.Current.GetType();
            int idPlat = (int)type.GetProperty("IdPlat").GetValue(bindingSource.Current, null);

            Plat plat = new Plat();
            plat = ModelPlat.recupPlat(idPlat);

            bool choix = MessageBox.Show("Voulez-vous réapprovisionner le plat "+ plat.NomPlat +" en "+ numericUpDownReappro.Value +" exemplaires ?", "Réapprovisionnement du plat n°"+plat.IdPlat, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        
            if (choix)
            {
                if (ModelReaprovisionnement.NouveauReapprovisionnement(plat.IdPlat, Convert.ToInt32(numericUpDownReappro.Value)))
                {
                    MessageBox.Show("Réapprovisionnement effectué avec succès");
                    LoadNotif();
                    if (dgvOpen == "plat")
                    {
                        chargerDGV("plat");
                    }
                    else
                    {
                        chargerDGV("platAReapro");
                    } 

                }
                else
                {
                    MessageBox.Show("Erreur lors du réapprovisionnement");
                }
            } else
            {
                MessageBox.Show("Annulation du réapprovisionnement");
            }
        }
       
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            // cela correpond à la datagridview des reaprovisionnements d'ouvertes
            if (!panelPage.Visible)
            {
                réapprovisionnerLePlatToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
