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
    class ControladorAccesorios
    {
        public List<Modelo.Accesorio> AllAccesorio()
        {
            List<Accesorio> vjs = new List<Accesorio>();
            Accesorio ctemp = null;
            Conexion conn = new Conexion();
            string sqlConsulta = "sp_PRODUCTO";
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ctemp = new Accesorio();
                ctemp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                ctemp.Producto = reader.GetString(reader.GetOrdinal("Producto"));
                ctemp.Precio = reader.GetInt32(reader.GetOrdinal("Precio"));
                ctemp.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));
                ctemp.IdEstatus = reader.GetInt32(reader.GetOrdinal("Estatus"));
                vjs.Add(ctemp);
            }
            conn.CerrarC();
            return vjs;
        }
        public List<Modelo.Accesorio> AllCompra()
        {
            List<Accesorio> vjs = new List<Accesorio>();
            Accesorio ctemp = null;
            Conexion conn = new Conexion();
            string sqlConsulta = "sp_COMPRA";
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ctemp = new Accesorio();
                ctemp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                ctemp.Producto = reader.GetString(reader.GetOrdinal("Producto"));
                vjs.Add(ctemp);
            }
            conn.CerrarC();
            return vjs;
        }
        public void AgregarCompra(Accesorio acce)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_Agregar1";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = acce.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se Agrego Al carrito de compra");
        }
        public void EliminarCompra(Accesorio acce)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_Eliminar1";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = acce.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se Elimino La compra");
        }
    }
}
