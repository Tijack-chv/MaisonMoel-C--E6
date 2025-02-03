using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
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

        public void arrondirBordurObjetSimple(Control component, int radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            int arcSize = radius * 2;

            graphicsPath.AddArc(0, 0, arcSize, arcSize, 180, 90);
            graphicsPath.AddArc(component.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            graphicsPath.AddArc(component.Width - arcSize, component.Height - arcSize, arcSize, arcSize, 0, 90);
            graphicsPath.AddArc(0, component.Height - arcSize, arcSize, arcSize, 90, 90);
            graphicsPath.CloseFigure();

            component.Region = new Region(graphicsPath);

        }
    }
}
