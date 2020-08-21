using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Ventas1
    {
        private string nombre;
        private int idventa;
        private string producto;
        private int idaccesorio;
        private int precio;
        private int cantidad;
        private DateTime fecha;
        private int idusuario;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Accesorio { get => idaccesorio; set => idaccesorio = value; }
        public int IdVenta { get => idventa; set => idventa = value; }
        public int IdUsuario{ get => idusuario; set => idusuario = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Producto { get => producto; set => producto= value; }
        public string Nombre { get => nombre; set => nombre = value; }


    }
}
