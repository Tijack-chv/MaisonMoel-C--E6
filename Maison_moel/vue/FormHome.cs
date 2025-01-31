using ApplicationC.Controller;
using Maison_moel.controller;
using Maison_moel.Model;
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
        DateTime dateMessages;

        public FormHome(bool est_admin, int id)
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

            ComponentStyle componentStyle = new();
            componentStyle.arrondirBordureObjet(pictureBoxNotification);
            afficheCountNotif();
            timerCountNotif.Start();
        }

        private void afficheCountNotif()
        {
            labelNotification.Text = ModelMessage.getUnreadMessagesCount().ToString();
            labelNotification.Text = Convert.ToInt32(labelNotification.Text) > 9 ? "9+" : labelNotification.Text;
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

            panelMessages.Visible = false;
            timerCountNotif.Stop();
        }
        #endregion

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            sousF.closeChildForm();
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
            sousF.openChildForm(new FormMenuCuisinier());
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
        }

        private void timerCountNotif_Tick(object sender, EventArgs e)
        {
            afficheCountNotif();
        }

        private void pictureBoxNotification_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            chargerMessages();
            Cursor.Current = Cursors.Default;
            panelMessages.Visible = !panelMessages.Visible;
            timerCountNotif.Start();
            dateMessages = DateTime.Now;
        }

        private void timerMessages_Tick(object sender, EventArgs e)
        {
            dateMessages = DateTime.Now;
        }

        private void chargerMessages()
        {
            List<Entities.Message> messages = ModelMessage.getMessages();

            int index = 1;

            int idPersTempo = 0;
            DateOnly dateAujourdhui = DateOnly.FromDateTime(DateTime.Now);
            DateOnly dateTempo = new();
            TimeOnly timeTempo = new(00, 00);

            foreach (Entities.Message message in messages)
            {
                // initialisation des variables
                int idPers = message.IdPersonne;
                Entities.Personne personne = ModelPersonne.getPersonneById(idPers);

                DateOnly dateonly = DateOnly.FromDateTime(message.Date);
                TimeOnly timeonly = TimeOnly.FromDateTime(message.Date);

                Label labelDate = new();
                Label labelPersonne = new();
                Label labelMessage = new();

                // ajout des infos de la date en fonction de certains cas
                if (dateAujourdhui != dateonly)
                {
                    if (dateTempo != dateonly)
                    {
                        dateTempo = dateonly;
                        labelDate.Text = dateonly.ToString();
                        panelContenuMessages.Controls.Add(labelDate);
                        labelDate.Location = new(150, 30 * index);
                        index++;
                    }
                }
                else
                {
                    if (timeTempo.AddMinutes(5) <= timeonly)
                    {
                        timeTempo = timeonly;
                        labelDate.Text = timeonly.ToString();
                        panelContenuMessages.Controls.Add(labelDate);
                        labelDate.Location = new(150, 30 * index);
                        index++;
                    }
                }

                // ajout des infos de la personne en fonction d'un cas
                if (idPersTempo != idPers)
                {
                    idPersTempo = idPers;
                    labelPersonne.Text = $"{personne.Nom} {personne.Prenom} : ";
                    panelContenuMessages.Controls.Add(labelPersonne);
                    labelPersonne.Location = new(14, 30 * index);
                    index++;
                }

                Panel panelInfo = new();
                panelContenuMessages.Controls.Add(panelInfo);
                panelInfo.Location = new(14, 30 * index);
                panelInfo.BackColor = Color.FromArgb(255, 235, 153);

                labelMessage.Text += message.Message1;
                panelInfo.Controls.Add(labelMessage);
                labelMessage.Location = new(0, 0);
                panelInfo.Size = new(labelMessage.Width, labelMessage.Height);

                labelDate.AccessibleDefaultActionDescription = "SimSun-ExtB; 14pt; style=Bold";
                labelDate.ForeColor = Color.FromArgb(255, 235, 153);

                labelPersonne.AccessibleDefaultActionDescription = "SimSun-ExtB; 18pt; style=Bold";
                labelPersonne.Font = new Font(labelPersonne.Font, FontStyle.Underline);
                labelPersonne.ForeColor = Color.FromArgb(255, 235, 153);

                labelMessage.AccessibleDefaultActionDescription = "SimSun-ExtB; 18pt; style=Bold";
                labelMessage.ForeColor = Color.FromArgb(0, 0, 0);

                index++;
            }
            ModelMessage.updateMessageUnReadToRead();
        }
    }
}
