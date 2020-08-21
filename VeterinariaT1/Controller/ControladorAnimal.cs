using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VeterinariaT1.BD;
using VeterinariaT1.Modelo;

namespace VeterinariaT1.Controller
{
    class ControladorAnimal
    {
        public List<Modelo.Animal> AllAutoUsados()
        {
            List<Animal> vjs = new List<Animal>();
            Animal ctemp = null;
            Conexion conn = new Conexion();
            string sqlConsulta = "Eliminar";
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ctemp = new Animal();
                ctemp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                ctemp.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                ctemp.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                ctemp.Precio = reader.GetInt32(reader.GetOrdinal("Precio"));
                ctemp.IdEstatus = reader.GetInt32(reader.GetOrdinal("Estatus"));
                vjs.Add(ctemp);
            }
            conn.CerrarC();
            return vjs;
        }
        public void AgregarAnimal(Animal ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_agregar";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@precio", System.Data.SqlDbType.Float).Value = ani.Precio;
            comando1.Parameters.AddWithValue("@tipo", System.Data.SqlDbType.VarChar).Value = ani.Tipo;
            comando1.Parameters.AddWithValue("@nombre", System.Data.SqlDbType.VarChar).Value = ani.Nombre;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se agrego nuevo usuario");
        }
        public void ModificarAnimal(Animal ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_ModificarAnimal";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Precio", System.Data.SqlDbType.Float).Value = ani.Precio;
            comando1.Parameters.AddWithValue("@Tipo", System.Data.SqlDbType.VarChar).Value = ani.Tipo;
            comando1.Parameters.AddWithValue("@Nombre", System.Data.SqlDbType.VarChar).Value = ani.Nombre;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = ani.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se modifico el animal");
        }

        public void EliminarAnimal(Animal ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_Eliminar";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = ani.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se elimino el animal");
        }
    }
}
