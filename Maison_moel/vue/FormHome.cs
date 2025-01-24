using ApplicationC.Controller;
using Maison_moel.Entities;
using Microsoft.VisualBasic.Devices;
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
    public partial class FormHome : Form
    {
        SFormulaire sousF;
        public enum EtatDroit
        {
            Admin,
            Cuisinier
        }
        EtatDroit etatDroit;

        public FormHome(bool est_admin)
        {
            InitializeComponent();
            est_admin = true;
            etatDroit = est_admin ? EtatDroit.Admin : EtatDroit.Cuisinier;
            sousF = new(panelAffichage);
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.Load("http://192.168.143.9:8080/images/LOGO_TRANS.png");

            this.ControlBox = false;

            buttonAffiche(false);

            if (etatDroit == EtatDroit.Cuisinier)
            {
                buttonQuitter.Location = buttonAbout.Location;
                buttonAbout.Location = buttonSettings.Location;
                buttonSettings.Location = buttonPersonnel.Location;
                panelWest.Size = new(223, 428);
            }

            panelVisible();
        }

        #region Affichage MenuBar
        private void buttonAffiche(bool test)
        {
            panelWest.Visible = test;
            buttonAbout.Visible = test;
            buttonCuisine.Visible = test;
            buttonCommande.Visible = test;
            buttonQuitter.Visible = test;
            buttonSettings.Visible = test;

            buttonPersonnel.Visible = etatDroit == EtatDroit.Admin ? test : false;
        }

        private void panelVisible()
        {
            panelAbout.Visible = false;
            panelSettings.Visible = false;
            panelQuitter.Visible = false;
            panelHome.Visible = false;
            panelCommande.Visible = false;
            panelCuisine.Visible = false;
            panelPersonnel.Visible = false;
        }
        #endregion

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
            panelVisible();
            panelHome.Visible = true;
        }

        private void buttonCommande_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
            panelVisible();
            panelCommande.Visible = true;
            sousF.openChildForm(new FormGestionCommande());
        }

        private void buttonCuisine_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
            panelVisible();
            panelCuisine.Visible = true;
            sousF.openChildForm(new Formcuisine());
        }

        private void buttonPersonnel_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
            panelVisible();
            panelPersonnel.Visible = true;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
            panelVisible();
            panelSettings.Visible = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
            panelVisible();
            panelAbout.Visible = true;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            //buttonAffiche(!buttonSettings.Visible);
            //panelVisible();
            //panelQuitter.Visible = true;
        }
    }
}
