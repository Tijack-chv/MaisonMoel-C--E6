namespace Maison_moel.vue
{
    partial class FormModificationMDP
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
            textBox_mdp = new TextBox();
            textBox_confirmerMDP = new TextBox();
            label_titre = new Label();
            label_MDP = new Label();
            label_confirm = new Label();
            button_annuler = new Button();
            button_valider = new Button();
            SuspendLayout();
            // 
            // textBox_mdp
            // 
            textBox_mdp.Location = new Point(29, 155);
            textBox_mdp.Name = "textBox_mdp";
            textBox_mdp.Size = new Size(212, 23);
            textBox_mdp.TabIndex = 0;
            // 
            // textBox_confirmerMDP
            // 
            textBox_confirmerMDP.Location = new Point(29, 228);
            textBox_confirmerMDP.Name = "textBox_confirmerMDP";
            textBox_confirmerMDP.Size = new Size(212, 23);
            textBox_confirmerMDP.TabIndex = 1;
            // 
            // label_titre
            // 
            label_titre.AutoSize = true;
            label_titre.BackColor = Color.Transparent;
            label_titre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_titre.Location = new Point(29, 60);
            label_titre.Name = "label_titre";
            label_titre.Size = new Size(174, 20);
            label_titre.TabIndex = 2;
            label_titre.Text = "Modification du MDP";
            // 
            // label_MDP
            // 
            label_MDP.AutoSize = true;
            label_MDP.BackColor = Color.Transparent;
            label_MDP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_MDP.Location = new Point(29, 128);
            label_MDP.Name = "label_MDP";
            label_MDP.Size = new Size(132, 20);
            label_MDP.TabIndex = 3;
            label_MDP.Text = "Nouveau MDP :";
            // 
            // label_confirm
            // 
            label_confirm.AutoSize = true;
            label_confirm.BackColor = Color.Transparent;
            label_confirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_confirm.Location = new Point(29, 200);
            label_confirm.Name = "label_confirm";
            label_confirm.Size = new Size(134, 20);
            label_confirm.TabIndex = 4;
            label_confirm.Text = "Confimer MDP :";
            // 
            // button_annuler
            // 
            button_annuler.BackColor = Color.FromArgb(255, 128, 128);
            button_annuler.Location = new Point(29, 318);
            button_annuler.Name = "button_annuler";
            button_annuler.Size = new Size(97, 23);
            button_annuler.TabIndex = 5;
            button_annuler.Text = "ANNULER";
            button_annuler.UseVisualStyleBackColor = false;
            button_annuler.Click += button_annuler_Click;
            // 
            // button_valider
            // 
            button_valider.BackColor = Color.FromArgb(128, 255, 128);
            button_valider.Location = new Point(144, 318);
            button_valider.Name = "button_valider";
            button_valider.Size = new Size(97, 23);
            button_valider.TabIndex = 6;
            button_valider.Text = "VALIDER";
            button_valider.UseVisualStyleBackColor = false;
            button_valider.Click += button_valider_Click;
            // 
            // FormModificationMDP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient_1500_1500_1_;
            ClientSize = new Size(296, 429);
            Controls.Add(button_valider);
            Controls.Add(button_annuler);
            Controls.Add(label_confirm);
            Controls.Add(label_MDP);
            Controls.Add(label_titre);
            Controls.Add(textBox_confirmerMDP);
            Controls.Add(textBox_mdp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificationMDP";
            Text = "FormModificationMDP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_mdp;
        private TextBox textBox_confirmerMDP;
        private Label label_titre;
        private Label label_MDP;
        private Label label_confirm;
        private Button button_annuler;
        private Button button_valider;
    }
}