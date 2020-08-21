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
    /// Lógica de interacción para Accesorios2.xaml
    /// </summary>
    public partial class Accesorios2 : Window

    {

        public static int Id;
        public static string Producto;
        public static int Precio;
        public static int Cantidad;
        public Accesorios2()
        {
            InitializeComponent();
            CargarAccesorios();

        }
        public void CargarAccesorios()
        {
            ControladorAccesorios objCAU = new ControladorAccesorios();
            dtgLista.ItemsSource = objCAU.AllAccesorio();
        }

        private void dtgLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Accesorio a = null;
            Cantidad obj1 = new Cantidad();
            if (dtgLista.SelectedItem != null)
            {
                a = (Accesorio)dtgLista.SelectedItem;
                Id = a.Id;
                Producto=a.Producto;
                Precio = a.Precio;

                obj1.Show();
                this.Close();

            }
        }
    }
    
    }
    

