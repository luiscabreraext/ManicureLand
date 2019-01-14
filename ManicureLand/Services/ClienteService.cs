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
        public bool ObtenerCliente(out Cliente cliente)
        {
            Cliente clienteEncontrado = new Cliente();
            clienteEncontrado.IdCliente = 1;
            clienteEncontrado.Nombres = "test";
            clienteEncontrado.ApellidoPaterno = "test";
            clienteEncontrado.ApellidoMaterno = "test";
            clienteEncontrado.Correo = "test@test.cl";
            clienteEncontrado.FechaNacimiento = DateTime.Parse("25-10-1984");
            clienteEncontrado.FechaRegistro = DateTime.Parse("31-12-2018");
            clienteEncontrado.Telefono = "+56987654321";
            cliente = clienteEncontrado;
            return true;
        }

        public bool ModificarCliente(Cliente cliente)
        {
            return true;
        }

        public bool DeshabilitarCliente(Cliente cliente)
        {
            return true;
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