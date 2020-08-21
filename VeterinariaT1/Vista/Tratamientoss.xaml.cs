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

namespace VeterinariaT1.Vista
{
    /// <summary>
    /// Lógica de interacción para Tratamientoss.xaml
    /// </summary>
    public partial class Tratamientoss : UserControl
    {
        public Tratamientoss()
        {
            InitializeComponent();
            CargarTipo();
            CargarTelefono();
            CargarTratamiento();
            CargarTratamientos();
            CargarTamaño();
            CargarSucursal();
        }
        public void CargarTipo()
        {
            string[] Categoria = { "Pedigri", "Corriente", "Normal" };
            cmbTipo.ItemsSource = Categoria;
        }
        public void CargarTelefono()
        {
            string[] Categoria = { "4531382552", "477839283", "5347777" };
            cmbTelefono.ItemsSource = Categoria;
        }
        public void CargarTratamiento()
        {
            string[] Categoria = { "Corte de Pelo", "Manicura Camina", "Lavado de Orejas", "Vacunación" };
            cmbTramiento.ItemsSource = Categoria;
        }
        public void CargarTamaño()
        {
            string[] Categoria = { "Grende", "Mediano", "Chiquito", "Miniatura" };
            cmbTamaño.ItemsSource = Categoria;
        }
        public void CargarSucursal()
        {
            string[] Categoria = { "Movil", "San Jeronimo", "Maravillas", "Del Bajio" };
            cmbSucursal.ItemsSource = Categoria;
        }
        public void CargarTratamientos()
        {
            ControladorTratamiento objCAU = new ControladorTratamiento();
            dtgLista_Copy.ItemsSource = objCAU.AllTramientos();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tratamientos aut = new Tratamientos();
            ControladorTratamiento cjug = new ControladorTratamiento();
            aut.Telefonos = cmbTelefono.Text;
            aut.Tratamiento = cmbTramiento.Text;
            aut.Precio = Int32.Parse(txtPrecio.Text);
            aut.Tipo = cmbTipo.Text;
            aut.Tamaño = cmbTamaño.Text;
            aut.Sucursal = cmbSucursal.Text;
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.AgregarTratamientos(aut);
            CargarTratamientos();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Tratamientos ani = new Tratamientos();
            ControladorTratamiento cjug = new ControladorTratamiento();
            ani.Telefonos = cmbTelefono.Text;
            ani.Tratamiento = cmbTramiento.Text;
            ani.Tipo = cmbTipo.Text;
            ani.Tamaño = cmbTamaño.Text;
            ani.Sucursal = cmbSucursal.Text;
            ani.Precio = Int32.Parse(txtPrecio.Text);    
            ani.Id = Int32.Parse(txtId.Text);
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.ModificarTratamientos(ani);
            CargarTratamientos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Tratamientos ani = new Tratamientos();
            ControladorTratamiento cjug = new ControladorTratamiento();
            ani.Id = Int32.Parse(txtId.Text);
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.EliminarTratamientos(ani);
            CargarTratamientos();
        }
        private void dtgLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tratamientos a = null;
            if (dtgLista_Copy.SelectedItem != null)
            {
                a = (Tratamientos)dtgLista_Copy.SelectedItem;
                txtId.Text = a.Id.ToString();
                txtPrecio.Text = a.Precio.ToString();
                cmbSucursal.Text = a.Sucursal;
                cmbTamaño.Text = a.Tamaño;
                cmbTelefono.Text = a.Telefonos;
                cmbTipo.SelectedItem = a.Tipo;
                cmbTramiento.Text = a.Tratamiento;
            }
        }
    }
}
