using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManicureLand.Controllers
{
    public class ManicuristaController : Controller
    {
        // GET: Manicurista
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ModificarServicioEnProceso()
        {
            return View();
        }

        public ActionResult ServicioEnProceso()
        {
            return View();
        }

        public ActionResult ServiciosAsignados()
        {
            return View();
        }
    }
}