using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_moel.controller
{
    public class ComponentStyle
    {
        public void arrondirBordureObjet(Control component)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(0, 0, component.Width - 3, component.Height - 3);
            Region rg = new Region(graphicsPath);
            component.Region = rg;
        }

        public void arrondirBordureObjet(Control component, int value)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(0, 0, component.Width - value, component.Height - value);
            Region rg = new Region(graphicsPath);
            component.Region = rg;
        }
    }
}
