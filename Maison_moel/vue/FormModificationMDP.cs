using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maison_moel.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maison_moel.vue
{
    public partial class FormModificationMDP : Form
    {
        private int id;
        public FormModificationMDP()
        {
            InitializeComponent();
        }

        public FormModificationMDP(int id)
        {
            InitializeComponent();
            this.id = id;
            textBox_mdp.UseSystemPasswordChar = true;
            textBox_confirmerMDP.UseSystemPasswordChar = true;

        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            if (textBox_mdp.Text == textBox_confirmerMDP.Text)
            {   
                if (TestValidation.EstMotDePasseValide(textBox_mdp.Text))
                {
                    ModelPersonne.ModifierMDP(id, textBox_mdp.Text);
                    MessageBox.Show("Mot de passe modifié avec succès");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas");
            }
        }
    }
}
