namespace Maison_moel.vue
{
    partial class FormAdministration
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
            dataGridPersonne = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            modifierLesInformationsToolStripMenuItem = new ToolStripMenuItem();
            archiverToolStripMenuItem = new ToolStripMenuItem();
            bindingSourcePersonnes = new BindingSource(components);
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel_filtre = new Panel();
            label_filtreMetier = new Label();
            comboBox_Metier = new ComboBox();
            buttonRenitialiserFiltre = new Button();
            label_filtreNom = new Label();
            dateTimePicker_DateNaissance = new DateTimePicker();
            txtbx_filtreNom = new TextBox();
            label1 = new Label();
            label_filtrePrenom = new Label();
            txtbx_filtrePrenom = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridPersonne).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonnes).BeginInit();
            panel_filtre.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPersonne
            // 
            dataGridPersonne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPersonne.ContextMenuStrip = contextMenuStrip1;
            dataGridPersonne.GridColor = Color.FromArgb(255, 235, 153);
            dataGridPersonne.Location = new Point(382, 93);
            dataGridPersonne.Name = "dataGridPersonne";
            dataGridPersonne.Size = new Size(571, 363);
            dataGridPersonne.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { modifierLesInformationsToolStripMenuItem, archiverToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(208, 48);
            // 
            // modifierLesInformationsToolStripMenuItem
            // 
            modifierLesInformationsToolStripMenuItem.Name = "modifierLesInformationsToolStripMenuItem";
            modifierLesInformationsToolStripMenuItem.Size = new Size(207, 22);
            modifierLesInformationsToolStripMenuItem.Text = "Modifier les informations";
            modifierLesInformationsToolStripMenuItem.Click += ModifierPersonnelToolStripMenuItem_Click;
            // 
            // archiverToolStripMenuItem
            // 
            archiverToolStripMenuItem.Name = "archiverToolStripMenuItem";
            archiverToolStripMenuItem.Size = new Size(207, 22);
            archiverToolStripMenuItem.Text = "Archiver le salarié";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 35, 40);
            panel5.Location = new Point(953, 75);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(22, 404);
            panel5.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(363, 75);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(22, 404);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(363, 453);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 26);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 35, 40);
            panel3.Location = new Point(363, 75);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 20);
            panel3.TabIndex = 27;
            // 
            // panel_filtre
            // 
            panel_filtre.BackColor = Color.Transparent;
            panel_filtre.Controls.Add(label_filtreMetier);
            panel_filtre.Controls.Add(comboBox_Metier);
            panel_filtre.Controls.Add(buttonRenitialiserFiltre);
            panel_filtre.Controls.Add(label_filtreNom);
            panel_filtre.Controls.Add(dateTimePicker_DateNaissance);
            panel_filtre.Controls.Add(txtbx_filtreNom);
            panel_filtre.Controls.Add(label1);
            panel_filtre.Controls.Add(label_filtrePrenom);
            panel_filtre.Controls.Add(txtbx_filtrePrenom);
            panel_filtre.Location = new Point(22, 38);
            panel_filtre.Name = "panel_filtre";
            panel_filtre.Size = new Size(312, 468);
            panel_filtre.TabIndex = 52;
            // 
            // label_filtreMetier
            // 
            label_filtreMetier.AutoSize = true;
            label_filtreMetier.BackColor = Color.Transparent;
            label_filtreMetier.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtreMetier.Location = new Point(30, 44);
            label_filtreMetier.Name = "label_filtreMetier";
            label_filtreMetier.Size = new Size(152, 20);
            label_filtreMetier.TabIndex = 62;
            label_filtreMetier.Text = "Filtrer par métier :";
            // 
            // comboBox_Metier
            // 
            comboBox_Metier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Metier.FormattingEnabled = true;
            comboBox_Metier.Location = new Point(28, 78);
            comboBox_Metier.Name = "comboBox_Metier";
            comboBox_Metier.Size = new Size(213, 23);
            comboBox_Metier.TabIndex = 61;
            // 
            // buttonRenitialiserFiltre
            // 
            buttonRenitialiserFiltre.BackColor = Color.FromArgb(30, 35, 40);
            buttonRenitialiserFiltre.FlatStyle = FlatStyle.Popup;
            buttonRenitialiserFiltre.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRenitialiserFiltre.ForeColor = Color.White;
            buttonRenitialiserFiltre.Location = new Point(30, 402);
            buttonRenitialiserFiltre.Name = "buttonRenitialiserFiltre";
            buttonRenitialiserFiltre.Size = new Size(138, 23);
            buttonRenitialiserFiltre.TabIndex = 69;
            buttonRenitialiserFiltre.Text = "Rénitialiser Filtre";
            buttonRenitialiserFiltre.UseVisualStyleBackColor = false;
            // 
            // label_filtreNom
            // 
            label_filtreNom.AutoSize = true;
            label_filtreNom.BackColor = Color.Transparent;
            label_filtreNom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtreNom.Location = new Point(28, 121);
            label_filtreNom.Name = "label_filtreNom";
            label_filtreNom.Size = new Size(136, 20);
            label_filtreNom.TabIndex = 63;
            label_filtreNom.Text = "Filtrer par nom :";
            // 
            // dateTimePicker_DateNaissance
            // 
            dateTimePicker_DateNaissance.Location = new Point(30, 337);
            dateTimePicker_DateNaissance.MaxDate = new DateTime(2025, 1, 17, 0, 0, 0, 0);
            dateTimePicker_DateNaissance.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dateTimePicker_DateNaissance.Name = "dateTimePicker_DateNaissance";
            dateTimePicker_DateNaissance.Size = new Size(211, 23);
            dateTimePicker_DateNaissance.TabIndex = 68;
            dateTimePicker_DateNaissance.Value = new DateTime(1975, 1, 1, 0, 0, 0, 0);
            // 
            // txtbx_filtreNom
            // 
            txtbx_filtreNom.Location = new Point(30, 161);
            txtbx_filtreNom.Name = "txtbx_filtreNom";
            txtbx_filtreNom.Size = new Size(211, 23);
            txtbx_filtreNom.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(30, 297);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 67;
            label1.Text = "Filtrer par Date de Naissance :";
            // 
            // label_filtrePrenom
            // 
            label_filtrePrenom.AutoSize = true;
            label_filtrePrenom.BackColor = Color.Transparent;
            label_filtrePrenom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtrePrenom.Location = new Point(28, 208);
            label_filtrePrenom.Name = "label_filtrePrenom";
            label_filtrePrenom.Size = new Size(162, 20);
            label_filtrePrenom.TabIndex = 65;
            label_filtrePrenom.Text = "Filtrer par prénom :";
            // 
            // txtbx_filtrePrenom
            // 
            txtbx_filtrePrenom.Location = new Point(30, 248);
            txtbx_filtrePrenom.Name = "txtbx_filtrePrenom";
            txtbx_filtrePrenom.Size = new Size(211, 23);
            txtbx_filtrePrenom.TabIndex = 66;
            // 
            // FormAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_1500_1500_1_;
            ClientSize = new Size(1010, 557);
            Controls.Add(panel_filtre);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(dataGridPersonne);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdministration";
            Text = "Form_Administration";
            Load += FormAdministration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPersonne).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonnes).EndInit();
            panel_filtre.ResumeLayout(false);
            panel_filtre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPersonne;
        private BindingSource bindingSourcePersonnes;
        private Panel panel5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem modifierLesInformationsToolStripMenuItem;
        private ToolStripMenuItem archiverToolStripMenuItem;
        private Panel panel_filtre;
        private Label label_filtreMetier;
        private ComboBox comboBox_Metier;
        private Button buttonRenitialiserFiltre;
        private Label label_filtreNom;
        private DateTimePicker dateTimePicker_DateNaissance;
        private TextBox txtbx_filtreNom;
        private Label label1;
        private Label label_filtrePrenom;
        private TextBox txtbx_filtrePrenom;
    }
}