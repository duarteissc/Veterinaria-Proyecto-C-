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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VeterinariaT1.Controller;
using VeterinariaT1.Modelo;
using VeterinariaT1.Vista;

namespace VeterinariaT1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Usuario obj = new Usuario();
            ControladorUsuario Usuarr = new ControladorUsuario();
                obj.username = txtUserName.Text;
                obj.contraseina = pwtPassword.Password;
            if (Usuarr.autenticarUsuario(obj).Perfil != 0)
            {
                Window1 objMV = new Window1();
                Ventas VEN = new Ventas();
                objMV.Show();
                if (Usuarr.autenticarUsuario(obj).Perfil == 3)
                {
                    objMV.Medicina.Visibility = System.Windows.Visibility.Hidden;
                    objMV.Servicios.Visibility = System.Windows.Visibility.Hidden;
                    objMV.Tratamientos.Visibility = System.Windows.Visibility.Hidden;
                    
                }
                else if (Usuarr.autenticarUsuario(obj).Perfil == 2)
                {
                    objMV.Accesorios.Visibility = System.Windows.Visibility.Hidden;
                    objMV.Animales.Visibility = System.Windows.Visibility.Hidden;
                    objMV.Ventas.Visibility = System.Windows.Visibility.Hidden;
                }
                objMV.lblNombre.Content = Usuarr.autenticarUsuario(obj).Nombre;

                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }
            }


            }
        }
    