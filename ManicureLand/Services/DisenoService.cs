using ManicureLand.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManicureLand.Services
{
    public class DisenoService
    {
        public bool ObtenerDiseno(int idDiseno, out Diseno diseno)
        {
            try
            {
                Diseno disenoEncontrado = new Diseno();
                DBAccess dBAccess = new DBAccess();
                string query = "SELECT descripcion, tiempoEstimado, precio, observacion, urlDiseno, estado FROM Diseno WHERE idDiseno = " + idDiseno.ToString() + "  and estado = 1";
                SqlDataReader reader = dBAccess.BuscarRegistro(query);

                while (reader.Read())
                {
                    disenoEncontrado.IdDiseno = idDiseno;
                    disenoEncontrado.Descripcion = reader["descripcion"].ToString();
                    disenoEncontrado.TiempoEstimado = int.Parse(reader["tiempoEstimado"].ToString());
                    disenoEncontrado.Precio = int.Parse(reader["precio"].ToString());
                    disenoEncontrado.Observacion = reader["observacion"].ToString();
                    disenoEncontrado.UrlDiseno = reader["urlDiseno"].ToString();
                    disenoEncontrado.Estado = bool.Parse(reader["estado"].ToString());
                }

                diseno = disenoEncontrado;
                return true;
            }
            catch
            {
                diseno = null;
                return false;
            }

        }

        public bool ModificarDiseno(Diseno diseno)
        {

            DBAccess dBAccess = new DBAccess();
            string filtro = "idDiseno = " + diseno.IdDiseno.ToString();
            List<SqlParameter> listaParametros = new List<SqlParameter>
            {
                new SqlParameter("descripcion", diseno.Descripcion),
                new SqlParameter("tiempoEstimado", diseno.TiempoEstimado),
                new SqlParameter("precio", diseno.Precio),
                new SqlParameter("observacion", diseno.Observacion),
                new SqlParameter("urlDiseno", diseno.UrlDiseno),
                new SqlParameter("estado", diseno.Estado),
            };            

            return dBAccess.ModificarDatos("Diseno", listaParametros, filtro);

        }

        public bool ListarDisenos(out List<Diseno> listaDisenos)
        {

            try
            {
                List<Diseno> listaDisenosEncontrados = new List<Diseno>();

                DBAccess dBAccess = new DBAccess();
                string query = "SELECT idDiseno, descripcion, tiempoEstimado, precio, observacion, urlDiseno, estado FROM Diseno";
                SqlDataReader reader = dBAccess.BuscarRegistro(query);

                while (reader.Read())
                {
                    Diseno diseno = new Diseno();
                    diseno.IdDiseno = int.Parse(reader["idDiseno"].ToString());
                    diseno.Descripcion = reader["descripcion"].ToString();
                    diseno.TiempoEstimado = int.Parse(reader["tiempoEstimado"].ToString());
                    diseno.Precio = int.Parse(reader["precio"].ToString());
                    diseno.Observacion = reader["observacion"].ToString();
                    diseno.UrlDiseno = reader["urlDiseno"].ToString();
                    diseno.Estado = bool.Parse(reader["estado"].ToString());
                    listaDisenosEncontrados.Add(diseno);
                }
                listaDisenos = listaDisenosEncontrados;
                return true;
            }
            catch
            {
                listaDisenos = null;
                return false;
            }

        }


        public Boolean RegistrarDiseno(Diseno diseno)
        {
            DBAccess dBAccess = new DBAccess();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("descripcion", diseno.Descripcion),
                new SqlParameter("tiempoEstimado", diseno.TiempoEstimado),
                new SqlParameter("precio", diseno.Precio),
                new SqlParameter("observacion", diseno.Observacion),
                new SqlParameter("urlDiseno", diseno.UrlDiseno),
                new SqlParameter("estado", (bool)true)
            };        

            if (dBAccess.InsertarDatos("Diseno", parametros))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}