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
    /// Lógica de interacción para Cantidad.xaml
    /// </summary>
    public partial class Cantidad : Window
    {
        public Cantidad()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Opcion aut = new Opcion();
            ControladorVentas cjug = new ControladorVentas();
            Opcion a = new Opcion();
            a.Id = Accesorios2.Id;
            a.Producto = Accesorios2.Producto;
            a.Precio = Accesorios2.Precio;
            a.Cantidad = int.Parse(Pru.Text);
            //a.Total = int.Parse(Pru.Text) * a.Precio;
                Llenar.Mover.Add(a);
                this.Close();
        }
    }
}
