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
            label_filtreNom = new Label();
            txtbx_filtreNom = new TextBox();
            txtbx_filtrePrenom = new TextBox();
            label_filtrePrenom = new Label();
            label1 = new Label();
            dateTimePicker_DateNaissance = new DateTimePicker();
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
            label_filtreMetier.Size = new Size(152, 20);
            label_filtreMetier.TabIndex = 2;
            label_filtreMetier.Text = "Filtrer par métier :";
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
            // label_filtreNom
            // 
            label_filtreNom.AutoSize = true;
            label_filtreNom.BackColor = Color.Transparent;
            label_filtreNom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtreNom.Location = new Point(41, 169);
            label_filtreNom.Name = "label_filtreNom";
            label_filtreNom.Size = new Size(136, 20);
            label_filtreNom.TabIndex = 28;
            label_filtreNom.Text = "Filtrer par nom :";
            // 
            // txtbx_filtreNom
            // 
            txtbx_filtreNom.Location = new Point(43, 209);
            txtbx_filtreNom.Name = "txtbx_filtreNom";
            txtbx_filtreNom.Size = new Size(211, 23);
            txtbx_filtreNom.TabIndex = 29;
            txtbx_filtreNom.TextChanged += txtbx_filtreNom_TextChanged;
            // 
            // txtbx_filtrePrenom
            // 
            txtbx_filtrePrenom.Location = new Point(43, 302);
            txtbx_filtrePrenom.Name = "txtbx_filtrePrenom";
            txtbx_filtrePrenom.Size = new Size(211, 23);
            txtbx_filtrePrenom.TabIndex = 31;
            txtbx_filtrePrenom.TextChanged += txtbx_filtrePrenom_TextChanged;
            // 
            // label_filtrePrenom
            // 
            label_filtrePrenom.AutoSize = true;
            label_filtrePrenom.BackColor = Color.Transparent;
            label_filtrePrenom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_filtrePrenom.Location = new Point(41, 262);
            label_filtrePrenom.Name = "label_filtrePrenom";
            label_filtrePrenom.Size = new Size(162, 20);
            label_filtrePrenom.TabIndex = 30;
            label_filtrePrenom.Text = "Filtrer par prénom :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(43, 352);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 32;
            label1.Text = "Filtrer par Date de Naissance :";
            // 
            // dateTimePicker_DateNaissance
            // 
            dateTimePicker_DateNaissance.Location = new Point(43, 392);
            dateTimePicker_DateNaissance.MaxDate = new DateTime(2025, 1, 17, 0, 0, 0, 0);
            dateTimePicker_DateNaissance.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dateTimePicker_DateNaissance.Name = "dateTimePicker_DateNaissance";
            dateTimePicker_DateNaissance.Size = new Size(211, 23);
            dateTimePicker_DateNaissance.TabIndex = 33;
            dateTimePicker_DateNaissance.Value = new DateTime(1975, 1, 1, 0, 0, 0, 0);
            dateTimePicker_DateNaissance.ValueChanged += dateTimePicker_DateNaissance_ValueChanged;
            // 
            // FormAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_1500_1500_1_;
            ClientSize = new Size(1010, 557);
            Controls.Add(dateTimePicker_DateNaissance);
            Controls.Add(label1);
            Controls.Add(txtbx_filtrePrenom);
            Controls.Add(label_filtrePrenom);
            Controls.Add(txtbx_filtreNom);
            Controls.Add(label_filtreNom);
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
        private Label label_filtreNom;
        private TextBox txtbx_filtreNom;
        private TextBox txtbx_filtrePrenom;
        private Label label_filtrePrenom;
        private Label label1;
        private DateTimePicker dateTimePicker_DateNaissance;
    }
}