using ManicureLand.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManicureLand.Services
{
    public class ServicioService
    {
        public bool ObtenerServicio(int idServicio, out Servicio servicio)
        {
            try
            {
                Servicio servicioEncontrado = new Servicio();
                DBAccess dBAccess = new DBAccess();
                string query = "SELECT descripcion, tiempoEstimado, precio, observacion, codigoColor, estado FROM Servicio WHERE idServicio = " + idServicio.ToString() + "  and estado = 1";
                SqlDataReader reader = dBAccess.BuscarRegistro(query);

                while (reader.Read())
                {
                    servicioEncontrado.IdServicio = idServicio;
                    servicioEncontrado.Descripcion = reader["descripcion"].ToString();
                    servicioEncontrado.TiempoEstimado = int.Parse(reader["tiempoEstimado"].ToString());
                    servicioEncontrado.Precio = int.Parse(reader["precio"].ToString());
                    servicioEncontrado.Observacion = reader["observacion"].ToString();
                    servicioEncontrado.CodigoColor = "#" + reader["codigoColor"].ToString();
                    servicioEncontrado.Estado = bool.Parse(reader["estado"].ToString());                    
                }

                servicio = servicioEncontrado;
                return true;
            }
            catch
            {
                servicio = null;
                return false;
            }

        }

        public bool ModificarServicio(Servicio servicio)
        {

            DBAccess dBAccess = new DBAccess();
            string filtro = "idServicio = " + servicio.IdServicio.ToString();
            List<SqlParameter> listaParametros = new List<SqlParameter>
            {
                new SqlParameter("descripcion", servicio.Descripcion),
                new SqlParameter("tiempoEstimado", servicio.TiempoEstimado),
                new SqlParameter("precio", servicio.Precio),
                new SqlParameter("observacion", servicio.Observacion),                
                new SqlParameter("estado", servicio.Estado),
            };

            listaParametros.Add(new SqlParameter("codigoColor", servicio.CodigoColor.Substring(1, 6)));

            return dBAccess.ModificarDatos("Servicio", listaParametros, filtro);

        }

        public bool ListarServicios(out List<Servicio> listaServicios)
        {

            try
            {
                List<Servicio> listaServiciosEncontrados = new List<Servicio>();

                DBAccess dBAccess = new DBAccess();
                string query = "SELECT idServicio, descripcion, tiempoEstimado, precio, observacion, codigoColor, estado FROM Servicio";
                SqlDataReader reader = dBAccess.BuscarRegistro(query);

                while (reader.Read())
                {
                    Servicio servicio = new Servicio();
                    servicio.IdServicio = int.Parse(reader["idServicio"].ToString());
                    servicio.Descripcion = reader["descripcion"].ToString();
                    servicio.TiempoEstimado = int.Parse(reader["tiempoEstimado"].ToString());
                    servicio.Precio = int.Parse(reader["precio"].ToString());
                    servicio.Observacion = reader["observacion"].ToString();
                    servicio.CodigoColor = "#" + reader["codigoColor"].ToString();
                    servicio.Estado = bool.Parse(reader["estado"].ToString());
                    listaServiciosEncontrados.Add(servicio);
                }
                listaServicios = listaServiciosEncontrados;
                return true;
            }
            catch
            {
                listaServicios = null;
                return false;
            }

        }


        public Boolean RegistrarServicio(Servicio servicio)
        {
            DBAccess dBAccess = new DBAccess();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("descripcion", servicio.Descripcion),
                new SqlParameter("tiempoEstimado", servicio.TiempoEstimado),
                new SqlParameter("precio", servicio.Precio),
                new SqlParameter("observacion", servicio.Observacion),                
                new SqlParameter("estado", (bool)true)
            };

            parametros.Add(new SqlParameter("codigoColor", servicio.CodigoColor.Substring(1, 6)));

            if (dBAccess.InsertarDatos("Servicio", parametros))
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