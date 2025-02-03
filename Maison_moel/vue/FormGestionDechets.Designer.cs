namespace Maison_moel.vue
{
    partial class FormGestionDechets
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewDechets = new DataGridView();
            contextMenuStripDechets = new ContextMenuStrip(components);
            AjouterToolStripMenuItem = new ToolStripMenuItem();
            UpdateToolStripMenuItem = new ToolStripMenuItem();
            SupprimerToolStripMenuItem = new ToolStripMenuItem();
            bindingSourceDechets = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDechets).BeginInit();
            contextMenuStripDechets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceDechets).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDechets
            // 
            dataGridViewDechets.AllowUserToAddRows = false;
            dataGridViewDechets.AllowUserToDeleteRows = false;
            dataGridViewDechets.AllowUserToOrderColumns = true;
            dataGridViewDechets.AllowUserToResizeRows = false;
            dataGridViewDechets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDechets.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewDechets.BorderStyle = BorderStyle.None;
            dataGridViewDechets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDechets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDechets.ColumnHeadersHeight = 30;
            dataGridViewDechets.ContextMenuStrip = contextMenuStripDechets;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDechets.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDechets.EnableHeadersVisualStyles = false;
            dataGridViewDechets.GridColor = Color.Black;
            dataGridViewDechets.Location = new Point(362, 12);
            dataGridViewDechets.MultiSelect = false;
            dataGridViewDechets.Name = "dataGridViewDechets";
            dataGridViewDechets.ReadOnly = true;
            dataGridViewDechets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDechets.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDechets.RowHeadersVisible = false;
            dataGridViewDechets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDechets.Size = new Size(246, 436);
            dataGridViewDechets.TabIndex = 10;
            // 
            // contextMenuStripDechets
            // 
            contextMenuStripDechets.BackColor = Color.FromArgb(15, 20, 25);
            contextMenuStripDechets.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            contextMenuStripDechets.Items.AddRange(new ToolStripItem[] { AjouterToolStripMenuItem, UpdateToolStripMenuItem, SupprimerToolStripMenuItem });
            contextMenuStripDechets.Name = "contextMenuStripPlats";
            contextMenuStripDechets.Size = new Size(354, 70);
            // 
            // AjouterToolStripMenuItem
            // 
            AjouterToolStripMenuItem.BackgroundImage = Properties.Resources.gradient_1920_1080V2;
            AjouterToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            AjouterToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            AjouterToolStripMenuItem.Image = Properties.Resources.Arrow_Right_I01_watermarked_2k;
            AjouterToolStripMenuItem.ImageTransparentColor = Color.FromArgb(255, 235, 153);
            AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem";
            AjouterToolStripMenuItem.Size = new Size(353, 22);
            AjouterToolStripMenuItem.Text = "Ajouter les déchets d'aujourd'hui";
            AjouterToolStripMenuItem.Click += AjouterToolStripMenuItem_Click;
            // 
            // UpdateToolStripMenuItem
            // 
            UpdateToolStripMenuItem.BackgroundImage = Properties.Resources.gradient_1920_1080V2;
            UpdateToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            UpdateToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            UpdateToolStripMenuItem.Image = Properties.Resources.Arrow_Right_I01_watermarked_2k;
            UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            UpdateToolStripMenuItem.Size = new Size(353, 22);
            UpdateToolStripMenuItem.Text = "Mettre à jour les déchets d'aujourd'hui";
            UpdateToolStripMenuItem.Click += UpdateToolStripMenuItem_Click;
            // 
            // SupprimerToolStripMenuItem
            // 
            SupprimerToolStripMenuItem.BackgroundImage = Properties.Resources.gradient_1920_1080V2;
            SupprimerToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            SupprimerToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            SupprimerToolStripMenuItem.Image = Properties.Resources.Arrow_Right_I01_watermarked_2k;
            SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem";
            SupprimerToolStripMenuItem.Size = new Size(353, 22);
            SupprimerToolStripMenuItem.Text = "Supprimer les déchets d'aujourd'hui";
            SupprimerToolStripMenuItem.Click += SupprimerToolStripMenuItem_Click;
            // 
            // FormGestionDechets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 460);
            Controls.Add(dataGridViewDechets);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionDechets";
            Text = "FormGestionDechets";
            Load += FormGestionDechets_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDechets).EndInit();
            contextMenuStripDechets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceDechets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDechets;
        private BindingSource bindingSourceDechets;
        private ContextMenuStrip contextMenuStripDechets;
        private ToolStripMenuItem AjouterToolStripMenuItem;
        private ToolStripMenuItem UpdateToolStripMenuItem;
        private ToolStripMenuItem SupprimerToolStripMenuItem;
    }
}