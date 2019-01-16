using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManicureLand.Controllers
{
    public class CajeraController : Controller
    {
        // GET: Cajera
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ServiciosPagar()
        {
            return View();
        }

    }
}