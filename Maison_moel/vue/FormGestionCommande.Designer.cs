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
            components = new System.ComponentModel.Container();
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
            buttonModifier = new Button();
            bindingSourceEtat = new BindingSource(components);
            bindingSourceServeur = new BindingSource(components);
            bindingSourceTable = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceServeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTable).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTable
            // 
            comboBoxTable.FormattingEnabled = true;
            comboBoxTable.Location = new Point(623, 168);
            comboBoxTable.Name = "comboBoxTable";
            comboBoxTable.Size = new Size(200, 23);
            comboBoxTable.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 125);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 51;
            label1.Text = "Etat";
            // 
            // comboEtat
            // 
            comboEtat.FormattingEnabled = true;
            comboEtat.Location = new Point(110, 168);
            comboEtat.Name = "comboEtat";
            comboEtat.Size = new Size(200, 23);
            comboEtat.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 125);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 53;
            label2.Text = "Serveur";
            // 
            // comboBoxServeur
            // 
            comboBoxServeur.FormattingEnabled = true;
            comboBoxServeur.Location = new Point(373, 168);
            comboBoxServeur.Name = "comboBoxServeur";
            comboBoxServeur.Size = new Size(200, 23);
            comboBoxServeur.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(682, 125);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 55;
            label3.Text = "Table";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 35, 40);
            panel3.Location = new Point(10, 62);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(920, 25);
            panel3.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(10, 359);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 25);
            panel1.TabIndex = 58;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 35, 40);
            panel5.Location = new Point(905, 62);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(25, 322);
            panel5.TabIndex = 59;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(10, 62);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 322);
            panel2.TabIndex = 60;
            // 
            // titre
            // 
            titre.AutoSize = true;
            titre.BackColor = Color.Transparent;
            titre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titre.Location = new Point(352, 20);
            titre.Name = "titre";
            titre.Size = new Size(242, 20);
            titre.TabIndex = 61;
            titre.Text = "Modification de la commande";
            // 
            // buttonModifier
            // 
            buttonModifier.BackColor = Color.FromArgb(30, 35, 40);
            buttonModifier.FlatStyle = FlatStyle.Popup;
            buttonModifier.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModifier.ForeColor = Color.White;
            buttonModifier.Location = new Point(426, 268);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(138, 23);
            buttonModifier.TabIndex = 62;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = false;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // FormGestionCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1026, 566);
            Controls.Add(buttonModifier);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionCommande";
            Text = "FormGestionCommande";
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceServeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTable).EndInit();
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
        private Button buttonModifier;
        private BindingSource bindingSourceEtat;
        private BindingSource bindingSourceServeur;
        private BindingSource bindingSourceTable;
    }
}