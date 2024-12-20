namespace Maison_moel.vue
{
    partial class Formcuisine
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formcuisine));
            DataGridCuisine = new DataGridView();
            bindingSourceCuisine = new BindingSource(components);
            panel3 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            labelRecherche = new Label();
            label1 = new Label();
            comboEtat = new ComboBox();
            bindingSourceEtat = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)DataGridCuisine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCuisine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtat).BeginInit();
            SuspendLayout();
            // 
            // DataGridCuisine
            // 
            DataGridCuisine.AllowUserToAddRows = false;
            DataGridCuisine.AllowUserToDeleteRows = false;
            DataGridCuisine.AllowUserToOrderColumns = true;
            DataGridCuisine.AllowUserToResizeRows = false;
            DataGridCuisine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridCuisine.BackgroundColor = Color.FromArgb(80, 85, 90);
            DataGridCuisine.BorderStyle = BorderStyle.Fixed3D;
            DataGridCuisine.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridCuisine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridCuisine.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridCuisine.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridCuisine.EnableHeadersVisualStyles = false;
            DataGridCuisine.GridColor = Color.FromArgb(255, 235, 153);
            DataGridCuisine.Location = new Point(73, 55);
            DataGridCuisine.Margin = new Padding(6, 7, 6, 7);
            DataGridCuisine.MultiSelect = false;
            DataGridCuisine.Name = "DataGridCuisine";
            DataGridCuisine.ReadOnly = true;
            DataGridCuisine.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridCuisine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridCuisine.RowHeadersVisible = false;
            DataGridCuisine.RowHeadersWidth = 55;
            DataGridCuisine.ScrollBars = ScrollBars.Horizontal;
            DataGridCuisine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridCuisine.Size = new Size(656, 477);
            DataGridCuisine.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 35, 40);
            panel3.Location = new Point(73, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(656, 33);
            panel3.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 35, 40);
            panel5.Location = new Point(724, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(29, 539);
            panel5.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(47, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(29, 511);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(47, 527);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 33);
            panel2.TabIndex = 25;
            // 
            // labelRecherche
            // 
            labelRecherche.AutoSize = true;
            labelRecherche.BackColor = Color.Transparent;
            labelRecherche.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecherche.Location = new Point(892, 64);
            labelRecherche.Name = "labelRecherche";
            labelRecherche.Size = new Size(169, 25);
            labelRecherche.TabIndex = 43;
            labelRecherche.Text = "Recherche Filtré";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(934, 155);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 44;
            label1.Text = "Par etat";
            // 
            // comboEtat
            // 
            comboEtat.FormattingEnabled = true;
            comboEtat.Location = new Point(879, 193);
            comboEtat.Margin = new Padding(3, 4, 3, 4);
            comboEtat.Name = "comboEtat";
            comboEtat.Size = new Size(228, 28);
            comboEtat.TabIndex = 45;
            // 
            // Formcuisine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1172, 795);
            Controls.Add(comboEtat);
            Controls.Add(label1);
            Controls.Add(labelRecherche);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(DataGridCuisine);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formcuisine";
            Text = "Formcuisine";
            Load += FormCuisine_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridCuisine).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCuisine).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEtat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridCuisine;
        private BindingSource bindingSourceCuisine;
        private Panel panel3;
        private Panel panel5;
        private Panel panel1;
        private Panel panel2;
        private Label labelRecherche;
        private Label label1;
        private ComboBox comboEtat;
        private BindingSource bindingSourceEtat;
    }
}