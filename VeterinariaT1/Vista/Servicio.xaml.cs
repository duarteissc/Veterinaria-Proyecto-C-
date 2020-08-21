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
    /// Lógica de interacción para Contacto.xaml
    /// </summary>
    public partial class Contacto : UserControl
    {
        public Contacto()
        {
            InitializeComponent();
            CargarTipo();
            CargarServicios();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Servicio aut = new Servicio();
            ControladorServicios cjug = new ControladorServicios();
            aut.Encargado = txtEncargado.Text;
            aut.Servicio1 = txtServicio.Text;
            aut.Precio = Int32.Parse(txtPrecio.Text);
            aut.Fecha = txtFecha.Text;
            aut.Surcursal = cmbSucursal.Text;
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.AgregarServicios(aut);
            CargarServicios();
        }
        public void CargarTipo()
        {
            string[] Categoria = { "Maravillas", "La Salle Bajio", "Movil", "San Jeronimo" };
            cmbSucursal.ItemsSource = Categoria;
        }
        public void CargarServicios()
        {
            ControladorServicios objCAU = new ControladorServicios();
            dtgLista_Copy.ItemsSource = objCAU.AllServicios();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Servicio ani = new Servicio();
            ControladorServicios cjug = new ControladorServicios();
            ani.Encargado = txtEncargado.Text;
            ani.Servicio1 = txtServicio.Text;
            ani.Precio = Int32.Parse(txtPrecio.Text);
            ani.Fecha = txtFecha.Text;
            ani.Surcursal = cmbSucursal.Text;
            ani.Id = Int32.Parse(txtId.Text);
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.ModificarServicios(ani);
            CargarServicios();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            Servicio ani = new Servicio();
            ControladorServicios cjug = new ControladorServicios();
            ani.Id = Int32.Parse(txtId.Text);
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.EliminarServicios(ani);
            CargarServicios();
        }
        private void dtgLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Servicio a = null;
            if (dtgLista_Copy.SelectedItem != null)
            {
                a = (Servicio)dtgLista_Copy.SelectedItem;
                txtId.Text = a.Id.ToString();
                txtPrecio.Text = a.Precio.ToString();
                txtServicio.Text = a.Servicio1;
                txtFecha.Text = a.Fecha;
                txtEncargado.Text = a.Encargado;
                cmbSucursal.SelectedItem = a.Surcursal;
            }
        }
    }
}
