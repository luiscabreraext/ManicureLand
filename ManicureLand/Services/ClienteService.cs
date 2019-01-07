using ManicureLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Services
{
    public class ClienteService
    {
        public Cliente obtenerCliente(int id) {
            Cliente cliente = new Cliente();
            
            return cliente;

        }

        public Cliente buscarCliente(string nombreCampo, string valorCampo) {
            Cliente cliente = new Cliente();

            return cliente;
        }

        public List<Cliente> listarClientes() {
            List<Cliente> listaClientes = new List<Cliente>();

            Cliente cliente1 = new Cliente(1,"Juana María","Perez","Contreras", new DateTime(1990,12,8),"juanamaria@gmail.com", "e99a18c428cb38d5f260853678922e03","","+56997057307");
            Cliente cliente2 = new Cliente(1, "Juana María 2", "Perez", "Contreras", new DateTime(1990, 12, 8), "juanamaria@gmail.com", "e99a18c428cb38d5f260853678922e03", "", "+56997057307");
            Cliente cliente3 = new Cliente(1, "Juana María 3", "Perez", "Contreras", new DateTime(1990, 12, 8), "juanamaria@gmail.com", "e99a18c428cb38d5f260853678922e03", "", "+56997057307");

            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
            return listaClientes;
        }

        public Boolean registrarCliente(Cliente cliente) {
            return true;
        }

        public Boolean autenticarCliente(Cliente cliente) {
            return true;
        }

        public Boolean darBajaCliente(Cliente cliente) {
            return true;
        }

        public Boolean actualizarDatosCliente(Cliente cliente) {
            return true;
        }
    }
}