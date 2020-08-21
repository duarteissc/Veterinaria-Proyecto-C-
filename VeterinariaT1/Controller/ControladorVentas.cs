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
    class ControladorVentas
    {
        public Ventas1 AllOpcion2(Ventas1 us)
        {
            Ventas1 vjs = new Ventas1();
            Conexion conn = new Conexion();
            int a = 0;
            int v = 0;
            string sqlConsulta = "sp_ObtenerId" ;
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();   
            while (reader.Read())
            {
                v = reader.GetInt32(reader.GetOrdinal("IdVenta"));
            }
            vjs.IdVenta = v+1;
            return vjs;
        }



        public int max()
        {
            int n = 0;
            Conexion conn = new Conexion();
            string sqlConsulta = "sp_ObtenerId";
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                n = reader.GetInt32(reader.GetOrdinal("IdVenta"));
            }
            return n;
        }
      


        public void AgregarVenta(Ventas1 v)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_agregarVenta";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Nombre", System.Data.SqlDbType.Int).Value = v.Nombre;
            comando1.ExecuteNonQuery();

            for (int i = 0; i < Vista.Llenar.Mover.Count; i++)
            {

                string sql2 = "sp_agregarDetalleVenta";
                SqlCommand comando2 = new SqlCommand(sql2, conn.AbrirC());
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.Parameters.AddWithValue("@IdVenta", System.Data.SqlDbType.Int).Value = max();
                comando2.Parameters.AddWithValue("@IdAccesorio", System.Data.SqlDbType.Int).Value = Vista.Llenar.Mover[i].Id;
                comando2.Parameters.AddWithValue("@Cantidad", System.Data.SqlDbType.Int).Value = Vista.Llenar.Mover[i].Cantidad;

                comando2.Parameters.AddWithValue("@Precio", System.Data.SqlDbType.Int).Value = Vista.Llenar.Mover[i].Precio;

                comando2.ExecuteNonQuery();
            }

            
            conn.CerrarC();
            MessageBox.Show("Se agrego su Compra :)");
        }
       
    }
}
