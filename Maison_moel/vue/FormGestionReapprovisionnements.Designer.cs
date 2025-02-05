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
            pictureBoxNotification = new PictureBox();
            labelNotification = new Label();
            bindingSource = new BindingSource(components);
            dataGridView = new DataGridView();
            panelReappro = new Panel();
            numericUpDownReappro = new NumericUpDown();
            labelReappro = new Label();
            panelButton = new Panel();
            buttonReapprovisionnements = new Button();
            buttonPlats = new Button();
            textBoxPage = new TextBox();
            buttonPrec = new Button();
            buttonSuiv = new Button();
            panelPage = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelReappro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReappro).BeginInit();
            panelButton.SuspendLayout();
            panelPage.SuspendLayout();
            SuspendLayout();
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
            pictureBoxNotification.Click += pictureBoxNotification_Click;
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
            dataGridView.Location = new Point(208, 54);
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
            dataGridView.Size = new Size(581, 356);
            dataGridView.TabIndex = 9;
            dataGridView.DoubleClick += dataGridView_DoubleClick;
            // 
            // panelReappro
            // 
            panelReappro.BackColor = Color.FromArgb(5, 10, 15);
            panelReappro.Controls.Add(numericUpDownReappro);
            panelReappro.Controls.Add(labelReappro);
            panelReappro.Location = new Point(830, 16);
            panelReappro.Name = "panelReappro";
            panelReappro.Size = new Size(152, 123);
            panelReappro.TabIndex = 7;
            panelReappro.Visible = false;
            // 
            // numericUpDownReappro
            // 
            numericUpDownReappro.BackColor = Color.FromArgb(15, 20, 25);
            numericUpDownReappro.BorderStyle = BorderStyle.None;
            numericUpDownReappro.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            numericUpDownReappro.ForeColor = Color.FromArgb(255, 235, 153);
            numericUpDownReappro.Location = new Point(5, 73);
            numericUpDownReappro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownReappro.Name = "numericUpDownReappro";
            numericUpDownReappro.Size = new Size(143, 22);
            numericUpDownReappro.TabIndex = 5;
            numericUpDownReappro.TextAlign = HorizontalAlignment.Center;
            numericUpDownReappro.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelReappro
            // 
            labelReappro.AutoSize = true;
            labelReappro.BackColor = Color.Transparent;
            labelReappro.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReappro.ForeColor = Color.FromArgb(255, 235, 153);
            labelReappro.Location = new Point(3, 9);
            labelReappro.Name = "labelReappro";
            labelReappro.Size = new Size(145, 36);
            labelReappro.TabIndex = 6;
            labelReappro.Text = "Quantité\r\nà réapprovisionner";
            labelReappro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            panelButton.BackColor = Color.FromArgb(15, 20, 25);
            panelButton.Controls.Add(buttonReapprovisionnements);
            panelButton.Controls.Add(buttonPlats);
            panelButton.Location = new Point(273, 13);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(450, 29);
            panelButton.TabIndex = 4;
            // 
            // buttonReapprovisionnements
            // 
            buttonReapprovisionnements.BackColor = Color.Transparent;
            buttonReapprovisionnements.FlatStyle = FlatStyle.Popup;
            buttonReapprovisionnements.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReapprovisionnements.ForeColor = Color.FromArgb(255, 235, 153);
            buttonReapprovisionnements.Location = new Point(161, 3);
            buttonReapprovisionnements.Name = "buttonReapprovisionnements";
            buttonReapprovisionnements.Size = new Size(285, 23);
            buttonReapprovisionnements.TabIndex = 6;
            buttonReapprovisionnements.Text = "Ensemble des réapprovisionnements";
            buttonReapprovisionnements.UseVisualStyleBackColor = false;
            buttonReapprovisionnements.Click += buttonReapprovisionnements_Click;
            // 
            // buttonPlats
            // 
            buttonPlats.BackColor = Color.Transparent;
            buttonPlats.FlatStyle = FlatStyle.Popup;
            buttonPlats.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPlats.ForeColor = Color.FromArgb(255, 235, 153);
            buttonPlats.Location = new Point(3, 3);
            buttonPlats.Name = "buttonPlats";
            buttonPlats.Size = new Size(155, 23);
            buttonPlats.TabIndex = 5;
            buttonPlats.Text = "Ensemble des plats ";
            buttonPlats.UseVisualStyleBackColor = false;
            buttonPlats.Click += buttonPlats_Click;
            // 
            // textBoxPage
            // 
            textBoxPage.BackColor = Color.FromArgb(20, 25, 30);
            textBoxPage.BorderStyle = BorderStyle.None;
            textBoxPage.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            textBoxPage.ForeColor = Color.FromArgb(255, 235, 153);
            textBoxPage.Location = new Point(250, 5);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(100, 19);
            textBoxPage.TabIndex = 5;
            textBoxPage.Text = "1";
            textBoxPage.TextAlign = HorizontalAlignment.Center;
            textBoxPage.TextChanged += textBoxPage_TextChanged;
            textBoxPage.KeyPress += textBoxPage_KeyPress;
            // 
            // buttonPrec
            // 
            buttonPrec.BackColor = Color.FromArgb(20, 25, 30);
            buttonPrec.Enabled = false;
            buttonPrec.FlatStyle = FlatStyle.Popup;
            buttonPrec.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            buttonPrec.ForeColor = Color.FromArgb(255, 235, 153);
            buttonPrec.Location = new Point(158, 3);
            buttonPrec.Name = "buttonPrec";
            buttonPrec.Size = new Size(90, 23);
            buttonPrec.TabIndex = 6;
            buttonPrec.Text = "Précédent";
            buttonPrec.TextAlign = ContentAlignment.TopCenter;
            buttonPrec.UseVisualStyleBackColor = false;
            buttonPrec.Click += buttonPrec_Click;
            // 
            // buttonSuiv
            // 
            buttonSuiv.BackColor = Color.FromArgb(20, 25, 30);
            buttonSuiv.FlatStyle = FlatStyle.Popup;
            buttonSuiv.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            buttonSuiv.ForeColor = Color.FromArgb(255, 235, 153);
            buttonSuiv.Location = new Point(352, 3);
            buttonSuiv.Name = "buttonSuiv";
            buttonSuiv.Size = new Size(90, 23);
            buttonSuiv.TabIndex = 7;
            buttonSuiv.Text = "Suivant";
            buttonSuiv.TextAlign = ContentAlignment.TopCenter;
            buttonSuiv.UseVisualStyleBackColor = false;
            buttonSuiv.Click += buttonSuiv_Click;
            // 
            // panelPage
            // 
            panelPage.BackColor = Color.FromArgb(15, 20, 25);
            panelPage.Controls.Add(buttonPrec);
            panelPage.Controls.Add(buttonSuiv);
            panelPage.Controls.Add(textBoxPage);
            panelPage.Location = new Point(208, 410);
            panelPage.Name = "panelPage";
            panelPage.Size = new Size(581, 30);
            panelPage.TabIndex = 8;
            // 
            // FormGestionReapprovisionnements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FOND_ACCUEIL_modified1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 460);
            Controls.Add(dataGridView);
            Controls.Add(panelReappro);
            Controls.Add(panelPage);
            Controls.Add(panelButton);
            Controls.Add(labelNotification);
            Controls.Add(pictureBoxNotification);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionReapprovisionnements";
            Text = "FormGestionReapprovisionnements";
            Load += FormGestionReapprovisionnements_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelReappro.ResumeLayout(false);
            panelReappro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReappro).EndInit();
            panelButton.ResumeLayout(false);
            panelPage.ResumeLayout(false);
            panelPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxNotification;
        private Label labelNotification;
        private BindingSource bindingSource;
        private Panel panelButton;
        private Button buttonReapprovisionnements;
        private Button buttonPlats;
        private NumericUpDown numericUpDownReappro;
        private Label labelReappro;
        private Panel panelReappro;
        private TextBox textBoxPage;
        private Button buttonPrec;
        private Button buttonSuiv;
        private Panel panelPage;
        private DataGridView dataGridView;
    }
}