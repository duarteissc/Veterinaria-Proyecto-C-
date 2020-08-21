using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Categoria
    {
        private int idCategoria;
        private string tipo;
        /*Para encapsular ls atributos es presionar ctrl + punto
         */

        public int Id { get => idCategoria; set => idCategoria = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
