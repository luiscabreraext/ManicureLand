using ManicureLand.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManicureLand.Services
{
    public class ClienteService
    {
        public bool ObtenerCliente(int idCliente, out Cliente cliente)
        {
            try
            {
                Cliente clienteEncontrado = new Cliente();
                DBAccess dBAccess = new DBAccess();
                string query = "SELECT nombres, apellidoPaterno, apellidoMaterno, fechaNacimiento, correo, telefono, fechaRegistro, advertencias, estado FROM Cliente WHERE idCliente = " + idCliente.ToString();
                SqlDataReader reader = dBAccess.BuscarRegistro(query);

                while (reader.Read())
                {
                    clienteEncontrado.IdCliente = idCliente;
                    clienteEncontrado.Nombres = reader["nombres"].ToString();
                    clienteEncontrado.ApellidoPaterno = reader["apellidoPaterno"].ToString();
                    clienteEncontrado.ApellidoMaterno = reader["apellidoMaterno"].ToString();
                    clienteEncontrado.Correo = reader["correo"].ToString();
                    clienteEncontrado.FechaNacimiento = DateTime.Parse(reader["fechaNacimiento"].ToString());
                    clienteEncontrado.FechaRegistro = DateTime.Parse(reader["fechaRegistro"].ToString());
                    clienteEncontrado.Telefono = reader["telefono"].ToString();
                }

                cliente = clienteEncontrado;
                return true;
            }
            catch {
                cliente = null;
                return false;
            }
            
        }

        public bool ModificarCliente(Cliente cliente)
        {
            DBAccess dBAccess = new DBAccess();
            string filtro = "idCliente = " + cliente.IdCliente.ToString();
            List<SqlParameter> listaParametros = new List<SqlParameter>
            {
                new SqlParameter("nombres", cliente.Nombres),
                new SqlParameter("apellidoPaterno", cliente.ApellidoPaterno),
                new SqlParameter("apellidoMaterno", cliente.ApellidoMaterno),
                new SqlParameter("fechaNacimiento", cliente.FechaNacimiento),
                new SqlParameter("correo", cliente.Correo),
                new SqlParameter("telefono", cliente.Telefono),
            };
            
            if (cliente.Clave != null && cliente.Clave != "")
            {
                listaParametros.Add(new SqlParameter("clave", cliente.Clave));
            }

            return dBAccess.ModificarDatos("Cliente", listaParametros, filtro);

        }

        public bool DeshabilitarCliente(Cliente cliente)
        {
            DBAccess dBAccess = new DBAccess();
            return dBAccess.DeshabilitarRegistro("Cliente", "idCliente", cliente.IdCliente);
            
        }

        public List<Cliente> BuscarClientes(string nombreCampo, string valorCampo) {
            List<Cliente> listaCliente = new List<Cliente>();
            //sqldatareader
            return listaCliente;
        }

        public List<Cliente> ListarClientes() {
            List<Cliente> listaClientes = new List<Cliente>();
            return listaClientes;
        }

        public Boolean RegistrarCliente(Cliente cliente) {
            DBAccess dBAccess = new DBAccess();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("nombres", cliente.Nombres),
                new SqlParameter("apellidoPaterno", cliente.ApellidoPaterno),
                new SqlParameter("apellidoMaterno", cliente.ApellidoMaterno),
                new SqlParameter("fechaNacimiento", cliente.FechaNacimiento),
                new SqlParameter("correo", cliente.Correo),
                new SqlParameter("clave", cliente.Clave),
                new SqlParameter("telefono", cliente.Telefono),
                new SqlParameter("fechaRegistro", DateTime.Now),
                new SqlParameter("advertencias", int.Parse("0")),
                new SqlParameter("estado", (bool)true)
            };

            if (dBAccess.InsertarDatos("Cliente",parametros))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public Boolean AutenticarCliente(Cliente cliente) {
            return true;
        }

        public Boolean DarBajaCliente(Cliente cliente) {
            return true;
        }

        public Boolean ActualizarDatosCliente(Cliente cliente) {
            return true;
        }
    }
}