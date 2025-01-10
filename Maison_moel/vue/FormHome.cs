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

        bool sideBarExpend;
        public SFormulaire sousF;

        public FormHome(bool est_admin)
        {
            InitializeComponent();
            bool admin = est_admin;

            sousF = new(panelAffichage);
            sousF.openChildForm(new Formcuisine());

            buttonAffiche(false);
            panelVisible();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.Load("http://192.168.143.9:8080/images/LOGO_TRANS.png");
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
        }

        private void buttonAffiche(bool test)
        {
            panelWest.Visible = test;
            buttonAbout.Visible = test;
            buttonEquipe.Visible = test;
            buttonHackathon.Visible = test;
            buttonQuitter.Visible = test;
            buttonSettings.Visible = test;
            buttonJury.Visible = test;
        }

        private void panelVisible()
        {
            panelAbout.Visible = false;
            panelSettings.Visible = false;
            panelQuitter.Visible = false;
            panelHome.Visible = false;
            panelHackathon.Visible = false;
            panelMembreEquipe.Visible = false;
            panelJury.Visible = false;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);

            sousF.openChildForm(new Formcuisine());
            panelVisible();
            panelHome.Visible = true;
        }
    }
}
