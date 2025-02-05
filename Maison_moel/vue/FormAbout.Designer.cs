namespace Maison_moel.vue
{
    partial class FormAbout
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
            dataGridViewEvenement = new DataGridView();
            contextMenuStripEvenements = new ContextMenuStrip(components);
            insertionToolStripMenuItem = new ToolStripMenuItem();
            UpdateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            bindingSourceEvenement = new BindingSource(components);
            panelEvenement = new Panel();
            label2 = new Label();
            label1 = new Label();
            buttonValider = new Button();
            buttonAnnuler = new Button();
            labelImageEvenement = new Label();
            pictureBoxEvenement = new PictureBox();
            dateTimePickerEvenement = new DateTimePicker();
            textBoxDescriptionEvenement = new TextBox();
            comboBoxTypeEvenement = new ComboBox();
            bindingSourceTypeEvenement = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvenement).BeginInit();
            contextMenuStripEvenements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEvenement).BeginInit();
            panelEvenement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEvenement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTypeEvenement).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEvenement
            // 
            dataGridViewEvenement.AllowUserToAddRows = false;
            dataGridViewEvenement.AllowUserToDeleteRows = false;
            dataGridViewEvenement.AllowUserToOrderColumns = true;
            dataGridViewEvenement.AllowUserToResizeRows = false;
            dataGridViewEvenement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEvenement.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewEvenement.BorderStyle = BorderStyle.None;
            dataGridViewEvenement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEvenement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEvenement.ColumnHeadersHeight = 30;
            dataGridViewEvenement.ContextMenuStrip = contextMenuStripEvenements;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewEvenement.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEvenement.EnableHeadersVisualStyles = false;
            dataGridViewEvenement.GridColor = Color.Black;
            dataGridViewEvenement.Location = new Point(22, 12);
            dataGridViewEvenement.MultiSelect = false;
            dataGridViewEvenement.Name = "dataGridViewEvenement";
            dataGridViewEvenement.ReadOnly = true;
            dataGridViewEvenement.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 15, 20);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 235, 153);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewEvenement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEvenement.RowHeadersVisible = false;
            dataGridViewEvenement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEvenement.Size = new Size(581, 466);
            dataGridViewEvenement.TabIndex = 10;
            // 
            // contextMenuStripEvenements
            // 
            contextMenuStripEvenements.BackColor = Color.FromArgb(15, 20, 25);
            contextMenuStripEvenements.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            contextMenuStripEvenements.Items.AddRange(new ToolStripItem[] { insertionToolStripMenuItem, UpdateToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStripEvenements.Name = "contextMenuStripPlats";
            contextMenuStripEvenements.Size = new Size(250, 70);
            // 
            // insertionToolStripMenuItem
            // 
            insertionToolStripMenuItem.BackgroundImage = Properties.Resources.gradient_1920_1080V2;
            insertionToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            insertionToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            insertionToolStripMenuItem.Image = Properties.Resources.Arrow_Right_I01_watermarked_2k;
            insertionToolStripMenuItem.ImageTransparentColor = Color.FromArgb(255, 235, 153);
            insertionToolStripMenuItem.Name = "insertionToolStripMenuItem";
            insertionToolStripMenuItem.Size = new Size(249, 22);
            insertionToolStripMenuItem.Text = "Insertion Evenement";
            insertionToolStripMenuItem.Click += insertionToolStripMenuItem_Click;
            // 
            // UpdateToolStripMenuItem
            // 
            UpdateToolStripMenuItem.BackgroundImage = Properties.Resources.gradient_1920_1080V2;
            UpdateToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            UpdateToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            UpdateToolStripMenuItem.Image = Properties.Resources.Arrow_Right_I01_watermarked_2k;
            UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            UpdateToolStripMenuItem.Size = new Size(249, 22);
            UpdateToolStripMenuItem.Text = "Mise à jour Evenement";
            UpdateToolStripMenuItem.Click += UpdateToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackgroundImage = Properties.Resources.gradient_1920_1080V2;
            deleteToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            deleteToolStripMenuItem.ForeColor = Color.FromArgb(255, 235, 153);
            deleteToolStripMenuItem.Image = Properties.Resources.Arrow_Right_I01_watermarked_2k;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(249, 22);
            deleteToolStripMenuItem.Text = "Suppression Evenement";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // panelEvenement
            // 
            panelEvenement.BackColor = Color.FromArgb(20, 25, 30);
            panelEvenement.Controls.Add(label2);
            panelEvenement.Controls.Add(label1);
            panelEvenement.Controls.Add(buttonValider);
            panelEvenement.Controls.Add(buttonAnnuler);
            panelEvenement.Controls.Add(labelImageEvenement);
            panelEvenement.Controls.Add(pictureBoxEvenement);
            panelEvenement.Controls.Add(dateTimePickerEvenement);
            panelEvenement.Controls.Add(textBoxDescriptionEvenement);
            panelEvenement.Controls.Add(comboBoxTypeEvenement);
            panelEvenement.Location = new Point(639, 12);
            panelEvenement.Name = "panelEvenement";
            panelEvenement.Size = new Size(345, 466);
            panelEvenement.TabIndex = 12;
            panelEvenement.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 235, 153);
            label2.Location = new Point(97, 18);
            label2.Name = "label2";
            label2.Size = new Size(149, 18);
            label2.TabIndex = 9;
            label2.Text = "Type d'évènement :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 235, 153);
            label1.Location = new Point(69, 74);
            label1.Name = "label1";
            label1.Size = new Size(205, 18);
            label1.TabIndex = 8;
            label1.Text = "Description de l'évènement";
            // 
            // buttonValider
            // 
            buttonValider.FlatStyle = FlatStyle.Popup;
            buttonValider.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonValider.ForeColor = Color.FromArgb(255, 235, 153);
            buttonValider.Location = new Point(57, 426);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(103, 32);
            buttonValider.TabIndex = 7;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.FlatStyle = FlatStyle.Popup;
            buttonAnnuler.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAnnuler.ForeColor = Color.FromArgb(255, 235, 153);
            buttonAnnuler.Location = new Point(183, 426);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(103, 32);
            buttonAnnuler.TabIndex = 6;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // labelImageEvenement
            // 
            labelImageEvenement.AutoSize = true;
            labelImageEvenement.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            labelImageEvenement.ForeColor = Color.FromArgb(255, 235, 153);
            labelImageEvenement.Location = new Point(125, 386);
            labelImageEvenement.Name = "labelImageEvenement";
            labelImageEvenement.Size = new Size(93, 18);
            labelImageEvenement.TabIndex = 4;
            labelImageEvenement.Text = "Parcourir...";
            labelImageEvenement.Click += labelImageEvenement_Click;
            // 
            // pictureBoxEvenement
            // 
            pictureBoxEvenement.Location = new Point(84, 240);
            pictureBoxEvenement.Name = "pictureBoxEvenement";
            pictureBoxEvenement.Size = new Size(174, 134);
            pictureBoxEvenement.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEvenement.TabIndex = 3;
            pictureBoxEvenement.TabStop = false;
            // 
            // dateTimePickerEvenement
            // 
            dateTimePickerEvenement.CalendarForeColor = Color.FromArgb(255, 235, 153);
            dateTimePickerEvenement.CalendarMonthBackground = Color.FromArgb(20, 25, 30);
            dateTimePickerEvenement.CalendarTitleBackColor = Color.FromArgb(30, 35, 40);
            dateTimePickerEvenement.CalendarTitleForeColor = Color.FromArgb(255, 235, 153);
            dateTimePickerEvenement.CalendarTrailingForeColor = Color.FromArgb(255, 235, 153);
            dateTimePickerEvenement.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            dateTimePickerEvenement.Location = new Point(35, 193);
            dateTimePickerEvenement.MinDate = new DateTime(1799, 12, 25, 23, 59, 0, 0);
            dateTimePickerEvenement.Name = "dateTimePickerEvenement";
            dateTimePickerEvenement.Size = new Size(272, 26);
            dateTimePickerEvenement.TabIndex = 2;
            dateTimePickerEvenement.Value = new DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // textBoxDescriptionEvenement
            // 
            textBoxDescriptionEvenement.BackColor = Color.FromArgb(40, 45, 50);
            textBoxDescriptionEvenement.BorderStyle = BorderStyle.None;
            textBoxDescriptionEvenement.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            textBoxDescriptionEvenement.ForeColor = Color.FromArgb(255, 235, 153);
            textBoxDescriptionEvenement.Location = new Point(35, 95);
            textBoxDescriptionEvenement.Multiline = true;
            textBoxDescriptionEvenement.Name = "textBoxDescriptionEvenement";
            textBoxDescriptionEvenement.Size = new Size(272, 74);
            textBoxDescriptionEvenement.TabIndex = 1;
            // 
            // comboBoxTypeEvenement
            // 
            comboBoxTypeEvenement.BackColor = Color.FromArgb(40, 45, 50);
            comboBoxTypeEvenement.FlatStyle = FlatStyle.Popup;
            comboBoxTypeEvenement.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            comboBoxTypeEvenement.ForeColor = Color.FromArgb(255, 235, 153);
            comboBoxTypeEvenement.FormattingEnabled = true;
            comboBoxTypeEvenement.Location = new Point(84, 39);
            comboBoxTypeEvenement.Name = "comboBoxTypeEvenement";
            comboBoxTypeEvenement.Size = new Size(174, 26);
            comboBoxTypeEvenement.TabIndex = 0;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL_modified1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 490);
            Controls.Add(panelEvenement);
            Controls.Add(dataGridViewEvenement);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAbout";
            Text = "FormAbout";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvenement).EndInit();
            contextMenuStripEvenements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceEvenement).EndInit();
            panelEvenement.ResumeLayout(false);
            panelEvenement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEvenement).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTypeEvenement).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEvenement;
        private BindingSource bindingSourceEvenement;
        private ContextMenuStrip contextMenuStripEvenements;
        private ToolStripMenuItem insertionToolStripMenuItem;
        private ToolStripMenuItem UpdateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panelEvenement;
        private DateTimePicker dateTimePickerEvenement;
        private TextBox textBoxDescriptionEvenement;
        private ComboBox comboBoxTypeEvenement;
        private Label labelImageEvenement;
        private PictureBox pictureBoxEvenement;
        private Button buttonValider;
        private Button buttonAnnuler;
        private BindingSource bindingSourceTypeEvenement;
        private Label label2;
        private Label label1;
    }
}