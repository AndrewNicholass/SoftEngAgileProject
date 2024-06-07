using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluentify.Controllers
{
    // [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Account", "Login");
            }
            return View();
        }

        public ActionResult Modules()
        {
            return View();
        }
    }
}