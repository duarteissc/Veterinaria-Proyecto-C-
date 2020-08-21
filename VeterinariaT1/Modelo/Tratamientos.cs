using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Tratamientos
    {
        private int idServicio;
        private string servicio;
        private string encargado;
        private int precio;
        private int Estatus;
        private string sucursal;
        private string tipo;
        /*Para encapsular ls atributos es presionar ctrl + punto
         */
        public int Id { get => idServicio; set => idServicio = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Tratamiento { get => servicio; set => servicio = value; }
        public string Tamaño { get => servicio; set => servicio = value; }
        public string Telefonos { get => sucursal; set => sucursal = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int IdEstatus { get => Estatus; set => Estatus = value; }
        public string Sucursal { get => sucursal; set => sucursal = value; }
    }
}
