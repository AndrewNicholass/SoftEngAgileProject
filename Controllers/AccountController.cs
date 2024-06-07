using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Fluentify.Models;

namespace Fluentify.Controllers
{
    public class AccountController : Controller
    {
        Database1Entities db = new Database1Entities();
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel credentials)
        {
            bool userExists = db.Users.Any(x  => x.Username == credentials.Username && x.Password == credentials.Password);
            User user = db.Users.FirstOrDefault(x => x.Username == credentials.Username && x.Password == credentials.Password);
            Session["user"] = null;

            if (userExists)
            {
                Session["user"] = user;
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return RedirectToAction("Home", "Home");
            }

            ModelState.AddModelError("", "Username or Password is wrong");

            return View();
        }
        public int GenerateId()
        {
            User user = db.Users.ToList().LastOrDefault();
            int lastId = user.UserId;
            return lastId + 1;
        }

        [HttpPost]
        public ActionResult Register(User userInfo)
        {
            userInfo.UserId = GenerateId();
            db.Users.Add(userInfo);
            db.SaveChanges();
            return RedirectToAction("Login");
        }
    }
}