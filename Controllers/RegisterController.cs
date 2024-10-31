using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.entites;
using project2BurgerMenu.Context;
using project2BurgerMenu.entityes;

namespace project2BurgerMenu.Controllers
{
    public class RegisterController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {context.Admins.Add(admin);
            context.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}