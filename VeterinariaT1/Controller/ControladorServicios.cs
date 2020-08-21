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
    class ControladorServicios
    {
        public List<Modelo.Servicio> AllServicios()
        {
            List<Servicio> vjs = new List<Servicio>();
            Servicio ctemp = null;
            Conexion conn = new Conexion();
            string sqlConsulta = "sp_Servicios";
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ctemp = new Servicio();
                ctemp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                ctemp.Servicio1 = reader.GetString(reader.GetOrdinal("Servicio"));
                ctemp.Surcursal = reader.GetString(reader.GetOrdinal("Sucursal"));
                ctemp.Encargado = reader.GetString(reader.GetOrdinal("Encargado"));
                ctemp.Precio = reader.GetInt32(reader.GetOrdinal("Precio"));
                ctemp.Fecha = reader.GetString(reader.GetOrdinal("Fecha"));
                ctemp.IdEstatus = reader.GetInt32(reader.GetOrdinal("Estatus"));
                vjs.Add(ctemp);
            }
            conn.CerrarC();
            return vjs;
        }
        public void AgregarServicios(Servicio ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_AgregarServicios";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Precio", System.Data.SqlDbType.Float).Value = ani.Precio;
            comando1.Parameters.AddWithValue("@Sucursal", System.Data.SqlDbType.VarChar).Value = ani.Surcursal;
            comando1.Parameters.AddWithValue("@Servicio", System.Data.SqlDbType.VarChar).Value = ani.Servicio1;
            comando1.Parameters.AddWithValue("@Fecha", System.Data.SqlDbType.VarChar).Value = ani.Fecha;
            comando1.Parameters.AddWithValue("@Encargado", System.Data.SqlDbType.VarChar).Value = ani.Encargado;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se agrego nuevo Servicio");

        }
        public void ModificarServicios(Servicio ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_ModificarServicios";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Precio", System.Data.SqlDbType.Float).Value = ani.Precio;
            comando1.Parameters.AddWithValue("@Sucursal", System.Data.SqlDbType.VarChar).Value = ani.Surcursal;
            comando1.Parameters.AddWithValue("@Servicio", System.Data.SqlDbType.VarChar).Value = ani.Servicio1;
            comando1.Parameters.AddWithValue("@Fecha", System.Data.SqlDbType.VarChar).Value = ani.Fecha;
            comando1.Parameters.AddWithValue("@Encargado", System.Data.SqlDbType.VarChar).Value = ani.Encargado;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = ani.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se modifico el Servicio");
        }
        public void EliminarServicios(Servicio ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_EliminarServicios";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = ani.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se elimino el Servicio");
        }
    }
}
