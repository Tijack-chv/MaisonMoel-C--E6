namespace Maison_moel.vue
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
            gestionCommandesToolStripMenuItem = new ToolStripMenuItem();
            gestionDechetsToolStripMenuItem = new ToolStripMenuItem();
            gestionReapprovisionnementsToolStripMenuItem = new ToolStripMenuItem();
            panelSousAffichage = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(35, 40, 45);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionCommandesToolStripMenuItem, gestionDechetsToolStripMenuItem, gestionReapprovisionnementsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1026, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionCommandesToolStripMenuItem
            // 
            gestionCommandesToolStripMenuItem.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gestionCommandesToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            gestionCommandesToolStripMenuItem.Name = "gestionCommandesToolStripMenuItem";
            gestionCommandesToolStripMenuItem.Size = new Size(236, 26);
            gestionCommandesToolStripMenuItem.Text = "Gestion des Commandes";
            gestionCommandesToolStripMenuItem.Click += gestionCommandesToolStripMenuItem_Click;
            // 
            // gestionDechetsToolStripMenuItem
            // 
            gestionDechetsToolStripMenuItem.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            gestionDechetsToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            gestionDechetsToolStripMenuItem.Name = "gestionDechetsToolStripMenuItem";
            gestionDechetsToolStripMenuItem.Size = new Size(195, 26);
            gestionDechetsToolStripMenuItem.Text = "Gestion des déchets";
            gestionDechetsToolStripMenuItem.Click += gestionDechetsToolStripMenuItem_Click;
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
            panelSousAffichage.Dock = DockStyle.Fill;
            panelSousAffichage.Location = new Point(0, 30);
            panelSousAffichage.Name = "panelSousAffichage";
            panelSousAffichage.Size = new Size(1026, 566);
            panelSousAffichage.TabIndex = 1;
            // 
            // FormMenuCuisinier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1026, 596);
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
        private ToolStripMenuItem gestionDechetsToolStripMenuItem;
        private Panel panelSousAffichage;
        private ToolStripMenuItem gestionReapprovisionnementsToolStripMenuItem;
    }
}