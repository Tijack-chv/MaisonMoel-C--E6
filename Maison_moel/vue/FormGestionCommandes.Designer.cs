namespace Maison_moel.vue
{
    partial class FormGestionCommandes
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
            dataGridViewCommande = new DataGridView();
            contextMenuStripCommande = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommande).BeginInit();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCommande.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCommande.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCommande.EnableHeadersVisualStyles = false;
            dataGridViewCommande.GridColor = Color.Black;
            dataGridViewCommande.Location = new Point(235, 12);
            dataGridViewCommande.MultiSelect = false;
            dataGridViewCommande.Name = "dataGridViewCommande";
            dataGridViewCommande.ReadOnly = true;
            dataGridViewCommande.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCommande.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCommande.RowHeadersVisible = false;
            dataGridViewCommande.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCommande.Size = new Size(557, 436);
            dataGridViewCommande.TabIndex = 10;
            // 
            // contextMenuStripCommande
            // 
            contextMenuStripCommande.Name = "contextMenuStripCommande";
            contextMenuStripCommande.Size = new Size(61, 4);
            // 
            // FormGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 460);
            Controls.Add(dataGridViewCommande);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionCommandes";
            Text = "FormGestionCommandes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommande).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCommande;
        private ContextMenuStrip contextMenuStripCommande;
    }
}