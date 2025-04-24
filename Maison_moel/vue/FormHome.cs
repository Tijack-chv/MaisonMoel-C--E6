using ApplicationC.Controller;
using Maison_moel.controller;
using Maison_moel.Entities;
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
        #region Variable
        SFormulaire sousF;
        public enum EtatDroit
        {
            Admin,
            Cuisinier
        }

        private EtatDroit etatDroit;
        private int idPersonneConnecte;
        private int tailleHauteurEnsembleMessage;
        private int premiereOuverture;
        private int idPersonneDernierMessage;
        private DateOnly DateOnlyDernierMessage;
        private TimeOnly TimeOnlyDernierMessage;
        #endregion

        public FormHome(bool est_admin, int id)
        {
            InitializeComponent();
            
            this.Controls.Add(panelMessages);
            panelMessages.BringToFront();
            panelMessages.Location = new(680, 83);
            
            tailleHauteurEnsembleMessage = 10;
            
            idPersonneDernierMessage = 0;
            DateOnlyDernierMessage = new();
            TimeOnlyDernierMessage = new();

            idPersonneConnecte = id;
            etatDroit = est_admin ? EtatDroit.Admin : EtatDroit.Cuisinier;
            sousF = new(panelAffichage);

            Personne personne = ModelPersonne.getPersonneById(idPersonneConnecte);
            labelAdmin.Text = $"{personne.Nom} {personne.Prenom}";
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            buttonAffiche(false);

            if (etatDroit == EtatDroit.Cuisinier)
            {
                buttonQuitter.Location = buttonSettings.Location;
                buttonAbout.Location = buttonPersonnel.Location;
                panelWest.Size = new(223, 364);
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

            buttonSettings.Visible = etatDroit == EtatDroit.Admin ? test : false;
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
            buttonAffiche(!buttonQuitter.Visible);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            sousF.closeChildForm();
            buttonAffiche(!buttonQuitter.Visible);
            panelVisible();
            panelHome.Visible = true;
        }

        private void buttonCommande_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonQuitter.Visible);
            panelVisible();
            panelCommande.Visible = true;
            sousF.openChildForm(new FormCommande());
        }

        private void buttonCuisine_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonQuitter.Visible);
            panelVisible();
            panelCuisine.Visible = true;
            sousF.openChildForm(new FormMenuCuisinier());
        }

        private void buttonPersonnel_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonQuitter.Visible);
            sousF.openChildForm(new FormAdministration());
            panelVisible();
            panelPersonnel.Visible = true;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormAjoutMembre());
            buttonAffiche(!buttonQuitter.Visible);
            panelVisible();
            panelSettings.Visible = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormAbout());
            buttonAffiche(!buttonQuitter.Visible);
            panelVisible();
            panelAbout.Visible = true;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Message
        private void timerCountNotif_Tick(object sender, EventArgs e)
        {
            afficheCountNotif();
        }

        private void pictureBoxNotification_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (premiereOuverture == 0)
            {
                chargerMessages(ModelMessage.getMessages());
                premiereOuverture = 1;
            } else
            {
                chargerMessages(ModelMessage.getUnreadMessages());
            }
            afficheCountNotif();
            Cursor.Current = Cursors.Default;
            panelMessages.Visible = !panelMessages.Visible;
            timerCountNotif.Start();
        }

        private void timerMessages_Tick(object sender, EventArgs e)
        {
            chargerMessages(ModelMessage.getUnreadMessages());
        }

        private void chargerMessages(List<Entities.Message> messages)
        {
            panelContenuMessages.VerticalScroll.Value = panelContenuMessages.VerticalScroll.Minimum;
            DateOnly dateAujourdhui = DateOnly.FromDateTime(DateTime.Now);
             foreach (Entities.Message message in messages)
             {
                  #region InitialisationVariable
                  int idPers = message.IdPersonne;
                  Entities.Personne personne = ModelPersonne.getPersonneById(idPers);

                  DateOnly dateonly = DateOnly.FromDateTime(message.Date);
                  TimeOnly timeonly = TimeOnly.FromDateTime(message.Date);

                  Label labelDate = new();
                  Label labelPersonne = new();
                  Label labelMessage = new();
                  #endregion

                  #region information de la date
                  if (dateAujourdhui != dateonly)
                  {
                      if (DateOnlyDernierMessage != dateonly)
                      {
                          DateOnlyDernierMessage = dateonly;
                          labelDate.Text = dateonly.ToString();
                          panelContenuMessages.Controls.Add(labelDate);
                          labelDate.Location = new(150, tailleHauteurEnsembleMessage);
                          tailleHauteurEnsembleMessage += labelDate.Height + 5;
                      }
                  }
                  else
                  {
                      if (TimeOnlyDernierMessage.AddMinutes(5) <= timeonly)
                      {
                          TimeOnlyDernierMessage = timeonly;
                          labelDate.Text = timeonly.ToString();
                          panelContenuMessages.Controls.Add(labelDate);
                          labelDate.Location = new(150, tailleHauteurEnsembleMessage);
                          tailleHauteurEnsembleMessage += labelDate.Height + 5;
                      }
                  }
                  #endregion

                  #region Information de la Personne et de la position du nom de la personne
                  if (idPersonneDernierMessage != idPers)
                  {
                      idPersonneDernierMessage = idPers;
                      labelPersonne.Text = $"{personne.Nom} {personne.Prenom} : ";
                      panelContenuMessages.Controls.Add(labelPersonne);

                      if (idPers == idPersonneConnecte)
                      {
                          labelPersonne.Location = new(235, tailleHauteurEnsembleMessage);
                      }
                      else
                      {
                          labelPersonne.Location = new(14, tailleHauteurEnsembleMessage);
                      }
                      tailleHauteurEnsembleMessage += labelPersonne.Height + 5;
                  }
                  #endregion

                  #region Information du message
                  // Création du panel contenant le message
                  Panel panelInfo = new();
                  panelContenuMessages.Controls.Add(panelInfo);
                  panelInfo.BackColor = Color.FromArgb(255, 235, 153);

                  // Ajout du message
                  labelMessage.Text += message.Message1;
                  panelInfo.Controls.Add(labelMessage);
                  labelMessage.Location = new(0, 0);
                  
                  if (idPers == idPersonneConnecte)
                  {
                      panelInfo.Location = new(190, tailleHauteurEnsembleMessage);
                  }
                  else
                  {
                      panelInfo.Location = new(14, tailleHauteurEnsembleMessage);
                  }
                  
                  labelMessage.AutoSize = true;
                  labelMessage.MaximumSize = new(120, 10000);
                  panelInfo.AutoSize = true;
                  panelInfo.Size = new(labelMessage.Width, labelMessage.Height);
                  ComponentStyle componentStyle = new();
                  componentStyle.arrondirBordurObjetSimple(panelInfo, 7);
                  tailleHauteurEnsembleMessage += panelInfo.Height + 10;
                  #endregion

                  #region TextStyle
                  labelDate.AccessibleDefaultActionDescription = "SimSun-ExtB; 14pt; style=Bold";
                  labelDate.ForeColor = Color.FromArgb(255, 235, 153);

                  labelPersonne.AccessibleDefaultActionDescription = "SimSun-ExtB; 18pt; style=Bold";
                  labelPersonne.Font = new Font(labelPersonne.Font, FontStyle.Underline);
                  labelPersonne.ForeColor = Color.FromArgb(255, 235, 153);

                  labelMessage.AccessibleDefaultActionDescription = "SimSun-ExtB; 18pt; style=Bold";
                  labelMessage.ForeColor = Color.FromArgb(0, 0, 0);
                  #endregion
             }

            #region SpacePanel pour laisser de la place après le dernier message
            Panel spacerPanel = new();
            spacerPanel.Size = new Size(panelContenuMessages.Width, 50);
            panelContenuMessages.Controls.Add(spacerPanel);
            spacerPanel.Location = new Point(0, tailleHauteurEnsembleMessage - 50);
            #endregion

            ModelMessage.updateMessageUnReadToRead();
             afficheCountNotif();
        }

        #region TextBoxMessageAction
        private void textBoxMessage_Enter(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == "Votre message ici...")
            {
                textBoxMessage.Text = "";
            }
        }

        private void textBoxMessage_Leave(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == "")
            {
                textBoxMessage.Text = "Votre message ici...";
            }
        }

        private void textBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string trimmedMessage = textBoxMessage.Text.Trim();
                if (!string.IsNullOrWhiteSpace(trimmedMessage) && trimmedMessage != "Votre message ici...")
                {
                    Entities.Message message = new();
                    message.IdPersonne = idPersonneConnecte;
                    message.Message1 = textBoxMessage.Text;
                    message.Date = DateTime.Now;
                    message.EstVue = false;
                    ModelMessage.addMessage(message);
                    textBoxMessage.Text = "";
                    chargerMessages(ModelMessage.getUnreadMessages());

                    // Scroll to the bottom after adding the new message
                    panelContenuMessages.VerticalScroll.Value = panelContenuMessages.VerticalScroll.Maximum;
                }
            }
        }
        #endregion
        
        #endregion
    }
}
