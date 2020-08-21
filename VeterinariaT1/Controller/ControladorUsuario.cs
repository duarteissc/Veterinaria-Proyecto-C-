using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaT1.BD;
using VeterinariaT1.Modelo;

namespace VeterinariaT1.Controller
{
    class ControladorUsuario
    {
        public Usuario autenticarUsuario(Usuario us)
        {
            Usuario X = new Usuario();
            Conexion conn = new Conexion();
            string sqlCadena = "sp_autenticar"; //nombre del procedimiento almacenado
            SqlCommand comando = new SqlCommand(sqlCadena, conn.AbrirC());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@username", System.Data.SqlDbType.VarChar).Value = us.username;
            comando.Parameters.AddWithValue("@contrasenia", System.Data.SqlDbType.VarChar).Value = us.contraseina;
            //ejecutar el procedimiento almacenado
            comando.ExecuteNonQuery(); //devolver los registros que encontro //ejecuta en BD
            SqlDataReader reader = comando.ExecuteReader(); //almacena los registros //LOCALIZADO Y TRAIGA EL REGISTRO
            while (reader.Read())
            {
                X.Perfil= reader.GetInt32(reader.GetOrdinal("perfil"));
                X.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                X.IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"));

            }

            return X;
        }
    }
}
