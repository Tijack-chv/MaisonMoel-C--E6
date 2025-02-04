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
            txtbx_filtrePrenom = new TextBox();
            label_filtrePrenom = new Label();
            label1 = new Label();
            txtbx_filtreNom = new TextBox();
            dateTimePicker_DateNaissance = new DateTimePicker();
            label_filtreNom = new Label();
            buttonRenitialiserFiltre = new Button();
            comboBox_Metier = new ComboBox();
            label_filtreMetier = new Label();
            button1 = new Button();
            panel_admin = new Panel();
            groupBox = new GroupBox();
            radioButton_non = new RadioButton();
            radioButton_oui = new RadioButton();
            label_archiver = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPersonne).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonnes).BeginInit();
            panel_admin.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridPersonne
            // 
            dataGridPersonne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPersonne.ContextMenuStrip = contextMenuStrip1;
            dataGridPersonne.GridColor = Color.FromArgb(255, 235, 153);
            dataGridPersonne.Location = new Point(367, 63);
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
            archiverToolStripMenuItem.Text = "Modifier le MDP";
            archiverToolStripMenuItem.Click += archiverToolStripMenuItem_Click;
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
            txtbx_filtrePrenom.Location = new Point(37, 237);
            txtbx_filtrePrenom.Name = "txtbx_filtrePrenom";
            txtbx_filtrePrenom.Size = new Size(211, 23);
            txtbx_filtrePrenom.TabIndex = 66;
            txtbx_filtrePrenom.TextChanged += txtbx_filtrePrenom_TextChanged;
            // 
            // label_filtrePrenom
            // 
            label_filtrePrenom.AutoSize = true;
            label_filtrePrenom.BackColor = Color.Transparent;
            label_filtrePrenom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtrePrenom.Location = new Point(35, 197);
            label_filtrePrenom.Name = "label_filtrePrenom";
            label_filtrePrenom.Size = new Size(162, 20);
            label_filtrePrenom.TabIndex = 65;
            label_filtrePrenom.Text = "Filtrer par prénom :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(37, 286);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 67;
            label1.Text = "Filtrer par Date de Naissance :";
            // 
            // txtbx_filtreNom
            // 
            txtbx_filtreNom.Location = new Point(37, 150);
            txtbx_filtreNom.Name = "txtbx_filtreNom";
            txtbx_filtreNom.Size = new Size(211, 23);
            txtbx_filtreNom.TabIndex = 64;
            txtbx_filtreNom.TextChanged += txtbx_filtreNom_TextChanged;
            // 
            // dateTimePicker_DateNaissance
            // 
            dateTimePicker_DateNaissance.Location = new Point(37, 326);
            dateTimePicker_DateNaissance.MaxDate = new DateTime(2025, 1, 17, 0, 0, 0, 0);
            dateTimePicker_DateNaissance.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dateTimePicker_DateNaissance.Name = "dateTimePicker_DateNaissance";
            dateTimePicker_DateNaissance.Size = new Size(211, 23);
            dateTimePicker_DateNaissance.TabIndex = 68;
            dateTimePicker_DateNaissance.Value = new DateTime(1975, 1, 1, 0, 0, 0, 0);
            dateTimePicker_DateNaissance.ValueChanged += dateTimePicker_DateNaissance_ValueChanged;
            // 
            // label_filtreNom
            // 
            label_filtreNom.AutoSize = true;
            label_filtreNom.BackColor = Color.Transparent;
            label_filtreNom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtreNom.Location = new Point(35, 110);
            label_filtreNom.Name = "label_filtreNom";
            label_filtreNom.Size = new Size(136, 20);
            label_filtreNom.TabIndex = 63;
            label_filtreNom.Text = "Filtrer par nom :";
            // 
            // buttonRenitialiserFiltre
            // 
            buttonRenitialiserFiltre.BackColor = Color.FromArgb(30, 35, 40);
            buttonRenitialiserFiltre.FlatStyle = FlatStyle.Popup;
            buttonRenitialiserFiltre.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRenitialiserFiltre.ForeColor = Color.White;
            buttonRenitialiserFiltre.Location = new Point(37, 428);
            buttonRenitialiserFiltre.Name = "buttonRenitialiserFiltre";
            buttonRenitialiserFiltre.Size = new Size(138, 23);
            buttonRenitialiserFiltre.TabIndex = 69;
            buttonRenitialiserFiltre.Text = "Rénitialiser Filtre";
            buttonRenitialiserFiltre.UseVisualStyleBackColor = false;
            buttonRenitialiserFiltre.Click += buttonRenitialiserFiltre_Click;
            // 
            // comboBox_Metier
            // 
            comboBox_Metier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Metier.FormattingEnabled = true;
            comboBox_Metier.Location = new Point(35, 67);
            comboBox_Metier.Name = "comboBox_Metier";
            comboBox_Metier.Size = new Size(213, 23);
            comboBox_Metier.TabIndex = 61;
            comboBox_Metier.SelectedIndexChanged += comboBox_Metier_SelectedIndexChanged;
            // 
            // label_filtreMetier
            // 
            label_filtreMetier.AutoSize = true;
            label_filtreMetier.BackColor = Color.Transparent;
            label_filtreMetier.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtreMetier.Location = new Point(37, 33);
            label_filtreMetier.Name = "label_filtreMetier";
            label_filtreMetier.Size = new Size(152, 20);
            label_filtreMetier.TabIndex = 62;
            label_filtreMetier.Text = "Filtrer par métier :";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Location = new Point(848, 454);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 70;
            button1.Text = "ARCHIVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel_admin
            // 
            panel_admin.BackColor = Color.Transparent;
            panel_admin.Controls.Add(groupBox);
            panel_admin.Controls.Add(label_archiver);
            panel_admin.Controls.Add(label_filtreMetier);
            panel_admin.Controls.Add(comboBox_Metier);
            panel_admin.Controls.Add(txtbx_filtrePrenom);
            panel_admin.Controls.Add(label1);
            panel_admin.Controls.Add(label_filtreNom);
            panel_admin.Controls.Add(txtbx_filtreNom);
            panel_admin.Controls.Add(buttonRenitialiserFiltre);
            panel_admin.Controls.Add(label_filtrePrenom);
            panel_admin.Controls.Add(dateTimePicker_DateNaissance);
            panel_admin.Location = new Point(12, 12);
            panel_admin.Name = "panel_admin";
            panel_admin.Size = new Size(312, 468);
            panel_admin.TabIndex = 71;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(radioButton_non);
            groupBox.Controls.Add(radioButton_oui);
            groupBox.Location = new Point(131, 365);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(117, 39);
            groupBox.TabIndex = 73;
            groupBox.TabStop = false;
            // 
            // radioButton_non
            // 
            radioButton_non.AutoSize = true;
            radioButton_non.Location = new Point(63, 13);
            radioButton_non.Name = "radioButton_non";
            radioButton_non.Size = new Size(48, 19);
            radioButton_non.TabIndex = 71;
            radioButton_non.TabStop = true;
            radioButton_non.Text = "Non";
            radioButton_non.UseVisualStyleBackColor = true;
            // 
            // radioButton_oui
            // 
            radioButton_oui.AutoSize = true;
            radioButton_oui.Location = new Point(8, 13);
            radioButton_oui.Name = "radioButton_oui";
            radioButton_oui.Size = new Size(44, 19);
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
            label_archiver.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_archiver.Location = new Point(36, 378);
            label_archiver.Name = "label_archiver";
            label_archiver.Size = new Size(89, 20);
            label_archiver.TabIndex = 72;
            label_archiver.Text = "Archiver : ";
            // 
            // FormAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_1500_1500_1_;
            ClientSize = new Size(1024, 490);
            Controls.Add(panel_admin);
            Controls.Add(button1);
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem modifierLesInformationsToolStripMenuItem;
        private ToolStripMenuItem archiverToolStripMenuItem;
        private TextBox txtbx_filtrePrenom;
        private Label label_filtrePrenom;
        private Label label1;
        private TextBox txtbx_filtreNom;
        private DateTimePicker dateTimePicker_DateNaissance;
        private Label label_filtreNom;
        private Button buttonRenitialiserFiltre;
        private ComboBox comboBox_Metier;
        private Label label_filtreMetier;
        private Button button1;
        private Panel panel_admin;
        private RadioButton radioButton_oui;
        private Label label_archiver;
        private RadioButton radioButton_non;
        private GroupBox groupBox;
    }
}