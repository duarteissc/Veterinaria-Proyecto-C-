using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VeterinariaT1.Controller
{
    class ControllerUC
    {
        public void CargarUCGrid(Grid g, UserControl uc)
        {
            if (g.Children.Count != 0) //tiene objetos adentro y si es verdad que tiene
            {
                g.Children.Clear();
                g.Children.Add(uc);

            }
            else
                g.Children.Add(uc);
        }
    }
}
