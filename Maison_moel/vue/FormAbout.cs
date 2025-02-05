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

namespace Maison_moel.vue
{
    public partial class FormAbout : Form
    {
        String laffiche = null;
        string choix;
        int idEvenement;

        public FormAbout()
        {
            InitializeComponent();
            dataGridViewEvenement.Location = new Point(197, 12);
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            bindingSourceEvenement.DataSource = Model.ModelEvenement.GetEvenements().Select(static x => new
            {
                x.IdEvenement,
                x.DescriptionEvenement,
                x.ImageEvenement,
                x.DateEvenement,
                x.IdTypeEvenement,
                x.IdTypeEvenementNavigation.LibelleTypeEvenement,
            }).ToList();

            dataGridViewEvenement.DataSource = bindingSourceEvenement;
            dataGridViewEvenement.Columns[0].Visible = false;
            dataGridViewEvenement.Columns[2].Visible = false;
            dataGridViewEvenement.Columns[4].Visible = false;


            comboBoxTypeEvenement.DisplayMember = "LibelleTypeEvenement";
            comboBoxTypeEvenement.ValueMember = "IdTypeEvenement";
            bindingSourceTypeEvenement.DataSource = Model.ModelEvenement.GetTypeEvenement();
            comboBoxTypeEvenement.DataSource = bindingSourceTypeEvenement;
            comboBoxTypeEvenement.SelectedIndex = -1;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (choix != "insertion")
            {
                Evenement evenement = new Evenement
                {
                    IdEvenement = idEvenement,
                    DescriptionEvenement = textBoxDescriptionEvenement.Text,
                    DateEvenement = dateTimePickerEvenement.Value,
                    IdTypeEvenement = (int)comboBoxTypeEvenement.SelectedValue,
                    ImageEvenement = laffiche
                };
                ModelEvenement.modifierEvenement(evenement);
            } 
            else
            {
                ModelEvenement.ajoutEvenement((int)comboBoxTypeEvenement.SelectedValue, textBoxDescriptionEvenement.Text, dateTimePickerEvenement.Value, laffiche);
            }
            FormAbout_Load(sender, e);
            laffiche = null;
            idEvenement = -1;
            textBoxDescriptionEvenement.Text = "";
            comboBoxTypeEvenement.SelectedIndex = -1;
            pictureBoxEvenement.Image = null;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            dataGridViewEvenement.Location = new Point(197, 12);
            panelEvenement.Visible = false;
        }

        private void insertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimePickerEvenement.MinDate = DateTime.Now;
            dataGridViewEvenement.Location = new Point(22, 12);
            panelEvenement.Visible = true;
            choix = "insertion";
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choix = "update";
            System.Type type = bindingSourceEvenement.Current.GetType();
            idEvenement = (int)type.GetProperty("IdEvenement").GetValue(bindingSourceEvenement.Current, null);
            Evenement evenement = Model.ModelEvenement.GetEvenementById(idEvenement);

            dateTimePickerEvenement.MinDate = new DateTime(2020, 1, 1);
            textBoxDescriptionEvenement.Text = evenement.DescriptionEvenement;
            dateTimePickerEvenement.Value = (DateTime)evenement.DateEvenement;
            comboBoxTypeEvenement.SelectedValue = evenement.IdTypeEvenement;
            if (evenement.ImageEvenement != null)
            {
                pictureBoxEvenement.Load("http://192.168.143.9:8080/" + evenement.ImageEvenement);
            }

            dataGridViewEvenement.Location = new Point(22, 12);
            panelEvenement.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bindingSourceEvenement.Current.GetType();
            int idEvenement = (int)type.GetProperty("IdEvenement").GetValue(bindingSourceEvenement.Current, null);
            Evenement evenement = Model.ModelEvenement.GetEvenementById(idEvenement);

            bool reponse = MessageBox.Show("Voulez-vous vraiment supprimer l'évènement "+ evenement.DescriptionEvenement +" ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (reponse)
            {
                Model.ModelEvenement.supprimerEvenement(evenement);
            }
            FormAbout_Load(sender, e);
        }

        private void labelImageEvenement_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                laffiche = openFileDialog.FileName;
                pictureBoxEvenement.Image = Image.FromFile(laffiche);
            }
        }
    }
}
