using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.controller
{
    public class ComponentMessageBox
    {
        public static string ShowCustomMessageBox(string title, string message)
        {
            // Création d'un formulaire personnalisé
            Form form = new Form();
            form.Text = title;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new System.Drawing.Size(440, 200);
            form.BackgroundImage = Properties.Resources.FOND_ACCUEIL_modified1;
            form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ControlBox = false;

            // Label du message
            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.AutoSize = true;
            lblMessage.Location = new System.Drawing.Point(50, 20);
            lblMessage.Font = new System.Drawing.Font("Baskerville Old Face", 14.25f, System.Drawing.FontStyle.Bold);
            form.Controls.Add(lblMessage);
            lblMessage.BackColor = System.Drawing.Color.Transparent;
            lblMessage.ForeColor = System.Drawing.Color.FromArgb(255, 235, 153);

            // Boutons
            int buttonWidth = 80;
            int buttonHeight = 30;
            int buttonSpacing = 20;
            int totalButtonWidth = (buttonWidth * 4) + (buttonSpacing * 3);
            int startX = (form.ClientSize.Width - totalButtonWidth) / 2;
            int buttonY = 100;

            Button btnEnAttente = new Button() { Text = "En cours", DialogResult = DialogResult.Yes, Size = new System.Drawing.Size(buttonWidth, buttonHeight), Location = new System.Drawing.Point(startX, buttonY) };
            Button btnTermine = new Button() { Text = "Terminé", DialogResult = DialogResult.OK, Size = new System.Drawing.Size(buttonWidth, buttonHeight), Location = new System.Drawing.Point(startX + buttonWidth + buttonSpacing, buttonY) };
            Button btnAnnuler = new Button() { Text = "Annuler", DialogResult = DialogResult.No, Size = new System.Drawing.Size(buttonWidth, buttonHeight), Location = new System.Drawing.Point(startX + (buttonWidth + buttonSpacing) * 2, buttonY) };
            Button btnRetour = new Button() { Text = "Retour", DialogResult = DialogResult.Cancel, Size = new System.Drawing.Size(buttonWidth, buttonHeight), Location = new System.Drawing.Point(startX + (buttonWidth + buttonSpacing) * 3, buttonY) };

            btnFormat(btnEnAttente);
            btnFormat(btnTermine);
            btnFormat(btnAnnuler);
            btnFormat(btnRetour);

            // Ajouter les éléments au formulaire
            form.Controls.Add(lblMessage);
            form.Controls.Add(btnEnAttente);
            form.Controls.Add(btnTermine);
            form.Controls.Add(btnAnnuler);
            form.Controls.Add(btnRetour);

            // Définir l'acceptation du bouton (si l'utilisateur appuie sur "Entrée")
            form.AcceptButton = btnTermine;
            form.CancelButton = btnAnnuler;

            // Afficher le formulaire et capturer le résultat
            DialogResult result = form.ShowDialog();

            // Retourner la valeur choisie
            switch (result)
            {
                case DialogResult.Yes:
                    return "En préparation";
                case DialogResult.OK:
                    return "Terminé";
                case DialogResult.No:
                    return "Annulée";
                case DialogResult.Cancel:
                    return "Retour";
                default:
                    return "Aucune sélection";
            }
        }

        public static void btnFormat(Button btn)
        {
            btn.BackColor = Color.FromArgb(25, 30, 35);
            btn.FlatStyle = FlatStyle.Popup;
            btn.ForeColor = Color.FromArgb(255, 235, 153);
            btn.Font = new System.Drawing.Font("Baskerville Old Face", 12.75f, System.Drawing.FontStyle.Bold);
            btn.AutoSize = true;
        }
    }
}
