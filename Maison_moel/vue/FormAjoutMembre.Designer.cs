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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(83, 105);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(83, 158);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(83, 209);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(83, 259);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "MDP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(83, 312);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 4;
            label5.Text = "Confirmation MDP";
            // 
            // textBox_nom
            // 
            textBox_nom.Location = new Point(263, 102);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(206, 23);
            textBox_nom.TabIndex = 5;
            // 
            // textBox_mdp
            // 
            textBox_mdp.Location = new Point(263, 256);
            textBox_mdp.Name = "textBox_mdp";
            textBox_mdp.Size = new Size(206, 23);
            textBox_mdp.TabIndex = 6;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(263, 206);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(206, 23);
            textBox_email.TabIndex = 7;
            // 
            // textBox_prenom
            // 
            textBox_prenom.Location = new Point(263, 155);
            textBox_prenom.Name = "textBox_prenom";
            textBox_prenom.Size = new Size(206, 23);
            textBox_prenom.TabIndex = 8;
            // 
            // textBox_confirmMdp
            // 
            textBox_confirmMdp.Location = new Point(263, 313);
            textBox_confirmMdp.Name = "textBox_confirmMdp";
            textBox_confirmMdp.Size = new Size(206, 23);
            textBox_confirmMdp.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(83, 361);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 10;
            label6.Text = "Date de naissance";
            // 
            // dateTimePicker_naissance
            // 
            dateTimePicker_naissance.Location = new Point(263, 358);
            dateTimePicker_naissance.Name = "dateTimePicker_naissance";
            dateTimePicker_naissance.Size = new Size(206, 23);
            dateTimePicker_naissance.TabIndex = 11;
            // 
            // button_ajouter
            // 
            button_ajouter.BackColor = Color.FromArgb(128, 255, 128);
            button_ajouter.Location = new Point(378, 434);
            button_ajouter.Name = "button_ajouter";
            button_ajouter.Size = new Size(126, 28);
            button_ajouter.TabIndex = 12;
            button_ajouter.Text = "AJOUTER";
            button_ajouter.UseVisualStyleBackColor = false;
            // 
            // button_annuler
            // 
            button_annuler.BackColor = Color.FromArgb(255, 128, 128);
            button_annuler.Location = new Point(524, 434);
            button_annuler.Name = "button_annuler";
            button_annuler.Size = new Size(126, 28);
            button_annuler.TabIndex = 13;
            button_annuler.Text = "ANNULER";
            button_annuler.UseVisualStyleBackColor = false;
            // 
            // comboBox_metier
            // 
            comboBox_metier.FormattingEnabled = true;
            comboBox_metier.Location = new Point(693, 102);
            comboBox_metier.Name = "comboBox_metier";
            comboBox_metier.Size = new Size(218, 23);
            comboBox_metier.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.Location = new Point(575, 101);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 15;
            label7.Text = "Métier";
            // 
            // FormAjoutMembre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_1500_1500_1_;
            ClientSize = new Size(1034, 525);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAjoutMembre";
            Text = "FormAjoutMembre";
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
    }
}