using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManicureLand.Services
{
    public class DBAccess
    {
        public static string STRING_CONECTION = "";

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
        

        public void Test()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = ManicureLand;Trusted_Connection=true;");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = @"insert into cliente(id,email,nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento)VALUES(@param1, @param2, @param3, @param4, @param5, @param6)";
            com.Parameters.AddWithValue("@param1", 5);
            com.Parameters.AddWithValue("@param2", "a");
            com.Parameters.AddWithValue("@param3", "a");
            com.Parameters.AddWithValue("@param4", "a");
            com.Parameters.AddWithValue("@param5", "a");
            com.Parameters.AddWithValue("@param6", "19841025");
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}