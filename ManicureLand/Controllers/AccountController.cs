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
        // GET: Account
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult FormularioRegistro()
        {
            ViewBag.Message = "Registra una cuenta";

            return View();
        }

        public ActionResult RegistroProducto()
        {
            ViewBag.Message = "Registra una producto";

            return View();
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

        public ActionResult RegistrarProd(Producto prod)
        {
            ProductoService productoService = new ProductoService();
            if (productoService.RegistrarProd(prod))
            {
                return RedirectToAction("FormularioRegistro", "Account");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

    }
}