namespace Maison_moel.vue
{
    partial class FormGestionCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionCommande));
            comboBoxTable = new ComboBox();
            label1 = new Label();
            comboEtat = new ComboBox();
            label2 = new Label();
            comboBoxServeur = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            titre = new Label();
            SuspendLayout();
            // 
            // comboBoxTable
            // 
            comboBoxTable.FormattingEnabled = true;
            comboBoxTable.Location = new Point(126, 403);
            comboBoxTable.Margin = new Padding(3, 4, 3, 4);
            comboBoxTable.Name = "comboBoxTable";
            comboBoxTable.Size = new Size(228, 28);
            comboBoxTable.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 147);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 51;
            label1.Text = "Etat";
            // 
            // comboEtat
            // 
            comboEtat.FormattingEnabled = true;
            comboEtat.Location = new Point(126, 197);
            comboEtat.Margin = new Padding(3, 4, 3, 4);
            comboEtat.Name = "comboEtat";
            comboEtat.Size = new Size(228, 28);
            comboEtat.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 256);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 53;
            label2.Text = "Serveur";
            // 
            // comboBoxServeur
            // 
            comboBoxServeur.FormattingEnabled = true;
            comboBoxServeur.Location = new Point(126, 299);
            comboBoxServeur.Margin = new Padding(3, 4, 3, 4);
            comboBoxServeur.Name = "comboBoxServeur";
            comboBoxServeur.Size = new Size(228, 28);
            comboBoxServeur.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(191, 357);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 55;
            label3.Text = "Table";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 35, 40);
            panel3.Location = new Point(12, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(462, 33);
            panel3.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(12, 479);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 33);
            panel1.TabIndex = 58;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 35, 40);
            panel5.Location = new Point(470, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(29, 429);
            panel5.TabIndex = 59;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(12, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(29, 429);
            panel2.TabIndex = 60;
            // 
            // titre
            // 
            titre.AutoSize = true;
            titre.BackColor = Color.Transparent;
            titre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titre.Location = new Point(667, 73);
            titre.Name = "titre";
            titre.Size = new Size(292, 25);
            titre.TabIndex = 61;
            titre.Text = "Modification de la commande";
            // 
            // FormGestionCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1154, 748);
            Controls.Add(titre);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(comboBoxTable);
            Controls.Add(label3);
            Controls.Add(comboBoxServeur);
            Controls.Add(label2);
            Controls.Add(comboEtat);
            Controls.Add(label1);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionCommande";
            Text = "FormGestionCommande";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTable;
        private Label label1;
        private ComboBox comboEtat;
        private Label label2;
        private ComboBox comboBoxServeur;
        private Label label3;
        private Panel panel3;
        private Panel panel1;
        private Panel panel5;
        private Panel panel2;
        private Label titre;
    }
}