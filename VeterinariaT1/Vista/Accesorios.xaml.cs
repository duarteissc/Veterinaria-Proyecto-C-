using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VeterinariaT1.Controller;
using VeterinariaT1.Modelo;

namespace VeterinariaT1.Vista
{
    /// <summary>
    /// Lógica de interacción para Accesorios.xaml
    /// </summary>
    public partial class Accesorios : UserControl
    {
        public Accesorios()
        {
            InitializeComponent();
            CargarAccesorios();
            CargarCompra();
        }
        public void CargarAccesorios()
        {
            ControladorAccesorios objCAU = new ControladorAccesorios();
            dtgLista.ItemsSource = objCAU.AllAccesorio();
        }
        public void CargarCompra()
        {
            ControladorAccesorios objCAU = new ControladorAccesorios();
            dtgCompra.ItemsSource = objCAU.AllCompra();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Accesorio ani = new Accesorio();
            ControladorAccesorios cjug = new ControladorAccesorios();
            ani.Id = Int32.Parse(txtId.Text);
            cjug.AgregarCompra(ani);
            CargarCompra();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Accesorio ani = new Accesorio();
            ControladorAccesorios cjug = new ControladorAccesorios();
            ani.Id = Int32.Parse(txtId.Text);
            cjug.EliminarCompra(ani);
            CargarCompra();
        }

    }
}
