using ApplicationC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Maison_moel.vue
{
    public partial class FormGestionCommande : Form
    {
        private int idCommande;
        private string etat;
        private string serveur;
        private string table;

        public FormGestionCommande(int id, string etat, string serveur, string table)
        {
            InitializeComponent();

            // Stocker les paramètres dans les champs privés
            this.idCommande = id;
            this.etat = etat;
            this.serveur = serveur;
            this.table = table;

            comboEtat.Text = etat;    
            comboBoxServeur.Text = serveur;
            comboBoxTable.Text = table;
        }
    }
}
