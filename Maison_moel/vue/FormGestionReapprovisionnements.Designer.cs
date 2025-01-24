namespace Maison_moel.vue
{
    partial class FormGestionReapprovisionnements
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
            dataGridViewReapprovisionnement = new DataGridView();
            pictureBoxNotification = new PictureBox();
            labelNotification = new Label();
            bindingSourceReapprovisionnement = new BindingSource(components);
            panelDatagridView = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReapprovisionnement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceReapprovisionnement).BeginInit();
            panelDatagridView.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewReapprovisionnement
            // 
            dataGridViewReapprovisionnement.AllowUserToAddRows = false;
            dataGridViewReapprovisionnement.AllowUserToDeleteRows = false;
            dataGridViewReapprovisionnement.AllowUserToOrderColumns = true;
            dataGridViewReapprovisionnement.AllowUserToResizeRows = false;
            dataGridViewReapprovisionnement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReapprovisionnement.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewReapprovisionnement.BorderStyle = BorderStyle.None;
            dataGridViewReapprovisionnement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewReapprovisionnement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReapprovisionnement.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewReapprovisionnement.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewReapprovisionnement.EnableHeadersVisualStyles = false;
            dataGridViewReapprovisionnement.GridColor = Color.Black;
            dataGridViewReapprovisionnement.Location = new Point(0, 0);
            dataGridViewReapprovisionnement.MultiSelect = false;
            dataGridViewReapprovisionnement.Name = "dataGridViewReapprovisionnement";
            dataGridViewReapprovisionnement.ReadOnly = true;
            dataGridViewReapprovisionnement.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewReapprovisionnement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewReapprovisionnement.RowHeadersVisible = false;
            dataGridViewReapprovisionnement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReapprovisionnement.Size = new Size(581, 466);
            dataGridViewReapprovisionnement.TabIndex = 0;
            // 
            // pictureBoxNotification
            // 
            pictureBoxNotification.BackColor = Color.Transparent;
            pictureBoxNotification.Image = Properties.Resources.imgNotif_removebg_preview;
            pictureBoxNotification.Location = new Point(12, 12);
            pictureBoxNotification.Name = "pictureBoxNotification";
            pictureBoxNotification.Size = new Size(108, 93);
            pictureBoxNotification.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNotification.TabIndex = 1;
            pictureBoxNotification.TabStop = false;
            pictureBoxNotification.DoubleClick += pictureBoxNotification_DoubleClick;
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.BackColor = Color.Transparent;
            labelNotification.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotification.ForeColor = Color.FromArgb(255, 235, 153);
            labelNotification.Location = new Point(91, 9);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(49, 36);
            labelNotification.TabIndex = 2;
            labelNotification.Text = "0+";
            labelNotification.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panelDatagridView
            // 
            panelDatagridView.Controls.Add(dataGridViewReapprovisionnement);
            panelDatagridView.Location = new Point(207, 48);
            panelDatagridView.Name = "panelDatagridView";
            panelDatagridView.Size = new Size(581, 466);
            panelDatagridView.TabIndex = 3;
            // 
            // FormGestionReapprovisionnements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL_modified1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1026, 566);
            Controls.Add(panelDatagridView);
            Controls.Add(labelNotification);
            Controls.Add(pictureBoxNotification);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionReapprovisionnements";
            Text = "FormGestionReapprovisionnements";
            Load += FormGestionReapprovisionnements_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReapprovisionnement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceReapprovisionnement).EndInit();
            panelDatagridView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReapprovisionnement;
        private PictureBox pictureBoxNotification;
        private Label labelNotification;
        private BindingSource bindingSourceReapprovisionnement;
        private Panel panelDatagridView;
    }
}