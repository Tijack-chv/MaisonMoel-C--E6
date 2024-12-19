using Maison_moel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maison_moel.vue
{
    public partial class FormHome : Form
    {
        public FormHome(bool est_admin)
        {
            bool admin = est_admin; 
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.Load("http://192.168.143.9:8080/images/LOGO_TRANS.png");
        }
    }
}
