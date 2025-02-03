namespace Maison_moel.vue
{
    partial class FormCommande
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCommande = new DataGridView();
            bindingSourceCommande = new BindingSource(components);
            timerCommande = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCommande).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCommande
            // 
            dataGridViewCommande.AllowUserToAddRows = false;
            dataGridViewCommande.AllowUserToDeleteRows = false;
            dataGridViewCommande.AllowUserToOrderColumns = true;
            dataGridViewCommande.AllowUserToResizeRows = false;
            dataGridViewCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCommande.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewCommande.BorderStyle = BorderStyle.None;
            dataGridViewCommande.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle4.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCommande.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle5.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewCommande.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCommande.EnableHeadersVisualStyles = false;
            dataGridViewCommande.GridColor = Color.Black;
            dataGridViewCommande.Location = new Point(12, 12);
            dataGridViewCommande.MultiSelect = false;
            dataGridViewCommande.Name = "dataGridViewCommande";
            dataGridViewCommande.ReadOnly = true;
            dataGridViewCommande.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle6.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewCommande.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCommande.RowHeadersVisible = false;
            dataGridViewCommande.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCommande.Size = new Size(1000, 466);
            dataGridViewCommande.TabIndex = 10;
            // 
            // timerCommande
            // 
            timerCommande.Interval = 2000;
            timerCommande.Tick += timerCommande_Tick;
            // 
            // FormCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL_modified1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 490);
            Controls.Add(dataGridViewCommande);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCommande";
            Text = "FormCommande";
            Load += FormCommande_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCommande).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCommande;
        private BindingSource bindingSourceCommande;
        private System.Windows.Forms.Timer timerCommande;
    }
}