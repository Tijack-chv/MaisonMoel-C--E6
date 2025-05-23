﻿namespace Maison_moel.vue
{
    partial class FormMenuCuisinier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gestionCommandesDechetsToolStripMenuItem = new ToolStripMenuItem();
            gestionReapprovisionnementsToolStripMenuItem = new ToolStripMenuItem();
            panelSousAffichage = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(25, 30, 35);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionCommandesDechetsToolStripMenuItem, gestionReapprovisionnementsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1024, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionCommandesDechetsToolStripMenuItem
            // 
            gestionCommandesDechetsToolStripMenuItem.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            gestionCommandesDechetsToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            gestionCommandesDechetsToolStripMenuItem.Name = "gestionCommandesDechetsToolStripMenuItem";
            gestionCommandesDechetsToolStripMenuItem.Size = new Size(369, 26);
            gestionCommandesDechetsToolStripMenuItem.Text = "Gestion des Commandes et des Déchets";
            gestionCommandesDechetsToolStripMenuItem.Click += gestionDechetsToolStripMenuItem_Click;
            // 
            // gestionReapprovisionnementsToolStripMenuItem
            // 
            gestionReapprovisionnementsToolStripMenuItem.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            gestionReapprovisionnementsToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            gestionReapprovisionnementsToolStripMenuItem.Name = "gestionReapprovisionnementsToolStripMenuItem";
            gestionReapprovisionnementsToolStripMenuItem.Size = new Size(326, 26);
            gestionReapprovisionnementsToolStripMenuItem.Text = "Gestion des Réapprovisionnements";
            gestionReapprovisionnementsToolStripMenuItem.Click += gestionReaprovisionnementsToolStripMenuItem_Click;
            // 
            // panelSousAffichage
            // 
            panelSousAffichage.BackColor = Color.Transparent;
            panelSousAffichage.BackgroundImage = Properties.Resources.FOND_ACCUEIL;
            panelSousAffichage.BackgroundImageLayout = ImageLayout.Stretch;
            panelSousAffichage.Dock = DockStyle.Fill;
            panelSousAffichage.Location = new Point(0, 30);
            panelSousAffichage.Name = "panelSousAffichage";
            panelSousAffichage.Size = new Size(1024, 460);
            panelSousAffichage.TabIndex = 1;
            // 
            // FormMenuCuisinier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 490);
            Controls.Add(panelSousAffichage);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FormMenuCuisinier";
            Text = "FormMenuCuisinier";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionCommandesToolStripMenuItem;
        private ToolStripMenuItem gestionCommandesDechetsToolStripMenuItem;
        private Panel panelSousAffichage;
        private ToolStripMenuItem gestionReapprovisionnementsToolStripMenuItem;
    }
}