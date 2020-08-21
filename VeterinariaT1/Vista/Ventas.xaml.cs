using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VeterinariaT1.Controller;
using VeterinariaT1.Modelo;

namespace VeterinariaT1.Vista
{
    /// <summary>
    /// Lógica de interacción para Ventas.xaml
    /// </summary>
    /// 

    static class Llenar
    {
        public static ObservableCollection<Modelo.Opcion> Mover = new ObservableCollection<Opcion>();
        public static int Id;

    }
        public partial class Ventas : UserControl
    {
        public Ventas()
        {
            InitializeComponent();
            CargarTodo2();
            CargarTabla();


        }
        public void CargarTabla()
        {
            dtgLista.ItemsSource = Llenar.Mover;
        }
        public void CargarTodo2()
        {
            ControladorVentas objCAU = new ControladorVentas();
            Ventas1 obj3 = new Ventas1();
            lblId.Content = objCAU.AllOpcion2(obj3).IdVenta;
            lblFecha.Content = String.Format("{0:G}", DateTime.Now);

        }
        public void ObtenerTotal()
        {
            int total = 0;
            int sum = 0;
            for (int i = 0; i < Llenar.Mover.Count(); i++)
            {
                sum = Llenar.Mover[i].Precio * Llenar.Mover[i].Cantidad;
                total += sum;
            }
            lblTotal.Content = total;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Accesorios2 obj1 = new Accesorios2();
            obj1.Show();
            ObtenerTotal();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Opcion v = new Opcion();
            Opcion a = null;
            if (dtgLista.SelectedItem != null)
            {
               int i= dtgLista.SelectedIndex;
                Llenar.Mover.RemoveAt(i);
                
            }
            ObtenerTotal();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 V = new Window1();
            Ventas1 aut = new Ventas1();
            ControladorVentas cjug = new ControladorVentas();
            aut.Nombre = txtNombre.Text;
            
            cjug.AgregarVenta(aut);
            CargarTodo2();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ObtenerTotal();
        }
    }
}
