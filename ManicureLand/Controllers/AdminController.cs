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

        public ActionResult Empleado(int idEmpleado)
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");                
                return RedirectToAction("Intranet", "Home");
            }
            if (idEmpleado == 0)
            {
                ViewBag.boton = "Guardar";
                return View();
            }
            EmpleadoService empleadoService = new EmpleadoService();

            Empleado empleado = new Empleado();

            if (empleadoService.ObtenerEmpleado(idEmpleado, out empleado))
            {
                ViewBag.boton = "Modificar";
                return View(empleado);
            }
            
            Session.Add("Mensaje", "Error la mostrar información del empleado seleccionado");
            return RedirectToAction("Empleados", "Admin");

        }

        public ActionResult Empleados()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }

            EmpleadoService empleadoService = new EmpleadoService();

            List<Empleado> listaEmpleados = new List<Empleado>();

            if (empleadoService.ListarEmpleados(out listaEmpleados))
            {
                //Session.Add("listaEmpleados", listaEmpleados);
                //return RedirectToAction("Empleados", "Admin");
                return View(listaEmpleados);
            }
            Session.Add("Mensaje", "Error la mostrar información de los empleados");
            return RedirectToAction("PanelAdmin", "Admin");
        }

        public ActionResult Modificar(Empleado empleado, string accion)
        {
            if (accion.Equals("Modificar"))
            {
                EmpleadoService empleadoService = new EmpleadoService();
                if (empleadoService.ModificarEmpleado(empleado))
                {
                    ViewBag.Message = "Datos modificados Exitosamente";
                }
                else
                {
                    ViewBag.Message = "Error al modificar los, favor reintente más tarde o contáctese al +56 9 8554 7132";
                }
                return RedirectToAction("MisDatos", "Account");
            }
            return Guardar(empleado);
        }

        public ActionResult Guardar(Empleado empleado)
        {
            EmpleadoService empleadoService = new EmpleadoService();
            if (empleadoService.RegistrarEmpleado(empleado))
            {
                ViewBag.Message = "Datos registrados Exitosamente";
            }
            else
            {
                ViewBag.Message = "Error al modificar los, favor reintente más tarde o contáctese al +56 9 8554 7132";
            }
            return RedirectToAction("Empleados", "Admin");
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
                    return RedirectToAction("Empleados", "Admin");
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

        public ActionResult NuevoEmpleado()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            ViewBag.boton = "Guardar";
            return View("Empleado");
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