using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaT1.BD
{
    class Conexion
    {
        SqlConnection conexion = null;
        public SqlConnection AbrirC()
        {
            string cadena = "server=DESKTOP-0M62I3N; database=veterinaria; integrated security=YES";

            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
        public void CerrarC()
        {
            if (conexion != null)
                conexion.Close();
        }
    }
}
