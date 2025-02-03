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
            dataGridView = new DataGridView();
            contextMenuStripCommande = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.Black;
            dataGridView.Location = new Point(217, 12);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(557, 436);
            dataGridView.TabIndex = 10;
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
            Controls.Add(dataGridView);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionCommandes";
            Text = "FormGestionCommandes";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private ContextMenuStrip contextMenuStripCommande;
    }
}