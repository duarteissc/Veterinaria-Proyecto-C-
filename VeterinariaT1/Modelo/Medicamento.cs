using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Medicamento
    {
        private int idMedicina;
        private string nombre;
        private int precio;
        private string tipo;
        /*Para encapsular ls atributos es presionar ctrl + punto
         */
        public int Id { get => idMedicina; set => idMedicina = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo
        {
            get => tipo; set => tipo = value;
        }
    }
}
