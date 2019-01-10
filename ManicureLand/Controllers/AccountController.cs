using ManicureLand.Services;
using System;
using System.Collections.Generic;
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

        public ActionResult Register()
        {
            DBAccess db = new DBAccess();
            db.Test();
            ViewBag.Message = "Registra una cuenta";

            return View();
        }
        
    }
}