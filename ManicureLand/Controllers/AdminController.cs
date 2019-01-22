using ManicureLand.Models;
using ManicureLand.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManicureLand.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public bool ValidarSesion()
        {
            if ((Empleado)Session["Empleado"] == null)
            {
                return false;
            }
            return true;
        }

        public ActionResult Ingresar(Empleado empleado)
        {
            EmpleadoService empleadoService = new EmpleadoService();
            if (empleadoService.AutenticarEmpleado(empleado))
            {
                if (empleadoService.ObtenerEmpleado(empleado.Correo, out empleado))
                {
                    Session.Add("Empleado", empleado);
                }
                return PanelAdmin();
            }
            Session.Add("Mensaje", "Error al validar usuario o clave.");
            return RedirectToAction("Intranet", "Home");
        }

        public ActionResult Diseno()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            return View();
        }

        public ActionResult CatalogoDiseno()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            return View();
        }

        public ActionResult CatalogoServicio()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            return View();
        }

        public ActionResult Empleado()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            return View();
        }

        public ActionResult Atenciones()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            return View();
        }

        public ActionResult Panel(string accion)
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            switch (accion)
            {
                case "Empleados":
                    return RedirectToAction("Empleado", "Admin");
                case "Servicios":
                    return RedirectToAction("Servicio", "Admin");
                case "Diseños":
                    return RedirectToAction("Diseno", "Admin");
                case "Turnos":
                    return RedirectToAction("Turnos", "Admin");
                case "Catalogo de Diseños":
                    return RedirectToAction("CatalogoDiseno", "Admin");
                case "Catalogo de Servicios":
                    return RedirectToAction("CatalogoServicio", "Admin");
                case "Atenciones":
                    return RedirectToAction("Atenciones", "Admin");
                case "Cerrar Sesión":
                    return CerrarSession();
                default:
                    return RedirectToAction("Intranet", "Home");
            }
            
        }

        public ActionResult CerrarSession()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult PanelAdmin()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            return View("PanelAdmin");
        }

        public ActionResult Servicio()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            return View();
        }

        public ActionResult Turnos()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            return View();
        }

    }
}