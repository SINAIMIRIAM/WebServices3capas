using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public class DatRol
    {
        public DataTable Mostrar()
        {
            string Conexion = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            string query = string.Format("select * from Roles");
            SqlConnection con = new SqlConnection(Conexion);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        public DataRow Detalles(int Id)
        {
            string Conexion = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            string query = string.Format("select * from Roles where IdRol={0}", Id);
            SqlConnection con = new SqlConnection(Conexion);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0];


        }



        public int Agregar(string Rol, bool Active)
        {
            int Filas = 0;
            string Conexion = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            string query = string.Format("insert into Roles values ('{0}',{1})", Rol, Convert.ToInt32(Active));
            SqlConnection con = new SqlConnection(Conexion);
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            Filas = com.ExecuteNonQuery();
            con.Close();
            return Filas;


        }

        public int Eliminar(int IdRol)
        {
            int Filas = 0;
            string Conexion = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            string query = string.Format("Delete  From Roles where IdRol={0}", IdRol);
            SqlConnection con = new SqlConnection(Conexion);
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            Filas = com.ExecuteNonQuery();
            con.Close();
            return Filas;


        }

        public int Actualizar(string Rol, bool Active, int IdRol)
        {
            int Filas = 0;
            string Conexion = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            string query = string.Format("Update Roles set Rol='{0}',Active={1} where IdRol={2}", Rol,Convert.ToInt32(Active), IdRol);
            SqlConnection con = new SqlConnection(Conexion);
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            Filas = com.ExecuteNonQuery();
            con.Close();
            return Filas;


        }
    }
}
