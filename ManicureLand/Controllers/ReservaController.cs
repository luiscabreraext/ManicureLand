using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManicureLand.Controllers
{
    public class ReservaController : Controller
    {
        // GET: Reserva
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SolicitarReserva()
        {
            return View();
        }
        
    }
}