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
        public Cliente ObtenerCliente(int id) {
            Cliente cliente = new Cliente();
            
            return cliente;

        }

        public List<Cliente> BuscarCliente(string nombreCampo, string valorCampo) {
            List<Cliente> listaCliente = new List<Cliente>();
            //sqldatareader
            return listaCliente;
        }

        public List<Cliente> ListarClientes() {
            List<Cliente> listaClientes = new List<Cliente>();

            Cliente cliente1 = new Cliente(1,"Juana María","Perez","Contreras", new DateTime(1990,12,8),"juanamaria@gmail.com", "e99a18c428cb38d5f260853678922e03","","+56997057307");
            Cliente cliente2 = new Cliente(1, "Juana María 2", "Perez", "Contreras", new DateTime(1990, 12, 8), "juanamaria@gmail.com", "e99a18c428cb38d5f260853678922e03", "", "+56997057307");
            Cliente cliente3 = new Cliente(1, "Juana María 3", "Perez", "Contreras", new DateTime(1990, 12, 8), "juanamaria@gmail.com", "e99a18c428cb38d5f260853678922e03", "", "+56997057307");

            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
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
                new SqlParameter("telefonoFijo", cliente.TelefonoFijo),
                new SqlParameter("telefonoMovil", cliente.TelefonoMovil),
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