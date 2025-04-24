namespace Maison_moel.vue
{
    partial class FormAjoutMembre
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_nom = new TextBox();
            textBox_mdp = new TextBox();
            textBox_email = new TextBox();
            textBox_prenom = new TextBox();
            textBox_confirmMdp = new TextBox();
            label6 = new Label();
            dateTimePicker_naissance = new DateTimePicker();
            button_ajouter = new Button();
            button_annuler = new Button();
            comboBox_metier = new ComboBox();
            label7 = new Label();
            label_salaire = new Label();
            nud_salaire = new NumericUpDown();
            label_role = new Label();
            comboBox_role = new ComboBox();
            bindingSource_role = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)nud_salaire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_role).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 235, 153);
            label1.Location = new Point(115, 99);
            label1.Name = "label1";
            label1.Size = new Size(46, 22);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 235, 153);
            label2.Location = new Point(115, 152);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 1;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 235, 153);
            label3.Location = new Point(115, 203);
            label3.Name = "label3";
            label3.Size = new Size(54, 22);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 235, 153);
            label4.Location = new Point(115, 253);
            label4.Name = "label4";
            label4.Size = new Size(107, 22);
            label4.TabIndex = 3;
            label4.Text = "Mot de passe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 235, 153);
            label5.Location = new Point(504, 97);
            label5.Name = "label5";
            label5.Size = new Size(145, 22);
            label5.TabIndex = 4;
            label5.Text = "Confirmation mdp";
            // 
            // textBox_nom
            // 
            textBox_nom.BackColor = Color.FromArgb(30, 35, 40);
            textBox_nom.BorderStyle = BorderStyle.None;
            textBox_nom.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            textBox_nom.ForeColor = Color.FromArgb(255, 235, 153);
            textBox_nom.Location = new Point(241, 98);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(206, 20);
            textBox_nom.TabIndex = 5;
            // 
            // textBox_mdp
            // 
            textBox_mdp.BackColor = Color.FromArgb(30, 35, 40);
            textBox_mdp.BorderStyle = BorderStyle.None;
            textBox_mdp.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            textBox_mdp.ForeColor = Color.FromArgb(255, 235, 153);
            textBox_mdp.Location = new Point(241, 252);
            textBox_mdp.Name = "textBox_mdp";
            textBox_mdp.Size = new Size(206, 20);
            textBox_mdp.TabIndex = 6;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(30, 35, 40);
            textBox_email.BorderStyle = BorderStyle.None;
            textBox_email.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            textBox_email.ForeColor = Color.FromArgb(255, 235, 153);
            textBox_email.Location = new Point(241, 202);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(206, 20);
            textBox_email.TabIndex = 7;
            // 
            // textBox_prenom
            // 
            textBox_prenom.BackColor = Color.FromArgb(30, 35, 40);
            textBox_prenom.BorderStyle = BorderStyle.None;
            textBox_prenom.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            textBox_prenom.ForeColor = Color.FromArgb(255, 235, 153);
            textBox_prenom.Location = new Point(241, 151);
            textBox_prenom.Name = "textBox_prenom";
            textBox_prenom.Size = new Size(206, 20);
            textBox_prenom.TabIndex = 8;
            // 
            // textBox_confirmMdp
            // 
            textBox_confirmMdp.BackColor = Color.FromArgb(30, 35, 40);
            textBox_confirmMdp.BorderStyle = BorderStyle.None;
            textBox_confirmMdp.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            textBox_confirmMdp.ForeColor = Color.FromArgb(255, 235, 153);
            textBox_confirmMdp.Location = new Point(671, 98);
            textBox_confirmMdp.Name = "textBox_confirmMdp";
            textBox_confirmMdp.Size = new Size(219, 20);
            textBox_confirmMdp.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 235, 153);
            label6.Location = new Point(362, 310);
            label6.Name = "label6";
            label6.Size = new Size(142, 22);
            label6.TabIndex = 10;
            label6.Text = "Date de naissance";
            // 
            // dateTimePicker_naissance
            // 
            dateTimePicker_naissance.CalendarForeColor = Color.FromArgb(255, 235, 153);
            dateTimePicker_naissance.CalendarMonthBackground = Color.FromArgb(30, 35, 40);
            dateTimePicker_naissance.CalendarTitleBackColor = Color.FromArgb(245, 225, 183);
            dateTimePicker_naissance.CalendarTitleForeColor = Color.FromArgb(255, 235, 153);
            dateTimePicker_naissance.CalendarTrailingForeColor = Color.FromArgb(255, 235, 153);
            dateTimePicker_naissance.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker_naissance.Location = new Point(524, 310);
            dateTimePicker_naissance.MaxDate = new DateTime(2025, 4, 24, 0, 0, 0, 0);
            dateTimePicker_naissance.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dateTimePicker_naissance.Name = "dateTimePicker_naissance";
            dateTimePicker_naissance.Size = new Size(218, 22);
            dateTimePicker_naissance.TabIndex = 11;
            dateTimePicker_naissance.Value = new DateTime(2025, 4, 24, 0, 0, 0, 0);
            // 
            // button_ajouter
            // 
            button_ajouter.BackColor = Color.FromArgb(255, 235, 153);
            button_ajouter.FlatStyle = FlatStyle.Popup;
            button_ajouter.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            button_ajouter.Location = new Point(378, 434);
            button_ajouter.Name = "button_ajouter";
            button_ajouter.Size = new Size(126, 28);
            button_ajouter.TabIndex = 12;
            button_ajouter.Text = "AJOUTER";
            button_ajouter.UseVisualStyleBackColor = false;
            button_ajouter.Click += button_ajouter_Click;
            // 
            // button_annuler
            // 
            button_annuler.BackColor = Color.FromArgb(255, 235, 153);
            button_annuler.FlatStyle = FlatStyle.Popup;
            button_annuler.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            button_annuler.Location = new Point(524, 434);
            button_annuler.Name = "button_annuler";
            button_annuler.Size = new Size(126, 28);
            button_annuler.TabIndex = 13;
            button_annuler.Text = "ANNULER";
            button_annuler.UseVisualStyleBackColor = false;
            button_annuler.Click += button_annuler_Click;
            // 
            // comboBox_metier
            // 
            comboBox_metier.BackColor = Color.FromArgb(30, 35, 40);
            comboBox_metier.FlatStyle = FlatStyle.Popup;
            comboBox_metier.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            comboBox_metier.ForeColor = Color.FromArgb(255, 235, 153);
            comboBox_metier.FormattingEnabled = true;
            comboBox_metier.Location = new Point(672, 141);
            comboBox_metier.Name = "comboBox_metier";
            comboBox_metier.Size = new Size(219, 27);
            comboBox_metier.TabIndex = 14;
            comboBox_metier.SelectedIndexChanged += comboBox_metier_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(255, 235, 153);
            label7.Location = new Point(580, 142);
            label7.Name = "label7";
            label7.Size = new Size(61, 22);
            label7.TabIndex = 15;
            label7.Text = "Métier";
            // 
            // label_salaire
            // 
            label_salaire.AutoSize = true;
            label_salaire.BackColor = Color.Transparent;
            label_salaire.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label_salaire.ForeColor = Color.FromArgb(255, 235, 153);
            label_salaire.Location = new Point(580, 195);
            label_salaire.Name = "label_salaire";
            label_salaire.Size = new Size(62, 22);
            label_salaire.TabIndex = 16;
            label_salaire.Text = "Salaire";
            // 
            // nud_salaire
            // 
            nud_salaire.BackColor = Color.FromArgb(30, 35, 40);
            nud_salaire.BorderStyle = BorderStyle.None;
            nud_salaire.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            nud_salaire.ForeColor = Color.FromArgb(255, 235, 153);
            nud_salaire.Location = new Point(672, 193);
            nud_salaire.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_salaire.Name = "nud_salaire";
            nud_salaire.Size = new Size(218, 23);
            nud_salaire.TabIndex = 17;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.BackColor = Color.Transparent;
            label_role.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            label_role.ForeColor = Color.FromArgb(255, 235, 153);
            label_role.Location = new Point(597, 246);
            label_role.Name = "label_role";
            label_role.Size = new Size(44, 22);
            label_role.TabIndex = 18;
            label_role.Text = "Role";
            // 
            // comboBox_role
            // 
            comboBox_role.BackColor = Color.FromArgb(30, 35, 40);
            comboBox_role.FlatStyle = FlatStyle.Popup;
            comboBox_role.Font = new Font("Baskerville Old Face", 12.75F, FontStyle.Bold);
            comboBox_role.ForeColor = Color.FromArgb(255, 235, 153);
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Location = new Point(672, 245);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(218, 27);
            comboBox_role.TabIndex = 19;
            // 
            // FormAjoutMembre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL_modified;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 490);
            Controls.Add(comboBox_role);
            Controls.Add(label_role);
            Controls.Add(nud_salaire);
            Controls.Add(label_salaire);
            Controls.Add(label7);
            Controls.Add(comboBox_metier);
            Controls.Add(button_annuler);
            Controls.Add(button_ajouter);
            Controls.Add(dateTimePicker_naissance);
            Controls.Add(label6);
            Controls.Add(textBox_confirmMdp);
            Controls.Add(textBox_prenom);
            Controls.Add(textBox_email);
            Controls.Add(textBox_mdp);
            Controls.Add(textBox_nom);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAjoutMembre";
            Text = "FormAjoutMembre";
            ((System.ComponentModel.ISupportInitialize)nud_salaire).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_role).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_nom;
        private TextBox textBox_mdp;
        private TextBox textBox_email;
        private TextBox textBox_prenom;
        private TextBox textBox_confirmMdp;
        private Label label6;
        private DateTimePicker dateTimePicker_naissance;
        private Button button_ajouter;
        private Button button_annuler;
        private ComboBox comboBox_metier;
        private Label label7;
        private Label label_salaire;
        private NumericUpDown nud_salaire;
        private Label label_role;
        private ComboBox comboBox_role;
        private BindingSource bindingSource_role;
    }
}