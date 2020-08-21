using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Opcion
    {
        private int idAccesorio;
        private string producto;
        private int cantidad;
        private int precio;
        private int estatus;
        public int Estatus { get => estatus; set => estatus = value; }
        public int Id { get => idAccesorio; set => idAccesorio = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
