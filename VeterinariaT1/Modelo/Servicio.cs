using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Servicio
    {

        private int idServicio;
        private string servicio;
        private string encargado;
        private int precio;
        private int Estatus;
        private string fecha;
        private string sucursal;
        /*Para encapsular ls atributos es presionar ctrl + punto
         */
        public int Id { get => idServicio; set => idServicio = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Servicio1{ get => servicio; set => servicio = value; }
        public string Encargado { get => encargado; set => encargado = value; }
        public string Surcursal { get => sucursal; set => sucursal = value; }
        public int IdEstatus { get => Estatus; set => Estatus = value; }
        public string Fecha{ get => fecha; set => fecha = value; }
    }
}
