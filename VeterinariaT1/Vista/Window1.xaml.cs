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

namespace VeterinariaT1.Vista
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ControllerUC ccu = new ControllerUC();
            ccu.CargarUCGrid(grdUC, new AnimalesUC());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ControllerUC ccu = new ControllerUC();
            ccu.CargarUCGrid(grdUC, new Accesorios());
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            ControllerUC ccu = new ControllerUC();
            ccu.CargarUCGrid(grdUC, new Medicina());
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            ControllerUC ccu = new ControllerUC();
            ccu.CargarUCGrid(grdUC, new Contacto());
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            ControllerUC ccu = new ControllerUC();
            ccu.CargarUCGrid(grdUC, new Tratamientoss());
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {

            ControllerUC ccu = new ControllerUC();
            ccu.CargarUCGrid(grdUC, new Ventas());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            System.Environment.Exit(-1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            this.Close();
            obj.Show();
        }
    }
}
