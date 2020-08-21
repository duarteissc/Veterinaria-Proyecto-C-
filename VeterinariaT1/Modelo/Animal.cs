using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Animal
    {

        private int idAnimal;
        private string nombre;
        private int precio;
        private string tipo;
        private int Estatus;
        /*Para encapsular ls atributos es presionar ctrl + punto
         */
        public int IdEstatus { get => Estatus; set => Estatus = value; }
        public int Id { get => idAnimal; set => idAnimal = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo
        {
            get => tipo; set => tipo = value;
        }
    }
}

