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
    class ControladorTratamiento
    {
        public List<Modelo.Tratamientos> AllTramientos()
        {
            List<Tratamientos> vjs = new List<Tratamientos>();
            Tratamientos ctemp = null;
            Conexion conn = new Conexion();
            string sqlConsulta = "sp_Tratamientos";
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ctemp = new Tratamientos();
                ctemp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                ctemp.Tratamiento = reader.GetString(reader.GetOrdinal("Tratamiento"));
                ctemp.Telefonos = reader.GetString(reader.GetOrdinal("Sucursal"));
                ctemp.Tamaño = reader.GetString(reader.GetOrdinal("Tamaño"));
                ctemp.Precio = reader.GetInt32(reader.GetOrdinal("Precio"));
                ctemp.Sucursal = reader.GetString(reader.GetOrdinal("Sucursal"));
                ctemp.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                ctemp.IdEstatus = reader.GetInt32(reader.GetOrdinal("Estatus"));
                vjs.Add(ctemp);
            }
            conn.CerrarC();
            return vjs;
        }
        public void AgregarTratamientos(Tratamientos ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_AgregarTratamientos";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Precio", System.Data.SqlDbType.Float).Value = ani.Precio;
            comando1.Parameters.AddWithValue("@Sucursal", System.Data.SqlDbType.VarChar).Value = ani.Sucursal;
            comando1.Parameters.AddWithValue("@Tratamientos", System.Data.SqlDbType.VarChar).Value = ani.Tratamiento;
            comando1.Parameters.AddWithValue("@Telefono", System.Data.SqlDbType.VarChar).Value = ani.Telefonos;
            comando1.Parameters.AddWithValue("@Tamaño", System.Data.SqlDbType.VarChar).Value = ani.Tamaño;
            comando1.Parameters.AddWithValue("@Tipo", System.Data.SqlDbType.VarChar).Value = ani.Tipo;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se agrego nuevo Servicio");

        }
        public void ModificarTratamientos(Tratamientos ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_ModificarTratamientos";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Precio", System.Data.SqlDbType.Float).Value = ani.Precio;
            comando1.Parameters.AddWithValue("@Sucursal", System.Data.SqlDbType.VarChar).Value = ani.Sucursal;
            comando1.Parameters.AddWithValue("@Tratamientos", System.Data.SqlDbType.VarChar).Value = ani.Tratamiento;
            comando1.Parameters.AddWithValue("@Telefono", System.Data.SqlDbType.VarChar).Value = ani.Telefonos;
            comando1.Parameters.AddWithValue("@Tamaño", System.Data.SqlDbType.VarChar).Value = ani.Tamaño;
            comando1.Parameters.AddWithValue("@Tipo", System.Data.SqlDbType.VarChar).Value = ani.Tipo;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = ani.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se modifico el Tratamiento");
        }
        public void EliminarTratamientos(Tratamientos ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_EliminarTratamientos";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = ani.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se elimino el Tratamientos");
        }
    }
}
