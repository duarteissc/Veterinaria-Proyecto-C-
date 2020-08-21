using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Accesorio
    {
        private int idAccesorio;
        private string producto;
        private string descripcion;
        private int precio;
        private int Estatus;
        /*Para encapsular ls atributos es presionar ctrl + punto
         */
        public int Id { get => idAccesorio; set => idAccesorio = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdEstatus { get => Estatus; set => Estatus = value; }
    }
}
