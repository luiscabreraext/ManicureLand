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
        private static string STRING_CONECTION = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = ManicureLand;Trusted_Connection=true;";
        private SqlConnection conexion;

        public DBAccess()
        {
            conexion = new SqlConnection(STRING_CONECTION);
        }

        public bool InsertarDatos(string tabla, List<SqlParameter> parametros)
        {
            try
            {
                if (parametros.Count < 1 || tabla.Length < 1)
                {
                    return false;
                }
                SqlCommand command = new SqlCommand();
                bool respuesta = false;
                int numDatos;
                string query = "";
                string paramX = "";
                string param = "";

                conexion.Open();
                command.Connection = conexion;

                query = "INSERT INTO " + tabla + "(";
                for (int i = 0; i < parametros.Count; i++)
                {
                    query = query + parametros[i].ParameterName;
                    param = "@param" + (i + 1);
                    paramX = paramX + param;
                    if (i < parametros.Count - 1)
                    {
                        query = query + ", ";
                        paramX = paramX + ", ";
                    }
                    else
                    {
                        query = query + ") VALUES(" + paramX + ")";
                    }
                    command.Parameters.AddWithValue(param, parametros[i].Value);
                }

                command.CommandType = CommandType.Text;
                command.CommandText = query;
                numDatos = command.ExecuteNonQuery();
                if (numDatos > 0)
                {
                    respuesta = true;
                }
                else
                {
                    respuesta = false;
                }
                conexion.Close();
                return respuesta;                
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        /*public void Test()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog = ManicureLand;Trusted_Connection=true;");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = @"insert into cliente(email,nombres,apellidoPaterno,apellidoMaterno,fechaNacimiento)VALUES(@param1, @param2, @param3, @param4, @param5)";
            com.Parameters.AddWithValue("@param1", "a");
            com.Parameters.AddWithValue("@param2", "a");
            com.Parameters.AddWithValue("@param3", "a");
            com.Parameters.AddWithValue("@param4", "a");
            com.Parameters.AddWithValue("@param5", "19841025");
            com.ExecuteNonQuery();
            con.Close();
        }*/
    }
}