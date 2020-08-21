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
    /// Lógica de interacción para AnimalesUC.xaml
    /// </summary>
    public partial class AnimalesUC : UserControl
    {
        public AnimalesUC()
        {
            InitializeComponent();
            CargarTipo();
            CargarAnimales();
        }
        public void CargarTipo()
        {
            string[] Categoria = { "Felino", "Canino", "Roedor", "Ave" };
            cmbTipo.ItemsSource = Categoria;
        }
        public void CargarAnimales()
        {
            ControladorAnimal objCAU = new ControladorAnimal();
            dtgLista.ItemsSource = objCAU.AllAutoUsados();
        }
        //agregar animales
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Animal aut = new Animal();
            ControladorAnimal cjug = new ControladorAnimal();
            aut.Nombre = txtNombre.Text;
            aut.Precio = Int32.Parse(txtPrecio.Text);
            aut.Tipo = cmbTipo.Text;
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.AgregarAnimal(aut);
            CargarAnimales();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CargarAnimales();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Animal ani = new Animal();
            ControladorAnimal cjug = new ControladorAnimal();
            ani.Nombre = txtNombre.Text;
            ani.Precio = Int32.Parse(txtPrecio.Text);
            ani.Tipo = cmbTipo.Text;
            ani.Id = Int32.Parse(txtId.Text);
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.ModificarAnimal(ani);
            CargarAnimales();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            Animal ani = new Animal();
            ControladorAnimal cjug = new ControladorAnimal();
            ani.Id = Int32.Parse(txtId.Text);
            //jug.IdJuguete = int.Parse(txtCodigo.Text);
            cjug.EliminarAnimal(ani);
            CargarAnimales();
        }

        private void dtgLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Animal a = null;
            if(dtgLista.SelectedItem != null)
            {
                a = (Animal)dtgLista.SelectedItem;
                txtId.Text = a.Id.ToString();
                txtPrecio.Text = a.Precio.ToString();
                txtNombre.Text = a.Nombre;
                cmbTipo.SelectedItem = a.Tipo;
            }
        }
    }
}
