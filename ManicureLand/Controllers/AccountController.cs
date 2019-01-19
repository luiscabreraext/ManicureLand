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

        public ActionResult Ingresar(Cliente cliente)
        {
            ClienteService clienteService = new ClienteService();
            if (clienteService.AutenticarCliente(cliente))
            {
                if (clienteService.ObtenerCliente(cliente.Correo, out cliente))
                {
                    Session.Add("Cliente", cliente);
                }
                return RedirectToAction("MisDatos", "Account");
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult FormularioRegistro()
        {
            return View();
        }

        public ActionResult MisDatos(Cliente cliente)
        {
            if (cliente.IdCliente < 1 || cliente.Correo == null)
            {
                if ((Cliente)Session["Cliente"] != null)
                {
                    cliente = (Cliente)Session["Cliente"];
                }
                else
                {
                    ViewBag.Message = "Error al recupoerar información de la cuenta, favor reintente más tarde o contáctese al +56 9 8554 7132";
                    return RedirectToAction("Index", "Home");
                }
                
            }

            ClienteService clienteService = new ClienteService();
            if (clienteService.ObtenerCliente(cliente.IdCliente, out cliente))
            {
                ModelState.Clear();
                return View(cliente);
            }
            else
            {
                ViewBag.Message = "Error al recupoerar información de la cuenta, favor reintente más tarde o contáctese al +56 9 8554 7132";
                return RedirectToAction("Index", "Home");
            }            
        }

        public ActionResult Registrar(Cliente cliente)
        {
            ClienteService clienteService = new ClienteService();
            if (clienteService.RegistrarCliente(cliente))
            {
                ViewBag.Message = "Cuenta Registrada";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Error al registrar cuenta, favor reintente más tarde o contáctese al +56 9 8554 7132";
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
                    ViewBag.Message = "Datos modificados Exitosamente";
                }
                else
                {
                    ViewBag.Message = "Error al modificar los, favor reintente más tarde o contáctese al +56 9 8554 7132";
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
                ViewBag.Message = "Cuenta deshabilitada exitosamente";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Error al deshabilitar cuenta, favor reintente más tarde o contáctese al +56 9 8554 7132";
                return RedirectToAction("MisDatos", "Account");
            }
        }
    }
}