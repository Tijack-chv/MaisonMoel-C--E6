namespace Maison_moel.vue
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            panelWest = new Panel();
            panelPersonnel = new Panel();
            buttonPersonnel = new Button();
            panelAbout = new Panel();
            panelCommande = new Panel();
            panelCuisine = new Panel();
            buttonAbout = new Button();
            panelQuitter = new Panel();
            labelAdmin = new Label();
            buttonQuitter = new Button();
            panelSettings = new Panel();
            buttonSettings = new Button();
            buttonHome = new Button();
            buttonCommande = new Button();
            panelHome = new Panel();
            buttonCuisine = new Button();
            panelAffichage = new Panel();
            panelMessages = new Panel();
            textBoxMessage = new TextBox();
            panelContenuMessages = new Panel();
            labelTitreMessage = new Label();
            pictureBox1 = new PictureBox();
            panelNorth = new Panel();
            labelNotification = new Label();
            pictureBoxNotification = new PictureBox();
            buttonMenu = new Button();
            labelOrganisation = new Label();
            pictureBoxLogo = new PictureBox();
            timerCountNotif = new System.Windows.Forms.Timer(components);
            timerMessages = new System.Windows.Forms.Timer(components);
            panelWest.SuspendLayout();
            panelAffichage.SuspendLayout();
            panelMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelNorth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelWest
            // 
            panelWest.BackColor = Color.FromArgb(45, 50, 55);
            panelWest.Controls.Add(panelPersonnel);
            panelWest.Controls.Add(buttonPersonnel);
            panelWest.Controls.Add(panelAbout);
            panelWest.Controls.Add(panelCommande);
            panelWest.Controls.Add(panelCuisine);
            panelWest.Controls.Add(buttonAbout);
            panelWest.Controls.Add(panelQuitter);
            panelWest.Controls.Add(labelAdmin);
            panelWest.Controls.Add(buttonQuitter);
            panelWest.Controls.Add(panelSettings);
            panelWest.Controls.Add(buttonSettings);
            panelWest.Controls.Add(buttonHome);
            panelWest.Controls.Add(buttonCommande);
            panelWest.Controls.Add(panelHome);
            panelWest.Controls.Add(buttonCuisine);
            panelWest.Location = new Point(0, 83);
            panelWest.Margin = new Padding(3, 2, 3, 2);
            panelWest.MaximumSize = new Size(223, 490);
            panelWest.Name = "panelWest";
            panelWest.Size = new Size(223, 490);
            panelWest.TabIndex = 4;
            // 
            // panelPersonnel
            // 
            panelPersonnel.BackColor = Color.SeaGreen;
            panelPersonnel.Location = new Point(1, 239);
            panelPersonnel.Margin = new Padding(3, 2, 3, 2);
            panelPersonnel.Name = "panelPersonnel";
            panelPersonnel.Size = new Size(3, 59);
            panelPersonnel.TabIndex = 4;
            // 
            // buttonPersonnel
            // 
            buttonPersonnel.BackColor = Color.FromArgb(45, 50, 55);
            buttonPersonnel.BackgroundImageLayout = ImageLayout.Center;
            buttonPersonnel.FlatStyle = FlatStyle.Popup;
            buttonPersonnel.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPersonnel.ForeColor = Color.FromArgb(255, 235, 153);
            buttonPersonnel.Image = (Image)resources.GetObject("buttonPersonnel.Image");
            buttonPersonnel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPersonnel.Location = new Point(4, 238);
            buttonPersonnel.Margin = new Padding(3, 2, 3, 2);
            buttonPersonnel.Name = "buttonPersonnel";
            buttonPersonnel.Size = new Size(218, 59);
            buttonPersonnel.TabIndex = 2;
            buttonPersonnel.Text = "       Personnel";
            buttonPersonnel.TextAlign = ContentAlignment.MiddleLeft;
            buttonPersonnel.UseVisualStyleBackColor = false;
            buttonPersonnel.Click += buttonPersonnel_Click;
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.SeaGreen;
            panelAbout.Location = new Point(1, 364);
            panelAbout.Margin = new Padding(3, 2, 3, 2);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(3, 59);
            panelAbout.TabIndex = 5;
            // 
            // panelCommande
            // 
            panelCommande.BackColor = Color.SeaGreen;
            panelCommande.Location = new Point(1, 113);
            panelCommande.Margin = new Padding(3, 2, 3, 2);
            panelCommande.Name = "panelCommande";
            panelCommande.Size = new Size(3, 59);
            panelCommande.TabIndex = 1;
            // 
            // panelCuisine
            // 
            panelCuisine.BackColor = Color.SeaGreen;
            panelCuisine.Location = new Point(1, 176);
            panelCuisine.Margin = new Padding(3, 2, 3, 2);
            panelCuisine.Name = "panelCuisine";
            panelCuisine.Size = new Size(3, 59);
            panelCuisine.TabIndex = 3;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.FromArgb(45, 50, 55);
            buttonAbout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAbout.FlatStyle = FlatStyle.Popup;
            buttonAbout.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            buttonAbout.ForeColor = Color.FromArgb(255, 235, 153);
            buttonAbout.Image = (Image)resources.GetObject("buttonAbout.Image");
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(3, 364);
            buttonAbout.Margin = new Padding(3, 2, 3, 2);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(218, 59);
            buttonAbout.TabIndex = 2;
            buttonAbout.Text = "       Information";
            buttonAbout.TextAlign = ContentAlignment.MiddleLeft;
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panelQuitter
            // 
            panelQuitter.BackColor = Color.SeaGreen;
            panelQuitter.Location = new Point(1, 427);
            panelQuitter.Margin = new Padding(3, 2, 3, 2);
            panelQuitter.Name = "panelQuitter";
            panelQuitter.Size = new Size(3, 59);
            panelQuitter.TabIndex = 6;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAdmin.ForeColor = Color.FromArgb(255, 235, 153);
            labelAdmin.Location = new Point(3, 14);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.RightToLeft = RightToLeft.Yes;
            labelAdmin.Size = new Size(140, 24);
            labelAdmin.TabIndex = 4;
            labelAdmin.Text = "Nom Prenom";
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.FromArgb(45, 50, 55);
            buttonQuitter.BackgroundImageLayout = ImageLayout.Zoom;
            buttonQuitter.FlatStyle = FlatStyle.Popup;
            buttonQuitter.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            buttonQuitter.ForeColor = Color.FromArgb(255, 235, 153);
            buttonQuitter.Image = (Image)resources.GetObject("buttonQuitter.Image");
            buttonQuitter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQuitter.Location = new Point(3, 427);
            buttonQuitter.Margin = new Padding(3, 2, 3, 2);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(218, 59);
            buttonQuitter.TabIndex = 2;
            buttonQuitter.Text = "       Quitter";
            buttonQuitter.TextAlign = ContentAlignment.MiddleLeft;
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.SeaGreen;
            panelSettings.Location = new Point(1, 302);
            panelSettings.Margin = new Padding(3, 2, 3, 2);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(3, 59);
            panelSettings.TabIndex = 4;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(45, 50, 55);
            buttonSettings.BackgroundImageLayout = ImageLayout.Center;
            buttonSettings.FlatStyle = FlatStyle.Popup;
            buttonSettings.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            buttonSettings.ForeColor = Color.FromArgb(255, 235, 153);
            buttonSettings.Image = (Image)resources.GetObject("buttonSettings.Image");
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(3, 301);
            buttonSettings.Margin = new Padding(3, 2, 3, 2);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(218, 59);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "       Paramètre";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(45, 50, 55);
            buttonHome.BackgroundImageLayout = ImageLayout.None;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = Color.FromArgb(255, 235, 153);
            buttonHome.Image = (Image)resources.GetObject("buttonHome.Image");
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(3, 50);
            buttonHome.Margin = new Padding(3, 2, 3, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(218, 59);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "       Accueil";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCommande
            // 
            buttonCommande.BackColor = Color.FromArgb(45, 50, 55);
            buttonCommande.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCommande.FlatStyle = FlatStyle.Popup;
            buttonCommande.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCommande.ForeColor = Color.FromArgb(255, 235, 153);
            buttonCommande.Image = (Image)resources.GetObject("buttonCommande.Image");
            buttonCommande.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCommande.Location = new Point(3, 113);
            buttonCommande.Margin = new Padding(3, 2, 3, 2);
            buttonCommande.Name = "buttonCommande";
            buttonCommande.Size = new Size(218, 59);
            buttonCommande.TabIndex = 1;
            buttonCommande.Text = "       Commande";
            buttonCommande.TextAlign = ContentAlignment.MiddleLeft;
            buttonCommande.UseVisualStyleBackColor = false;
            buttonCommande.Click += buttonCommande_Click;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.SeaGreen;
            panelHome.Location = new Point(0, 50);
            panelHome.Margin = new Padding(3, 2, 3, 2);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(3, 59);
            panelHome.TabIndex = 0;
            // 
            // buttonCuisine
            // 
            buttonCuisine.BackColor = Color.FromArgb(45, 50, 55);
            buttonCuisine.BackgroundImageLayout = ImageLayout.Center;
            buttonCuisine.FlatStyle = FlatStyle.Popup;
            buttonCuisine.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCuisine.ForeColor = Color.FromArgb(255, 235, 153);
            buttonCuisine.Image = (Image)resources.GetObject("buttonCuisine.Image");
            buttonCuisine.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCuisine.Location = new Point(3, 176);
            buttonCuisine.Margin = new Padding(3, 2, 3, 2);
            buttonCuisine.Name = "buttonCuisine";
            buttonCuisine.Size = new Size(218, 59);
            buttonCuisine.TabIndex = 1;
            buttonCuisine.Text = "       Cuisine";
            buttonCuisine.TextAlign = ContentAlignment.MiddleLeft;
            buttonCuisine.UseVisualStyleBackColor = false;
            buttonCuisine.Click += buttonCuisine_Click;
            // 
            // panelAffichage
            // 
            panelAffichage.BackColor = Color.Transparent;
            panelAffichage.BackgroundImage = Properties.Resources.FOND_ACCUEIL_modified1;
            panelAffichage.BackgroundImageLayout = ImageLayout.Stretch;
            panelAffichage.Controls.Add(panelMessages);
            panelAffichage.Dock = DockStyle.Fill;
            panelAffichage.Location = new Point(0, 83);
            panelAffichage.Margin = new Padding(3, 2, 3, 2);
            panelAffichage.Name = "panelAffichage";
            panelAffichage.Size = new Size(1024, 490);
            panelAffichage.TabIndex = 5;
            // 
            // panelMessages
            // 
            panelMessages.BackColor = Color.FromArgb(55, 60, 65);
            panelMessages.Controls.Add(textBoxMessage);
            panelMessages.Controls.Add(panelContenuMessages);
            panelMessages.Controls.Add(labelTitreMessage);
            panelMessages.Controls.Add(pictureBox1);
            panelMessages.Location = new Point(680, 0);
            panelMessages.Name = "panelMessages";
            panelMessages.Size = new Size(343, 490);
            panelMessages.TabIndex = 0;
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = Color.FromArgb(70, 75, 80);
            textBoxMessage.BorderStyle = BorderStyle.None;
            textBoxMessage.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMessage.ForeColor = Color.FromArgb(255, 235, 135);
            textBoxMessage.Location = new Point(13, 413);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(319, 73);
            textBoxMessage.TabIndex = 10;
            textBoxMessage.Text = "Votre message ici...";
            textBoxMessage.Enter += textBoxMessage_Enter;
            textBoxMessage.KeyPress += textBoxMessage_KeyPress;
            textBoxMessage.Leave += textBoxMessage_Leave;
            // 
            // panelContenuMessages
            // 
            panelContenuMessages.AutoScroll = true;
            panelContenuMessages.BackColor = Color.Transparent;
            panelContenuMessages.Location = new Point(3, 93);
            panelContenuMessages.Name = "panelContenuMessages";
            panelContenuMessages.Size = new Size(337, 315);
            panelContenuMessages.TabIndex = 9;
            // 
            // labelTitreMessage
            // 
            labelTitreMessage.AutoSize = true;
            labelTitreMessage.BackColor = Color.Transparent;
            labelTitreMessage.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitreMessage.ForeColor = Color.FromArgb(255, 235, 153);
            labelTitreMessage.Location = new Point(106, 14);
            labelTitreMessage.Name = "labelTitreMessage";
            labelTitreMessage.Size = new Size(231, 48);
            labelTitreMessage.TabIndex = 8;
            labelTitreMessage.Text = "Messagerie \r\nServeur-Cuisinier";
            labelTitreMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Gold_Icon_Texting_I02_watermarked_2k;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelNorth
            // 
            panelNorth.BackColor = Color.FromArgb(35, 40, 45);
            panelNorth.Controls.Add(labelNotification);
            panelNorth.Controls.Add(pictureBoxNotification);
            panelNorth.Controls.Add(buttonMenu);
            panelNorth.Controls.Add(labelOrganisation);
            panelNorth.Controls.Add(pictureBoxLogo);
            panelNorth.Dock = DockStyle.Top;
            panelNorth.Location = new Point(0, 0);
            panelNorth.Margin = new Padding(3, 2, 3, 2);
            panelNorth.Name = "panelNorth";
            panelNorth.Size = new Size(1024, 83);
            panelNorth.TabIndex = 3;
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotification.ForeColor = Color.FromArgb(255, 235, 153);
            labelNotification.Location = new Point(988, 0);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(36, 24);
            labelNotification.TabIndex = 7;
            labelNotification.Text = "0+";
            // 
            // pictureBoxNotification
            // 
            pictureBoxNotification.Image = Properties.Resources.Bell_Notification_I01_watermarked_2k;
            pictureBoxNotification.Location = new Point(934, 4);
            pictureBoxNotification.Name = "pictureBoxNotification";
            pictureBoxNotification.Size = new Size(78, 74);
            pictureBoxNotification.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNotification.TabIndex = 6;
            pictureBoxNotification.TabStop = false;
            pictureBoxNotification.Click += pictureBoxNotification_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Transparent;
            buttonMenu.BackgroundImage = (Image)resources.GetObject("buttonMenu.BackgroundImage");
            buttonMenu.BackgroundImageLayout = ImageLayout.Center;
            buttonMenu.FlatStyle = FlatStyle.Popup;
            buttonMenu.Location = new Point(0, 0);
            buttonMenu.Margin = new Padding(3, 2, 3, 2);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(87, 83);
            buttonMenu.TabIndex = 5;
            buttonMenu.TextAlign = ContentAlignment.MiddleRight;
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // labelOrganisation
            // 
            labelOrganisation.AutoSize = true;
            labelOrganisation.Font = new Font("SimSun-ExtB", 28F, FontStyle.Bold | FontStyle.Italic);
            labelOrganisation.ForeColor = Color.FromArgb(255, 235, 153);
            labelOrganisation.Location = new Point(425, 23);
            labelOrganisation.Name = "labelOrganisation";
            labelOrganisation.Size = new Size(237, 38);
            labelOrganisation.TabIndex = 3;
            labelOrganisation.Text = "MAISON MOËL";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(302, 2);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(123, 79);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // timerCountNotif
            // 
            timerCountNotif.Interval = 20000;
            timerCountNotif.Tick += timerCountNotif_Tick;
            // 
            // timerMessages
            // 
            timerMessages.Interval = 30000;
            timerMessages.Tick += timerMessages_Tick;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 573);
            Controls.Add(panelWest);
            Controls.Add(panelAffichage);
            Controls.Add(panelNorth);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormHome";
            Text = "Maison Moël";
            Load += FormHome_Load;
            panelWest.ResumeLayout(false);
            panelWest.PerformLayout();
            panelAffichage.ResumeLayout(false);
            panelMessages.ResumeLayout(false);
            panelMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelNorth.ResumeLayout(false);
            panelNorth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelWest;
        public Panel panelPersonnel;
        private Button buttonPersonnel;
        private Panel panelAbout;
        public Panel panelCommande;
        public Panel panelCuisine;
        private Button buttonAbout;
        private Panel panelQuitter;
        private Label labelAdmin;
        private Button buttonQuitter;
        private Panel panelSettings;
        private Button buttonSettings;
        private Button buttonHome;
        private Button buttonCommande;
        public Panel panelHome;
        private Button buttonCuisine;
        private Panel panelNorth;
        private Button buttonMenu;
        private Label labelOrganisation;
        private PictureBox pictureBoxLogo;
        private Panel panelMessages;
        private Label labelNotification;
        private PictureBox pictureBoxNotification;
        private Panel panelAffichage;
        private System.Windows.Forms.Timer timerCountNotif;
        private System.Windows.Forms.Timer timerMessages;
        private Label labelTitreMessage;
        private PictureBox pictureBox1;
        private Panel panelContenuMessages;
        private TextBox textBoxMessage;
    }
}