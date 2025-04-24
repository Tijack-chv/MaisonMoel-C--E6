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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridPersonne = new DataGridView();
            contextMenuStripPersonne = new ContextMenuStrip(components);
            modifierLesInformationsToolStripMenuItem = new ToolStripMenuItem();
            archiverToolStripMenuItem = new ToolStripMenuItem();
            bindingSourcePersonnes = new BindingSource(components);
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtbx_filtrePrenom = new TextBox();
            label_filtrePrenom = new Label();
            txtbx_filtreNom = new TextBox();
            label_filtreNom = new Label();
            buttonRenitialiserFiltre = new Button();
            comboBox_Metier = new ComboBox();
            label_filtreMetier = new Label();
            buttonArchiver = new Button();
            panel_admin = new Panel();
            groupBox = new GroupBox();
            radioButton_non = new RadioButton();
            radioButton_oui = new RadioButton();
            label_archiver = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPersonne).BeginInit();
            contextMenuStripPersonne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonnes).BeginInit();
            panel_admin.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPersonne
            // 
            dataGridPersonne.AllowUserToAddRows = false;
            dataGridPersonne.AllowUserToDeleteRows = false;
            dataGridPersonne.AllowUserToOrderColumns = true;
            dataGridPersonne.AllowUserToResizeRows = false;
            dataGridPersonne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridPersonne.BackgroundColor = Color.FromArgb(50, 55, 60);
            dataGridPersonne.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 35, 40);
            dataGridViewCellStyle1.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 35, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridPersonne.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPersonne.ColumnHeadersHeight = 40;
            dataGridPersonne.ContextMenuStrip = contextMenuStripPersonne;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(70, 75, 80);
            dataGridViewCellStyle2.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridPersonne.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridPersonne.EnableHeadersVisualStyles = false;
            dataGridPersonne.GridColor = Color.Black;
            dataGridPersonne.Location = new Point(367, 63);
            dataGridPersonne.MultiSelect = false;
            dataGridPersonne.Name = "dataGridPersonne";
            dataGridPersonne.ReadOnly = true;
            dataGridPersonne.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(70, 75, 80);
            dataGridViewCellStyle3.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridPersonne.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridPersonne.RowHeadersVisible = false;
            dataGridPersonne.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPersonne.Size = new Size(571, 363);
            dataGridPersonne.TabIndex = 0;
            // 
            // contextMenuStripPersonne
            // 
            contextMenuStripPersonne.Items.AddRange(new ToolStripItem[] { modifierLesInformationsToolStripMenuItem, archiverToolStripMenuItem });
            contextMenuStripPersonne.Name = "contextMenuStrip1";
            contextMenuStripPersonne.Size = new Size(208, 48);
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
            archiverToolStripMenuItem.Text = "Modifier le MDP";
            archiverToolStripMenuItem.Click += modifierMdpToolStripMenuItem_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 35, 40);
            panel5.Location = new Point(938, 45);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(22, 404);
            panel5.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(348, 45);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(22, 404);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(348, 423);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 26);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 35, 40);
            panel3.Location = new Point(348, 45);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 20);
            panel3.TabIndex = 27;
            // 
            // txtbx_filtrePrenom
            // 
            txtbx_filtrePrenom.BackColor = Color.FromArgb(30, 35, 40);
            txtbx_filtrePrenom.BorderStyle = BorderStyle.None;
            txtbx_filtrePrenom.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            txtbx_filtrePrenom.ForeColor = Color.FromArgb(255, 235, 153);
            txtbx_filtrePrenom.Location = new Point(46, 274);
            txtbx_filtrePrenom.Name = "txtbx_filtrePrenom";
            txtbx_filtrePrenom.Size = new Size(211, 20);
            txtbx_filtrePrenom.TabIndex = 66;
            txtbx_filtrePrenom.TextChanged += txtbx_filtrePrenom_TextChanged;
            // 
            // label_filtrePrenom
            // 
            label_filtrePrenom.AutoSize = true;
            label_filtrePrenom.BackColor = Color.Transparent;
            label_filtrePrenom.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            label_filtrePrenom.ForeColor = Color.FromArgb(255, 235, 153);
            label_filtrePrenom.Location = new Point(70, 234);
            label_filtrePrenom.Name = "label_filtrePrenom";
            label_filtrePrenom.Size = new Size(163, 19);
            label_filtrePrenom.TabIndex = 65;
            label_filtrePrenom.Text = "Filtrer par prénom :";
            // 
            // txtbx_filtreNom
            // 
            txtbx_filtreNom.BackColor = Color.FromArgb(30, 35, 40);
            txtbx_filtreNom.BorderStyle = BorderStyle.None;
            txtbx_filtreNom.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            txtbx_filtreNom.ForeColor = Color.FromArgb(255, 235, 153);
            txtbx_filtreNom.Location = new Point(46, 187);
            txtbx_filtreNom.Name = "txtbx_filtreNom";
            txtbx_filtreNom.Size = new Size(211, 20);
            txtbx_filtreNom.TabIndex = 64;
            txtbx_filtreNom.TextChanged += txtbx_filtreNom_TextChanged;
            // 
            // label_filtreNom
            // 
            label_filtreNom.AutoSize = true;
            label_filtreNom.BackColor = Color.Transparent;
            label_filtreNom.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            label_filtreNom.ForeColor = Color.FromArgb(255, 235, 153);
            label_filtreNom.Location = new Point(83, 147);
            label_filtreNom.Name = "label_filtreNom";
            label_filtreNom.Size = new Size(137, 19);
            label_filtreNom.TabIndex = 63;
            label_filtreNom.Text = "Filtrer par nom :";
            // 
            // buttonRenitialiserFiltre
            // 
            buttonRenitialiserFiltre.BackColor = Color.FromArgb(30, 35, 40);
            buttonRenitialiserFiltre.FlatStyle = FlatStyle.Popup;
            buttonRenitialiserFiltre.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            buttonRenitialiserFiltre.ForeColor = Color.FromArgb(255, 235, 153);
            buttonRenitialiserFiltre.Location = new Point(86, 424);
            buttonRenitialiserFiltre.Name = "buttonRenitialiserFiltre";
            buttonRenitialiserFiltre.Size = new Size(138, 23);
            buttonRenitialiserFiltre.TabIndex = 69;
            buttonRenitialiserFiltre.Text = "Rénitialiser Filtre";
            buttonRenitialiserFiltre.TextAlign = ContentAlignment.TopCenter;
            buttonRenitialiserFiltre.UseVisualStyleBackColor = false;
            buttonRenitialiserFiltre.Click += buttonRenitialiserFiltre_Click;
            // 
            // comboBox_Metier
            // 
            comboBox_Metier.BackColor = Color.FromArgb(30, 35, 40);
            comboBox_Metier.FlatStyle = FlatStyle.Popup;
            comboBox_Metier.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            comboBox_Metier.ForeColor = Color.FromArgb(255, 235, 153);
            comboBox_Metier.FormattingEnabled = true;
            comboBox_Metier.Location = new Point(45, 104);
            comboBox_Metier.Name = "comboBox_Metier";
            comboBox_Metier.Size = new Size(213, 27);
            comboBox_Metier.TabIndex = 61;
            comboBox_Metier.SelectedIndexChanged += comboBox_Metier_SelectedIndexChanged;
            // 
            // label_filtreMetier
            // 
            label_filtreMetier.AutoSize = true;
            label_filtreMetier.BackColor = Color.Transparent;
            label_filtreMetier.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            label_filtreMetier.ForeColor = Color.FromArgb(255, 235, 153);
            label_filtreMetier.Location = new Point(75, 70);
            label_filtreMetier.Name = "label_filtreMetier";
            label_filtreMetier.Size = new Size(152, 19);
            label_filtreMetier.TabIndex = 62;
            label_filtreMetier.Text = "Filtrer par métier :";
            // 
            // buttonArchiver
            // 
            buttonArchiver.BackColor = Color.FromArgb(30, 35, 40);
            buttonArchiver.FlatStyle = FlatStyle.Popup;
            buttonArchiver.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            buttonArchiver.ForeColor = Color.FromArgb(255, 235, 153);
            buttonArchiver.Location = new Point(836, 454);
            buttonArchiver.Name = "buttonArchiver";
            buttonArchiver.Size = new Size(124, 34);
            buttonArchiver.TabIndex = 70;
            buttonArchiver.Text = "ARCHIVER";
            buttonArchiver.UseVisualStyleBackColor = false;
            buttonArchiver.Click += buttonArchiver_Click;
            // 
            // panel_admin
            // 
            panel_admin.BackColor = Color.Transparent;
            panel_admin.Controls.Add(groupBox);
            panel_admin.Controls.Add(label_archiver);
            panel_admin.Controls.Add(label_filtreMetier);
            panel_admin.Controls.Add(comboBox_Metier);
            panel_admin.Controls.Add(txtbx_filtrePrenom);
            panel_admin.Controls.Add(label_filtreNom);
            panel_admin.Controls.Add(txtbx_filtreNom);
            panel_admin.Controls.Add(buttonRenitialiserFiltre);
            panel_admin.Controls.Add(label_filtrePrenom);
            panel_admin.Location = new Point(12, 12);
            panel_admin.Name = "panel_admin";
            panel_admin.Size = new Size(312, 468);
            panel_admin.TabIndex = 71;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(radioButton_non);
            groupBox.Controls.Add(radioButton_oui);
            groupBox.Location = new Point(140, 312);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(131, 39);
            groupBox.TabIndex = 73;
            groupBox.TabStop = false;
            // 
            // radioButton_non
            // 
            radioButton_non.AutoSize = true;
            radioButton_non.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            radioButton_non.ForeColor = Color.FromArgb(255, 235, 153);
            radioButton_non.Location = new Point(66, 12);
            radioButton_non.Name = "radioButton_non";
            radioButton_non.Size = new Size(61, 23);
            radioButton_non.TabIndex = 71;
            radioButton_non.TabStop = true;
            radioButton_non.Text = "Non";
            radioButton_non.UseVisualStyleBackColor = true;
            // 
            // radioButton_oui
            // 
            radioButton_oui.AutoSize = true;
            radioButton_oui.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            radioButton_oui.ForeColor = Color.FromArgb(255, 235, 153);
            radioButton_oui.Location = new Point(4, 12);
            radioButton_oui.Name = "radioButton_oui";
            radioButton_oui.Size = new Size(57, 23);
            radioButton_oui.TabIndex = 70;
            radioButton_oui.TabStop = true;
            radioButton_oui.Text = "Oui";
            radioButton_oui.UseVisualStyleBackColor = true;
            radioButton_oui.CheckedChanged += radioButton_oui_CheckedChanged;
            // 
            // label_archiver
            // 
            label_archiver.AutoSize = true;
            label_archiver.BackColor = Color.Transparent;
            label_archiver.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            label_archiver.ForeColor = Color.FromArgb(255, 235, 153);
            label_archiver.Location = new Point(45, 325);
            label_archiver.Name = "label_archiver";
            label_archiver.Size = new Size(91, 19);
            label_archiver.TabIndex = 72;
            label_archiver.Text = "Archiver : ";
            // 
            // FormAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL_modified1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 490);
            Controls.Add(panel_admin);
            Controls.Add(buttonArchiver);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(dataGridPersonne);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdministration";
            Text = "Form_Administration";
            Load += FormAdministration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPersonne).EndInit();
            contextMenuStripPersonne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonnes).EndInit();
            panel_admin.ResumeLayout(false);
            panel_admin.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPersonne;
        private BindingSource bindingSourcePersonnes;
        private Panel panel5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ContextMenuStrip contextMenuStripPersonne;
        private ToolStripMenuItem modifierLesInformationsToolStripMenuItem;
        private ToolStripMenuItem archiverToolStripMenuItem;
        private TextBox txtbx_filtrePrenom;
        private Label label_filtrePrenom;
        private TextBox txtbx_filtreNom;
        private Label label_filtreNom;
        private Button buttonRenitialiserFiltre;
        private ComboBox comboBox_Metier;
        private Label label_filtreMetier;
        private Button buttonArchiver;
        private Panel panel_admin;
        private RadioButton radioButton_oui;
        private Label label_archiver;
        private RadioButton radioButton_non;
        private GroupBox groupBox;
    }
}