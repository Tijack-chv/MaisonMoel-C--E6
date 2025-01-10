namespace Maison_moel.vue
{
    partial class FormAdministration
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
            dataGridPersonne = new DataGridView();
            comboBox_Metier = new ComboBox();
            label_filtreMetier = new Label();
            bindingSourcePersonnes = new BindingSource(components);
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridPersonne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonnes).BeginInit();
            SuspendLayout();
            // 
            // dataGridPersonne
            // 
            dataGridPersonne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPersonne.GridColor = Color.FromArgb(255, 235, 153);
            dataGridPersonne.Location = new Point(359, 93);
            dataGridPersonne.Name = "dataGridPersonne";
            dataGridPersonne.Size = new Size(571, 363);
            dataGridPersonne.TabIndex = 0;
            // 
            // comboBox_Metier
            // 
            comboBox_Metier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Metier.FormattingEnabled = true;
            comboBox_Metier.Location = new Point(41, 109);
            comboBox_Metier.Name = "comboBox_Metier";
            comboBox_Metier.Size = new Size(213, 23);
            comboBox_Metier.TabIndex = 1;
            comboBox_Metier.SelectedIndexChanged += comboBox_metier_SelectedIndexChanged;
            // 
            // label_filtreMetier
            // 
            label_filtreMetier.AutoSize = true;
            label_filtreMetier.BackColor = Color.Transparent;
            label_filtreMetier.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtreMetier.Location = new Point(43, 75);
            label_filtreMetier.Name = "label_filtreMetier";
            label_filtreMetier.Size = new Size(142, 20);
            label_filtreMetier.TabIndex = 2;
            label_filtreMetier.Text = "Filtrer par métier";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 35, 40);
            panel5.Location = new Point(930, 75);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(22, 404);
            panel5.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(340, 75);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(22, 404);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(340, 453);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 26);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 35, 40);
            panel3.Location = new Point(340, 75);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 20);
            panel3.TabIndex = 27;
            // 
            // FormAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_1500_1500_1_;
            ClientSize = new Size(1010, 557);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(label_filtreMetier);
            Controls.Add(comboBox_Metier);
            Controls.Add(dataGridPersonne);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdministration";
            Text = "Form_Administration";
            Load += Form_Administration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPersonne).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersonnes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPersonne;
        private ComboBox comboBox_Metier;
        private Label label_filtreMetier;
        private BindingSource bindingSourcePersonnes;
        private Panel panel5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}