namespace Maison_moel.vue
{
    partial class FormGestionCommandesDechets
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dataGridViewDechets = new DataGridView();
            contextMenuStripDechets = new ContextMenuStrip(components);
            AjouterToolStripMenuItem = new ToolStripMenuItem();
            UpdateToolStripMenuItem = new ToolStripMenuItem();
            SupprimerToolStripMenuItem = new ToolStripMenuItem();
            bindingSourceDechets = new BindingSource(components);
            dataGridViewCommandes = new DataGridView();
            bindingSourceCommande = new BindingSource(components);
            panel1 = new Panel();
            numericUpDownDechets = new NumericUpDown();
            label1 = new Label();
            dataGridViewPureCommandes = new DataGridView();
            bindingSourcePureCommandes = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDechets).BeginInit();
            contextMenuStripDechets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceDechets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCommande).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDechets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPureCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePureCommandes).BeginInit();
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
            dataGridViewDechets.Location = new Point(731, 133);
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
            dataGridViewDechets.Size = new Size(281, 209);
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
            // dataGridViewCommandes
            // 
            dataGridViewCommandes.AllowUserToAddRows = false;
            dataGridViewCommandes.AllowUserToDeleteRows = false;
            dataGridViewCommandes.AllowUserToOrderColumns = true;
            dataGridViewCommandes.AllowUserToResizeRows = false;
            dataGridViewCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCommandes.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewCommandes.BorderStyle = BorderStyle.None;
            dataGridViewCommandes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle4.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewCommandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCommandes.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle5.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewCommandes.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCommandes.EnableHeadersVisualStyles = false;
            dataGridViewCommandes.GridColor = Color.Black;
            dataGridViewCommandes.Location = new Point(12, 12);
            dataGridViewCommandes.MultiSelect = false;
            dataGridViewCommandes.Name = "dataGridViewCommandes";
            dataGridViewCommandes.ReadOnly = true;
            dataGridViewCommandes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle6.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewCommandes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCommandes.RowHeadersVisible = false;
            dataGridViewCommandes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCommandes.Size = new Size(698, 436);
            dataGridViewCommandes.TabIndex = 11;
            dataGridViewCommandes.DoubleClick += dataGridViewCommandes_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 25, 30);
            panel1.Controls.Add(numericUpDownDechets);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(731, 348);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 100);
            panel1.TabIndex = 12;
            // 
            // numericUpDownDechets
            // 
            numericUpDownDechets.BackColor = Color.FromArgb(30, 35, 40);
            numericUpDownDechets.BorderStyle = BorderStyle.None;
            numericUpDownDechets.DecimalPlaces = 2;
            numericUpDownDechets.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            numericUpDownDechets.ForeColor = Color.FromArgb(255, 235, 153);
            numericUpDownDechets.Location = new Point(57, 51);
            numericUpDownDechets.Name = "numericUpDownDechets";
            numericUpDownDechets.Size = new Size(160, 23);
            numericUpDownDechets.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 235, 153);
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(246, 19);
            label1.TabIndex = 0;
            label1.Text = "Poids des Déchets d'ajourd'hui";
            // 
            // dataGridViewPureCommandes
            // 
            dataGridViewPureCommandes.AllowUserToAddRows = false;
            dataGridViewPureCommandes.AllowUserToDeleteRows = false;
            dataGridViewPureCommandes.AllowUserToOrderColumns = true;
            dataGridViewPureCommandes.AllowUserToResizeRows = false;
            dataGridViewPureCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPureCommandes.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewPureCommandes.BorderStyle = BorderStyle.None;
            dataGridViewPureCommandes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle7.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewPureCommandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewPureCommandes.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle8.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewPureCommandes.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewPureCommandes.EnableHeadersVisualStyles = false;
            dataGridViewPureCommandes.GridColor = Color.Black;
            dataGridViewPureCommandes.Location = new Point(731, 12);
            dataGridViewPureCommandes.MultiSelect = false;
            dataGridViewPureCommandes.Name = "dataGridViewPureCommandes";
            dataGridViewPureCommandes.ReadOnly = true;
            dataGridViewPureCommandes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle9.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewPureCommandes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewPureCommandes.RowHeadersVisible = false;
            dataGridViewPureCommandes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPureCommandes.Size = new Size(281, 115);
            dataGridViewPureCommandes.TabIndex = 13;
            // 
            // FormGestionCommandesDechets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 460);
            Controls.Add(dataGridViewPureCommandes);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCommandes);
            Controls.Add(dataGridViewDechets);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionCommandesDechets";
            Text = "FormGestionDechets";
            Load += FormGestionDechets_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDechets).EndInit();
            contextMenuStripDechets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceDechets).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCommande).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDechets).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPureCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePureCommandes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDechets;
        private BindingSource bindingSourceDechets;
        private ContextMenuStrip contextMenuStripDechets;
        private ToolStripMenuItem AjouterToolStripMenuItem;
        private ToolStripMenuItem UpdateToolStripMenuItem;
        private ToolStripMenuItem SupprimerToolStripMenuItem;
        private DataGridView dataGridViewCommandes;
        private BindingSource bindingSourceCommande;
        private Panel panel1;
        private NumericUpDown numericUpDownDechets;
        private Label label1;
        private DataGridView dataGridViewPureCommandes;
        private BindingSource bindingSourcePureCommandes;
    }
}