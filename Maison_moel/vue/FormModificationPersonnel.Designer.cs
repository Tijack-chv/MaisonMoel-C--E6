﻿namespace Maison_moel.vue
{
    partial class FormModificationPersonnel
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
            textBox_nom = new TextBox();
            textBox_prenom = new TextBox();
            textBox_email = new TextBox();
            dtp_datenaissance = new DateTimePicker();
            label_dateNaiss = new Label();
            label_nom = new Label();
            label_prenom = new Label();
            label_email = new Label();
            numericUpDown_salaire = new NumericUpDown();
            label_salaire = new Label();
            label_role = new Label();
            comboBox_role = new ComboBox();
            button_valider = new Button();
            button_annuler = new Button();
            bindingSource_role = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_salaire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_role).BeginInit();
            SuspendLayout();
            // 
            // textBox_nom
            // 
            textBox_nom.BackColor = Color.FromArgb(30, 35, 40);
            textBox_nom.BorderStyle = BorderStyle.FixedSingle;
            textBox_nom.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            textBox_nom.ForeColor = Color.FromArgb(255, 235, 153);
            textBox_nom.Location = new Point(39, 41);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(202, 27);
            textBox_nom.TabIndex = 0;
            // 
            // textBox_prenom
            // 
            textBox_prenom.BackColor = Color.FromArgb(30, 35, 40);
            textBox_prenom.BorderStyle = BorderStyle.FixedSingle;
            textBox_prenom.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            textBox_prenom.ForeColor = Color.FromArgb(255, 235, 153);
            textBox_prenom.Location = new Point(39, 101);
            textBox_prenom.Name = "textBox_prenom";
            textBox_prenom.Size = new Size(202, 27);
            textBox_prenom.TabIndex = 1;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(30, 35, 40);
            textBox_email.BorderStyle = BorderStyle.FixedSingle;
            textBox_email.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            textBox_email.ForeColor = Color.FromArgb(255, 235, 153);
            textBox_email.Location = new Point(39, 162);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(202, 27);
            textBox_email.TabIndex = 2;
            // 
            // dtp_datenaissance
            // 
            dtp_datenaissance.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_datenaissance.Location = new Point(39, 231);
            dtp_datenaissance.Name = "dtp_datenaissance";
            dtp_datenaissance.Size = new Size(202, 22);
            dtp_datenaissance.TabIndex = 3;
            // 
            // label_dateNaiss
            // 
            label_dateNaiss.AutoSize = true;
            label_dateNaiss.BackColor = Color.Transparent;
            label_dateNaiss.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_dateNaiss.ForeColor = Color.FromArgb(255, 235, 153);
            label_dateNaiss.Location = new Point(60, 206);
            label_dateNaiss.Name = "label_dateNaiss";
            label_dateNaiss.Size = new Size(161, 20);
            label_dateNaiss.TabIndex = 4;
            label_dateNaiss.Text = "Date de Naissance";
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.BackColor = Color.Transparent;
            label_nom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_nom.ForeColor = Color.FromArgb(255, 235, 153);
            label_nom.Location = new Point(118, 18);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(45, 20);
            label_nom.TabIndex = 5;
            label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            label_prenom.AutoSize = true;
            label_prenom.BackColor = Color.Transparent;
            label_prenom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_prenom.ForeColor = Color.FromArgb(255, 235, 153);
            label_prenom.Location = new Point(105, 78);
            label_prenom.Name = "label_prenom";
            label_prenom.Size = new Size(70, 20);
            label_prenom.TabIndex = 6;
            label_prenom.Text = "Prénom";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.BackColor = Color.Transparent;
            label_email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_email.ForeColor = Color.FromArgb(255, 235, 153);
            label_email.Location = new Point(114, 139);
            label_email.Name = "label_email";
            label_email.Size = new Size(53, 20);
            label_email.TabIndex = 7;
            label_email.Text = "Email";
            // 
            // numericUpDown_salaire
            // 
            numericUpDown_salaire.BackColor = Color.FromArgb(30, 35, 40);
            numericUpDown_salaire.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown_salaire.DecimalPlaces = 2;
            numericUpDown_salaire.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            numericUpDown_salaire.ForeColor = Color.FromArgb(255, 235, 153);
            numericUpDown_salaire.Location = new Point(39, 299);
            numericUpDown_salaire.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_salaire.Name = "numericUpDown_salaire";
            numericUpDown_salaire.Size = new Size(202, 27);
            numericUpDown_salaire.TabIndex = 19;
            // 
            // label_salaire
            // 
            label_salaire.AutoSize = true;
            label_salaire.BackColor = Color.Transparent;
            label_salaire.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_salaire.ForeColor = Color.FromArgb(255, 235, 153);
            label_salaire.Location = new Point(108, 276);
            label_salaire.Name = "label_salaire";
            label_salaire.Size = new Size(65, 20);
            label_salaire.TabIndex = 18;
            label_salaire.Text = "Salaire";
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.BackColor = Color.Transparent;
            label_role.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_role.ForeColor = Color.FromArgb(255, 235, 153);
            label_role.Location = new Point(117, 339);
            label_role.Name = "label_role";
            label_role.Size = new Size(46, 20);
            label_role.TabIndex = 20;
            label_role.Text = "Role";
            // 
            // comboBox_role
            // 
            comboBox_role.BackColor = Color.FromArgb(30, 35, 40);
            comboBox_role.FlatStyle = FlatStyle.Popup;
            comboBox_role.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            comboBox_role.ForeColor = Color.FromArgb(255, 235, 153);
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Location = new Point(39, 362);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(202, 27);
            comboBox_role.TabIndex = 21;
            // 
            // button_valider
            // 
            button_valider.BackColor = Color.FromArgb(255, 235, 153);
            button_valider.FlatStyle = FlatStyle.Popup;
            button_valider.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            button_valider.Location = new Point(39, 411);
            button_valider.Name = "button_valider";
            button_valider.Size = new Size(108, 31);
            button_valider.TabIndex = 22;
            button_valider.Text = "VALIDER";
            button_valider.UseVisualStyleBackColor = false;
            button_valider.Click += button_valider_Click;
            // 
            // button_annuler
            // 
            button_annuler.BackColor = Color.FromArgb(255, 235, 153);
            button_annuler.FlatStyle = FlatStyle.Popup;
            button_annuler.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            button_annuler.Location = new Point(153, 411);
            button_annuler.Name = "button_annuler";
            button_annuler.Size = new Size(108, 31);
            button_annuler.TabIndex = 23;
            button_annuler.Text = "ANNULER";
            button_annuler.UseVisualStyleBackColor = false;
            button_annuler.Click += button_annuler_Click;
            // 
            // FormModificationPersonnel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            ClientSize = new Size(312, 468);
            Controls.Add(button_annuler);
            Controls.Add(button_valider);
            Controls.Add(comboBox_role);
            Controls.Add(label_role);
            Controls.Add(numericUpDown_salaire);
            Controls.Add(label_salaire);
            Controls.Add(label_email);
            Controls.Add(label_prenom);
            Controls.Add(label_nom);
            Controls.Add(label_dateNaiss);
            Controls.Add(dtp_datenaissance);
            Controls.Add(textBox_email);
            Controls.Add(textBox_prenom);
            Controls.Add(textBox_nom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificationPersonnel";
            Text = "FormModificationCuisinier";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_salaire).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_role).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_nom;
        private TextBox textBox_prenom;
        private TextBox textBox_email;
        private DateTimePicker dtp_datenaissance;
        private Label label_dateNaiss;
        private Label label_nom;
        private Label label_prenom;
        private Label label_email;
        private NumericUpDown numericUpDown_salaire;
        private Label label_salaire;
        private Label label_role;
        private ComboBox comboBox_role;
        private Button button_valider;
        private Button button_annuler;
        private BindingSource bindingSource_role;
    }
}