using ManicureLand.Models;
using ManicureLand.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManicureLand.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public bool ValidarSesion()
        {
            if ((Cliente)Session["Cliente"] == null)
            {
                return false;
            }
            return true;
        }

        public ActionResult Ingresar(Cliente cliente)
        {
            ClienteService clienteService = new ClienteService();
            if (clienteService.AutenticarCliente(cliente))
            {
                if (clienteService.ObtenerCliente(cliente.Correo, out cliente))
                {
                    Session.Add("Cliente", cliente);
                }
                return PanelCliente();
            }
            Session.Add("Mensaje", "Error al validar usuario o clave.");
            return RedirectToAction("Index", "Home");
        }

        public ActionResult FormularioRegistro()
        {
            return View();
        }

        public ActionResult PanelCliente()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Index", "Home");
            }
            return View("PanelCliente");
        }

        public ActionResult Panel(string accion)
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Index", "Home");
            }
            switch (accion) {
                case "Mis Datos":
                    return RedirectToAction("MisDatos", "Account");
                case "Mis Reservas":
                    return RedirectToAction("MisReservas", "Account");
                case "Reservar":
                    return RedirectToAction("FormularioReserva", "Account");
                case "Cerrar Sesión":
                    return CerrarSession();
                default:
                    return RedirectToAction("Index", "Home");

            }
        }

        public ActionResult MisReservas()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult FormularioReserva()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult CerrarSession()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult MisDatos()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Index", "Home");
            }

            Cliente cliente = new Cliente();
            if ((Cliente)Session["Cliente"] != null)
            {
                cliente = (Cliente)Session["Cliente"];
            }
            else
            {
                Session.Add("Mensaje", "Error al recupoerar información de la cuenta, favor reintente más tarde o contáctese al +56 9 8554 7132");
                return RedirectToAction("Index", "Home");
            }
                
            ClienteService clienteService = new ClienteService();
            if (clienteService.ObtenerCliente(cliente.IdCliente, out cliente))
            {
                ModelState.Clear();
                ViewBag.Message = (string)Session["Mensaje"];
                return View(cliente);
            }
            else
            {
                Session.Add("Mensaje","Error al recupoerar información de la cuenta, favor reintente más tarde o contáctese al +56 9 8554 7132");
                return RedirectToAction("Index", "Home");
            }            
        }

        public ActionResult Registrar(Cliente cliente)
        {
            ClienteService clienteService = new ClienteService();
            if (clienteService.RegistrarCliente(cliente))
            {
                Session.Add("Mensaje", "Cuenta Registrada");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Session.Add("Message", "Error al registrar cuenta, favor reintente más tarde o contáctese al +56 9 8554 7132");
                return RedirectToAction("FormularioRegistro", "Account");
            }
        }

        public ActionResult Modificar(Cliente cliente, string accion)
        {
            if (accion.Equals("Modificar"))
            {
                ClienteService clienteService = new ClienteService();
                if (clienteService.ModificarCliente(cliente))
                {
                    Session.Add("Mensaje", "Datos modificados Exitosamente");
                }
                else
                {
                    Session.Add("Mensaje", "Error al modificar los, favor reintente más tarde o contáctese al +56 9 8554 7132");
                }
                return RedirectToAction("MisDatos", "Account");
            }
                return Deshabilitar(cliente);        
        }

        public ActionResult Deshabilitar(Cliente cliente)
        {
            ClienteService clienteService = new ClienteService();
            if (clienteService.DeshabilitarCliente(cliente))
            {
                Session.Add("Mensaje", "Cuenta deshabilitada exitosamente");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Session.Add("Mensaje", "Error al deshabilitar cuenta, favor reintente más tarde o contáctese al +56 9 8554 7132");
                return RedirectToAction("MisDatos", "Account");
            }
        }
    }
}