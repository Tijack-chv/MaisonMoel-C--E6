using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC.Controller
{
    public class SFormulaire
    {
        #region Attribut
        public Panel PanelSousFormlaire;
        public Form activeForm = null;
        #endregion

        #region Constructeur
        public SFormulaire(Panel panelenvoit)
        {
            PanelSousFormlaire = panelenvoit;
        }
        #endregion

        #region openChildForm
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            PanelSousFormlaire.Controls.Add(formEnfant);
            formEnfant.BringToFront();
            formEnfant.Show();
        }
        #endregion

        #region closeChildForm
        public void closeChildForm()
        {
            if (activeForm != null)
                activeForm.Close();
        }
        #endregion
    }
}
