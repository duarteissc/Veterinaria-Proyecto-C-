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
    /// Lógica de interacción para Medicina.xaml
    /// </summary>
    public partial class Medicina : UserControl
    {
        public Medicina()
        {
            InitializeComponent();
            CargarControlada();
            CargarLinea();
            CargarTipo();
        }
        public void CargarTipo()
        {
            string[] Categoria = { "Medicina Controlada", "Medicina Linea" };
            cmbTipo.ItemsSource = Categoria;
        }
        public void CargarControlada()
        {
            ControladorMedicina objCAU = new ControladorMedicina();
            dtgLista.ItemsSource = objCAU.AllControlada();
        }
        public void CargarLinea()
        {
            ControladorMedicina objCAU = new ControladorMedicina();
            dtgLista_Copy.ItemsSource = objCAU.AllLinea();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Medicamento aut = new Medicamento();
            ControladorMedicina cjug = new ControladorMedicina();
            aut.Nombre = txtNombre.Text;
            aut.Precio = Int32.Parse(txtPrecio.Text);
            aut.Tipo = cmbTipo.Text;
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.AgregarMedicamento(aut);
            CargarControlada();
            CargarLinea();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Medicamento ani = new Medicamento();
            ControladorMedicina cjug = new ControladorMedicina();
            ani.Nombre = txtNombre.Text;
            ani.Precio = Int32.Parse(txtPrecio.Text);
            ani.Tipo = cmbTipo.Text;
            ani.Id = Int32.Parse(txtId.Text);
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.ModificarMedicamento(ani);
            CargarControlada();
            CargarLinea();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            Medicamento ani = new Medicamento();
            ControladorMedicina cjug = new ControladorMedicina();
            ani.Id = Int32.Parse(txtId.Text);
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.EliminarMedicamento(ani);
            CargarControlada();
            CargarLinea();
        }
        private void dtgLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Medicamento a = null;
            if (dtgLista.SelectedItem != null)
            {
                a = (Medicamento)dtgLista.SelectedItem;
                txtId.Text = a.Id.ToString();
                txtPrecio.Text = a.Precio.ToString();
                txtNombre.Text = a.Nombre;
                cmbTipo.SelectedItem = a.Tipo;
            }
        }

    }
}
