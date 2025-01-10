namespace Maison_moel.vue
{
    partial class FormModificationCuisinier
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
            textBox_nom = new TextBox();
            textBox_prenom = new TextBox();
            textBox_email = new TextBox();
            dtp_datenaissance = new DateTimePicker();
            label_dateNaiss = new Label();
            label_nom = new Label();
            label_prenom = new Label();
            label_email = new Label();
            SuspendLayout();
            // 
            // textBox_nom
            // 
            textBox_nom.Location = new Point(208, 123);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(202, 23);
            textBox_nom.TabIndex = 0;
            // 
            // textBox_prenom
            // 
            textBox_prenom.Location = new Point(208, 162);
            textBox_prenom.Name = "textBox_prenom";
            textBox_prenom.Size = new Size(202, 23);
            textBox_prenom.TabIndex = 1;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(208, 201);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(202, 23);
            textBox_email.TabIndex = 2;
            // 
            // dtp_datenaissance
            // 
            dtp_datenaissance.Location = new Point(208, 241);
            dtp_datenaissance.Name = "dtp_datenaissance";
            dtp_datenaissance.Size = new Size(202, 23);
            dtp_datenaissance.TabIndex = 3;
            // 
            // label_dateNaiss
            // 
            label_dateNaiss.AutoSize = true;
            label_dateNaiss.Location = new Point(80, 247);
            label_dateNaiss.Name = "label_dateNaiss";
            label_dateNaiss.Size = new Size(103, 15);
            label_dateNaiss.TabIndex = 4;
            label_dateNaiss.Text = "Date de Naissance";
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.Location = new Point(80, 131);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(34, 15);
            label_nom.TabIndex = 5;
            label_nom.Text = "Nom";
            // 
            // label_prenom
            // 
            label_prenom.AutoSize = true;
            label_prenom.Location = new Point(80, 170);
            label_prenom.Name = "label_prenom";
            label_prenom.Size = new Size(49, 15);
            label_prenom.TabIndex = 6;
            label_prenom.Text = "Prénom";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(80, 209);
            label_email.Name = "label_email";
            label_email.Size = new Size(36, 15);
            label_email.TabIndex = 7;
            label_email.Text = "Email";
            // 
            // FormModificationCuisinier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_1500_1500_1_;
            ClientSize = new Size(994, 518);
            Controls.Add(label_email);
            Controls.Add(label_prenom);
            Controls.Add(label_nom);
            Controls.Add(label_dateNaiss);
            Controls.Add(dtp_datenaissance);
            Controls.Add(textBox_email);
            Controls.Add(textBox_prenom);
            Controls.Add(textBox_nom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificationCuisinier";
            Text = "FormModificationCuisinier";
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
    }
}