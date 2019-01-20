using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManicureLand.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if ((string)Session["Mensaje"] != null)
            {
                ViewBag.Message = (string)Session["Mensaje"];
                Session.Remove("Mensaje");
            }            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}