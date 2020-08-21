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
    class ControladorMedicina
    {
        public List<Modelo.Medicamento> AllControlada()
        {
            List<Medicamento> vjs = new List<Medicamento>();
            Medicamento ctemp = null;
            Conexion conn = new Conexion();
            string sqlConsulta = "sp_Controlada";
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ctemp = new Medicamento();
                ctemp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                ctemp.Nombre = reader.GetString(reader.GetOrdinal("Producto"));
                ctemp.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                ctemp.Precio = reader.GetInt32(reader.GetOrdinal("Precio"));
                vjs.Add(ctemp);
            }
            conn.CerrarC();
            return vjs;
        }
        public List<Modelo.Medicamento> AllLinea()
        {
            List<Medicamento> vjs = new List<Medicamento>();
            Medicamento ctemp = null;
            Conexion conn = new Conexion();
            string sqlConsulta = "sp_Linea";
            SqlCommand comando = new SqlCommand(sqlConsulta, conn.AbrirC());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ctemp = new Medicamento();
                ctemp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                ctemp.Nombre = reader.GetString(reader.GetOrdinal("Producto"));
                ctemp.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                ctemp.Precio = reader.GetInt32(reader.GetOrdinal("Precio"));
                vjs.Add(ctemp);
            }
            conn.CerrarC();
            return vjs;
        }
        public void AgregarMedicamento(Medicamento ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_AgregarMedicamento";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Precio", System.Data.SqlDbType.Float).Value = ani.Precio;
            comando1.Parameters.AddWithValue("@Tipo", System.Data.SqlDbType.VarChar).Value = ani.Tipo;
            comando1.Parameters.AddWithValue("@Producto", System.Data.SqlDbType.VarChar).Value = ani.Nombre;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se agrego nuevo producto");
        }
        public void ModificarMedicamento(Medicamento ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_ModificarMedicamento";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Precio", System.Data.SqlDbType.Float).Value = ani.Precio;
            comando1.Parameters.AddWithValue("@Tipo", System.Data.SqlDbType.VarChar).Value = ani.Tipo;
            comando1.Parameters.AddWithValue("@Producto", System.Data.SqlDbType.VarChar).Value = ani.Nombre;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = ani.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se modifico el producto");
        }
        public void EliminarMedicamento(Medicamento ani)
        {
            SqlDataReader reader = null;
            Conexion conn = new Conexion();
            string sql1 = "sp_EliminarMedicamento";
            SqlCommand comando1 = new SqlCommand(sql1, conn.AbrirC());
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@IdVal", System.Data.SqlDbType.Int).Value = ani.Id;
            comando1.ExecuteNonQuery();
            conn.CerrarC();
            MessageBox.Show("Se elimino el producto");
        }
    }
}
