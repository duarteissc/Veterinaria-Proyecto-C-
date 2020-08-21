using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.Modelo
{
    class Usuario
    {
        private int Idusuario;
        private string name;
        private string clave;
        private string nombre1;
        private int perfil;


        public int IdUsuario { get => Idusuario; set => Idusuario = value; }
        public int Perfil { get => perfil; set => perfil = value; }
        public string username { get => name; set => name = value; }
        public string Nombre { get => nombre1; set => nombre1 = value; }
        public string contraseina { get => clave; set => clave = value; }
    }
}
