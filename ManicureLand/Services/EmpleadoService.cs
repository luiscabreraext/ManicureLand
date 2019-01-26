using ManicureLand.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ManicureLand.Services
{
    public class EmpleadoService
    {
        public bool ObtenerEmpleado(int idEmpleado, out Empleado empleado)
        {
            try
            {
                Empleado empleadoEncontrado = new Empleado();
                DBAccess dBAccess = new DBAccess();
                string query = "SELECT nombres, apellidoPaterno, apellidoMaterno, rut, fechaNacimiento, correo, telefono, fechaRegistro, perfil, estado FROM Empleado WHERE idEmpleado = " + idEmpleado.ToString() + "  and estado = 1";
                SqlDataReader reader = dBAccess.BuscarRegistro(query);

                while (reader.Read())
                {
                    empleadoEncontrado.IdEmpleado = idEmpleado;
                    empleadoEncontrado.Nombres = reader["nombres"].ToString();
                    empleadoEncontrado.ApellidoPaterno = reader["apellidoPaterno"].ToString();
                    empleadoEncontrado.ApellidoMaterno = reader["apellidoMaterno"].ToString();
                    empleadoEncontrado.Rut = reader["rut"].ToString();
                    empleadoEncontrado.Correo = reader["correo"].ToString();
                    empleadoEncontrado.FechaNacimiento = DateTime.Parse(reader["fechaNacimiento"].ToString());
                    empleadoEncontrado.FechaRegistro = DateTime.Parse(reader["fechaRegistro"].ToString());
                    empleadoEncontrado.Telefono = reader["telefono"].ToString();
                    empleadoEncontrado.Perfil = int.Parse(reader["perfil"].ToString());
                    empleadoEncontrado.Estado = bool.Parse(reader["estado"].ToString());
                }

                empleado = empleadoEncontrado;
                return true;
            }
            catch
            {
                empleado = null;
                return false;
            }

        }

        public bool ObtenerEmpleado(string correo, out Empleado empleado)
        {
            try
            {
                Empleado empleadoEncontrado = new Empleado();
                DBAccess dBAccess = new DBAccess();
                string query = "SELECT idEmpleado, nombres, apellidoPaterno, apellidoMaterno, rut, fechaNacimiento, telefono, fechaRegistro, perfil, estado FROM Empleado WHERE correo = '" + correo + "' and estado = 1";
                SqlDataReader reader = dBAccess.BuscarRegistro(query);

                while (reader.Read())
                {
                    empleadoEncontrado.Correo = correo;
                    empleadoEncontrado.IdEmpleado = int.Parse(reader["idEmpleado"].ToString());
                    empleadoEncontrado.Nombres = reader["nombres"].ToString();
                    empleadoEncontrado.ApellidoPaterno = reader["apellidoPaterno"].ToString();
                    empleadoEncontrado.ApellidoMaterno = reader["apellidoMaterno"].ToString();
                    empleadoEncontrado.Rut = reader["rut"].ToString();
                    empleadoEncontrado.FechaNacimiento = DateTime.Parse(reader["fechaNacimiento"].ToString());
                    empleadoEncontrado.FechaRegistro = DateTime.Parse(reader["fechaRegistro"].ToString());
                    empleadoEncontrado.Telefono = reader["telefono"].ToString();
                    empleadoEncontrado.Perfil = int.Parse(reader["perfil"].ToString());
                }

                empleado = empleadoEncontrado;
                return true;
            }
            catch
            {
                empleado = null;
                return false;
            }

        }

        public bool ModificarEmpleado(Empleado empleado)
        {
            if (empleado.ApellidoMaterno == null)
            {
                empleado.ApellidoMaterno = "";
            }

            if (empleado.Telefono == null)
            {
                empleado.Telefono = "";
            }

            if (empleado.Rut == null)
            {
                empleado.Rut = "";
            }

            DBAccess dBAccess = new DBAccess();
            string filtro = "idEmpleado = " + empleado.IdEmpleado.ToString();
            List<SqlParameter> listaParametros = new List<SqlParameter>
            {
                new SqlParameter("nombres", empleado.Nombres),
                new SqlParameter("apellidoPaterno", empleado.ApellidoPaterno),
                new SqlParameter("apellidoMaterno", empleado.ApellidoMaterno),
                new SqlParameter("fechaNacimiento", empleado.FechaNacimiento),
                new SqlParameter("correo", empleado.Correo),
                new SqlParameter("rut", empleado.Rut),
                new SqlParameter("fechaRegistro", empleado.FechaRegistro),
                new SqlParameter("telefono", empleado.Telefono),
                new SqlParameter("perfil", empleado.Perfil),
            };

            if (empleado.Clave != null && empleado.Clave != "")
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    empleado.Clave = GetMd5Hash(md5Hash, empleado.Clave);
                    listaParametros.Add(new SqlParameter("clave", empleado.Clave));
                }
            }

            return dBAccess.ModificarDatos("Empleado", listaParametros, filtro);

        }

        private string GetMd5Hash(MD5 md5Hash, string clave)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(clave));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public bool DeshabilitarEmpleado(Empleado empleado)
        {
            DBAccess dBAccess = new DBAccess();
            return dBAccess.DeshabilitarRegistro("Empleado", "idEmpleado", empleado.IdEmpleado);

        }

        public bool ListarEmpleados(out List<Empleado> listaEmpleados)
        {
            
            try
            {
                List<Empleado> listaEmpleadoEncontrados = new List<Empleado>();
                
                DBAccess dBAccess = new DBAccess();
                string query = "SELECT idEmpleado, nombres, apellidoPaterno, apellidoMaterno, rut, correo, fechaNacimiento, telefono, fechaRegistro, perfil, estado FROM Empleado";
                SqlDataReader reader = dBAccess.BuscarRegistro(query);

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.IdEmpleado = int.Parse(reader["idEmpleado"].ToString());
                    empleado.Nombres = reader["nombres"].ToString();
                    empleado.ApellidoPaterno = reader["apellidoPaterno"].ToString();
                    empleado.ApellidoMaterno = reader["apellidoMaterno"].ToString();
                    empleado.Rut = reader["rut"].ToString();
                    empleado.Correo = reader["correo"].ToString();
                    empleado.FechaNacimiento = DateTime.Parse(reader["fechaNacimiento"].ToString());
                    empleado.FechaRegistro = DateTime.Parse(reader["fechaRegistro"].ToString());
                    empleado.Telefono = reader["telefono"].ToString();
                    empleado.Perfil = int.Parse(reader["perfil"].ToString());
                    empleado.Estado = bool.Parse(reader["estado"].ToString());
                    listaEmpleadoEncontrados.Add(empleado);
                }                
                listaEmpleados = listaEmpleadoEncontrados;
                return true;
            }
            catch
            {
                listaEmpleados = null;
                return false;
            }
            
        }


        public Boolean RegistrarEmpleado(Empleado empleado)
        {
            if (empleado.ApellidoMaterno == null)
            {
                empleado.ApellidoMaterno = "";
            }

            if (empleado.Telefono == null)
            {
                empleado.Telefono = "";
            }

            if (empleado.Rut == null)
            {
                empleado.Rut = "";
            }
            DBAccess dBAccess = new DBAccess();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("nombres", empleado.Nombres),
                new SqlParameter("apellidoPaterno", empleado.ApellidoPaterno),
                new SqlParameter("apellidoMaterno", empleado.ApellidoMaterno),
                new SqlParameter("rut", empleado.Rut),
                new SqlParameter("fechaNacimiento", empleado.FechaNacimiento),
                new SqlParameter("correo", empleado.Correo),                
                new SqlParameter("telefono", empleado.Telefono),
                new SqlParameter("fechaRegistro", DateTime.Now),
                new SqlParameter("perfil",empleado.Perfil),
                new SqlParameter("estado", (bool)true)
            };

            using (MD5 md5Hash = MD5.Create())
            {
                empleado.Clave = GetMd5Hash(md5Hash, empleado.Clave);
                parametros.Add(new SqlParameter("clave", empleado.Clave));
            }

            if (dBAccess.InsertarDatos("Empleado", parametros))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean AutenticarEmpleado(Empleado empleado)
        {
            DBAccess dBAccess = new DBAccess();
            string query = "SELECT clave FROM Empleado WHERE correo = '" + empleado.Correo + "'  and estado = 1";
            SqlDataReader reader = dBAccess.BuscarRegistro(query);

            using (MD5 md5Hash = MD5.Create())
            {

                while (reader.Read())
                {

                    if (reader["clave"].ToString() == GetMd5Hash(md5Hash, empleado.Clave))
                    {
                        return true;
                    }
                }
            }


            return false;
        }
    }
}