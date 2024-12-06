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
            label1 = new Label();
            label2 = new Label();
            txt_id = new TextBox();
            txt_mdp = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            labelErreurEmail = new Label();
            labelErreurMdp = new Label();
            buttonConnecter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(279, 151);
            label1.Name = "label1";
            label1.Padding = new Padding(1);
            label1.Size = new Size(127, 56);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(129, 256);
            label2.Name = "label2";
            label2.Padding = new Padding(1);
            label2.Size = new Size(277, 56);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe";
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(255, 235, 153);
            txt_id.Font = new Font("Segoe UI", 12F);
            txt_id.ForeColor = Color.Black;
            txt_id.Location = new Point(480, 173);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(254, 34);
            txt_id.TabIndex = 2;
            // 
            // txt_mdp
            // 
            txt_mdp.BackColor = Color.FromArgb(255, 235, 153);
            txt_mdp.Font = new Font("Segoe UI", 12F);
            txt_mdp.Location = new Point(480, 278);
            txt_mdp.Name = "txt_mdp";
            txt_mdp.Size = new Size(254, 34);
            txt_mdp.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1081, 546);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(443, 37);
            label3.Name = "label3";
            label3.Size = new Size(309, 62);
            label3.TabIndex = 5;
            label3.Text = "Se connecter";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(31, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 144);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // labelErreurEmail
            // 
            labelErreurEmail.AutoSize = true;
            labelErreurEmail.BackColor = Color.Transparent;
            labelErreurEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErreurEmail.ForeColor = Color.Red;
            labelErreurEmail.Location = new Point(480, 227);
            labelErreurEmail.Name = "labelErreurEmail";
            labelErreurEmail.Size = new Size(243, 23);
            labelErreurEmail.TabIndex = 28;
            labelErreurEmail.Text = "Erreur : l'email est manquant";
            // 
            // labelErreurMdp
            // 
            labelErreurMdp.AutoSize = true;
            labelErreurMdp.BackColor = Color.Transparent;
            labelErreurMdp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErreurMdp.ForeColor = Color.Red;
            labelErreurMdp.Location = new Point(480, 327);
            labelErreurMdp.Name = "labelErreurMdp";
            labelErreurMdp.Size = new Size(314, 23);
            labelErreurMdp.TabIndex = 29;
            labelErreurMdp.Text = "Erreur : le mot de passe est manquant";
            // 
            // buttonConnecter
            // 
            buttonConnecter.BackColor = Color.FromArgb(255, 235, 153);
            buttonConnecter.FlatStyle = FlatStyle.Popup;
            buttonConnecter.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConnecter.ForeColor = Color.Black;
            buttonConnecter.Location = new Point(682, 422);
            buttonConnecter.Margin = new Padding(5);
            buttonConnecter.Name = "buttonConnecter";
            buttonConnecter.Size = new Size(152, 57);
            buttonConnecter.TabIndex = 30;
            buttonConnecter.Text = "Se connecter";
            buttonConnecter.UseVisualStyleBackColor = false;
            buttonConnecter.Click += buttonConnecter_Click_1;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 530);
            Controls.Add(buttonConnecter);
            Controls.Add(labelErreurMdp);
            Controls.Add(labelErreurEmail);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(txt_mdp);
            Controls.Add(txt_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormConnexion";
            Text = "Form1";
            Load += FormConnexion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_id;
        private TextBox txt_mdp;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label labelErreurEmail;
        private Label labelErreurMdp;
        private Button buttonConnecter;
    }
}
