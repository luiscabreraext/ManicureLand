﻿using ManicureLand.Models;
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
                Session["Mensaje"] = null;
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

        public ActionResult Servicio(int idServicio)
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            if (idServicio == 0)
            {
                ViewBag.boton = "Guardar";
                return View();
            }
            ServicioService servicioService = new ServicioService();

            Servicio servicio = new Servicio();

            if (servicioService.ObtenerServicio(idServicio, out servicio))
            {
                ModelState.Clear();
                ViewBag.boton = "Modificar";
                return View(servicio);
            }

            Session.Add("Mensaje", "Error la mostrar información del servicio seleccionado");
            return RedirectToAction("Servicios", "Admin");

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
                ModelState.Clear();
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
                ViewBag.Message = (string)Session["Mensaje"];
                return View(listaEmpleados);
            }
            Session.Add("Mensaje", "Error la mostrar información de los empleados");
            return RedirectToAction("PanelAdmin", "Admin");
        }

        public ActionResult Servicios()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }

            ServicioService servicioService = new ServicioService();

            List<Servicio> listaServicios = new List<Servicio>();

            if (servicioService.ListarServicios(out listaServicios))
            {
                ViewBag.Message = (string)Session["Mensaje"];
                return View(listaServicios);
            }
            Session.Add("Mensaje", "Error la mostrar información de los servicios");
            return RedirectToAction("PanelAdmin", "Admin");
        }

        public ActionResult Modificar(Empleado empleado, string accion)
        {
            if (accion.Equals("Modificar"))
            {
                EmpleadoService empleadoService = new EmpleadoService();
                if (empleadoService.ModificarEmpleado(empleado))
                {
                    Session.Add("Mensaje", "Datos modificados Exitosamente");
                }
                else
                {
                    Session.Add("Mensaje", "Error al modificar los, favor reintente más tarde o contáctese al +56 9 8554 7132");
                }
                return RedirectToAction("Empleados", "Admin");
            }
            return Guardar(empleado);
        }

        public ActionResult ModificarServicio(Servicio servicio, string accion)
        {
            if (accion.Equals("Modificar"))
            {
                ServicioService servicioService = new ServicioService();
                if (servicioService.ModificarServicio(servicio))
                {
                    Session.Add("Mensaje", "Datos modificados Exitosamente");
                }
                else
                {
                    Session.Add("Mensaje", "Error al modificar los, favor reintente más tarde o contáctese al +56 9 8554 7132");
                }
                return RedirectToAction("Servicios", "Admin");
            }
            return GuardarServicio(servicio);
        }

        public ActionResult Guardar(Empleado empleado)
        {
            EmpleadoService empleadoService = new EmpleadoService();
            if (empleadoService.RegistrarEmpleado(empleado))
            {
                Session.Add("Mensaje", "Datos registrados Exitosamente");
            }
            else
            {
                Session.Add("Mensaje", "Error al modificar los, favor reintente más tarde o contáctese al +56 9 8554 7132");
            }
            return RedirectToAction("Empleados", "Admin");
        }

        public ActionResult GuardarServicio(Servicio servicio)
        {
            ServicioService servicioService = new ServicioService();
            if (servicioService.RegistrarServicio(servicio))
            {
                Session.Add("Mensaje", "Datos registrados Exitosamente");
            }
            else
            {
                Session.Add("Mensaje", "Error al modificar los, favor reintente más tarde o contáctese al +56 9 8554 7132");
            }
            return RedirectToAction("Servicios", "Admin");
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
                    return RedirectToAction("Servicios", "Admin");
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
            ViewBag.Message = (string)Session["Mensaje"];
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

        public ActionResult NuevoServicio()
        {
            if (!ValidarSesion())
            {
                Session.Add("Mensaje", "Sesion no se encuentra iniciada.");
                return RedirectToAction("Intranet", "Home");
            }
            ViewBag.boton = "Guardar";
            return View("Servicio");
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