namespace Maison_moel
{
    partial class FormConnexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            labelSeConnecter = new Label();
            pictureBoxLogo = new PictureBox();
            labelErreurEmail = new Label();
            labelErreurPassword = new Label();
            buttonConnecter = new Button();
            panelBackground = new Panel();
            panelExit = new Panel();
            labelExit = new Label();
            panelUnderComponent = new Panel();
            pictureBoxPassword = new PictureBox();
            pictureBoxEmail = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelBackground.SuspendLayout();
            panelExit.SuspendLayout();
            panelUnderComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmail).BeginInit();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(255, 235, 133);
            textBoxEmail.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Location = new Point(90, 102);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(223, 31);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.Text = "Adresse-email";
            textBoxEmail.Enter += textBoxEmail_Enter;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(255, 235, 133);
            textBoxPassword.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold);
            textBoxPassword.Location = new Point(90, 192);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(223, 31);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.Text = "Mot de passe";
            textBoxPassword.Enter += textBoxPassword_Enter;
            textBoxPassword.Leave += textBoxPassword_Leave;
            // 
            // labelSeConnecter
            // 
            labelSeConnecter.AutoSize = true;
            labelSeConnecter.BackColor = Color.Transparent;
            labelSeConnecter.Font = new Font("Baskerville Old Face", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSeConnecter.ForeColor = Color.Black;
            labelSeConnecter.Location = new Point(15, 10);
            labelSeConnecter.Name = "labelSeConnecter";
            labelSeConnecter.Size = new Size(372, 73);
            labelSeConnecter.TabIndex = 5;
            labelSeConnecter.Text = "Se connecter";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxLogo.Location = new Point(461, 26);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(136, 125);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // labelErreurEmail
            // 
            labelErreurEmail.AutoSize = true;
            labelErreurEmail.BackColor = Color.Transparent;
            labelErreurEmail.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold);
            labelErreurEmail.ForeColor = Color.Red;
            labelErreurEmail.Location = new Point(63, 135);
            labelErreurEmail.Name = "labelErreurEmail";
            labelErreurEmail.Size = new Size(276, 24);
            labelErreurEmail.TabIndex = 28;
            labelErreurEmail.Text = "Erreur : l'email est manquant";
            // 
            // labelErreurPassword
            // 
            labelErreurPassword.AutoSize = true;
            labelErreurPassword.BackColor = Color.Transparent;
            labelErreurPassword.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold);
            labelErreurPassword.ForeColor = Color.Red;
            labelErreurPassword.Location = new Point(23, 229);
            labelErreurPassword.Name = "labelErreurPassword";
            labelErreurPassword.Size = new Size(356, 24);
            labelErreurPassword.TabIndex = 29;
            labelErreurPassword.Text = "Erreur : le mot de passe est manquant";
            // 
            // buttonConnecter
            // 
            buttonConnecter.BackColor = Color.FromArgb(255, 235, 133);
            buttonConnecter.FlatStyle = FlatStyle.Popup;
            buttonConnecter.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConnecter.ForeColor = Color.Black;
            buttonConnecter.Location = new Point(85, 291);
            buttonConnecter.Margin = new Padding(4);
            buttonConnecter.Name = "buttonConnecter";
            buttonConnecter.Size = new Size(232, 48);
            buttonConnecter.TabIndex = 30;
            buttonConnecter.Text = "Connexion";
            buttonConnecter.UseVisualStyleBackColor = false;
            buttonConnecter.Click += buttonConnecter_Click_1;
            buttonConnecter.MouseLeave += buttonConnecter_MouseLeave;
            buttonConnecter.MouseHover += buttonConnecter_MouseHover;
            // 
            // panelBackground
            // 
            panelBackground.BackColor = Color.FromArgb(40, 45, 50);
            panelBackground.BackgroundImage = Properties.Resources.FOND_ACCUEIL;
            panelBackground.BackgroundImageLayout = ImageLayout.Stretch;
            panelBackground.BorderStyle = BorderStyle.FixedSingle;
            panelBackground.Controls.Add(panelExit);
            panelBackground.Controls.Add(panelUnderComponent);
            panelBackground.Controls.Add(pictureBoxLogo);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1051, 621);
            panelBackground.TabIndex = 31;
            // 
            // panelExit
            // 
            panelExit.BackColor = Color.Transparent;
            panelExit.Controls.Add(labelExit);
            panelExit.Location = new Point(994, 3);
            panelExit.Name = "panelExit";
            panelExit.Size = new Size(52, 57);
            panelExit.TabIndex = 34;
            // 
            // labelExit
            // 
            labelExit.AutoSize = true;
            labelExit.BackColor = Color.Transparent;
            labelExit.Font = new Font("Cambria", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelExit.ForeColor = Color.White;
            labelExit.Location = new Point(4, -3);
            labelExit.Name = "labelExit";
            labelExit.Size = new Size(52, 57);
            labelExit.TabIndex = 35;
            labelExit.Text = "X";
            labelExit.Click += labelExit_Click;
            labelExit.MouseLeave += labelExit_MouseLeave;
            labelExit.MouseHover += labelExit_MouseHover;
            // 
            // panelUnderComponent
            // 
            panelUnderComponent.Controls.Add(labelSeConnecter);
            panelUnderComponent.Controls.Add(pictureBoxPassword);
            panelUnderComponent.Controls.Add(buttonConnecter);
            panelUnderComponent.Controls.Add(textBoxPassword);
            panelUnderComponent.Controls.Add(pictureBoxEmail);
            panelUnderComponent.Controls.Add(textBoxEmail);
            panelUnderComponent.Controls.Add(labelErreurEmail);
            panelUnderComponent.Controls.Add(labelErreurPassword);
            panelUnderComponent.Location = new Point(327, 156);
            panelUnderComponent.Name = "panelUnderComponent";
            panelUnderComponent.Size = new Size(404, 365);
            panelUnderComponent.TabIndex = 33;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.BackColor = Color.Transparent;
            pictureBoxPassword.Image = Properties.Resources.passwordW;
            pictureBoxPassword.Location = new Point(42, 192);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(30, 31);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPassword.TabIndex = 32;
            pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxEmail
            // 
            pictureBoxEmail.BackColor = Color.Transparent;
            pictureBoxEmail.Image = Properties.Resources.emailW;
            pictureBoxEmail.Location = new Point(42, 101);
            pictureBoxEmail.Name = "pictureBoxEmail";
            pictureBoxEmail.Size = new Size(30, 31);
            pictureBoxEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEmail.TabIndex = 31;
            pictureBoxEmail.TabStop = false;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 621);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormConnexion";
            Text = "Maison Moël";
            Load += FormConnexion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelBackground.ResumeLayout(false);
            panelExit.ResumeLayout(false);
            panelExit.PerformLayout();
            panelUnderComponent.ResumeLayout(false);
            panelUnderComponent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label labelSeConnecter;
        private PictureBox pictureBoxLogo;
        private Label labelErreurEmail;
        private Label labelErreurPassword;
        private Button buttonConnecter;
        private Panel panelBackground;
        private PictureBox pictureBoxEmail;
        private PictureBox pictureBoxPassword;
        private Panel panelUnderComponent;
        private Panel panelExit;
        private Label labelExit;
    }
}
