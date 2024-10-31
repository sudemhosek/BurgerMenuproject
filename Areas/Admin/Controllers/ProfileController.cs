using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult MyProfileList()
        {
            var username = Session["x"];
            var values = context.Admins.Where(x => x.UserName == username).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult MyProfileList(project2BurgerMenu.entityes.Admin admin)
        {
            var username = Session["x"];
            var values = context.Admins.Where(x => x.UserName == username).FirstOrDefault();
            values.UserName = admin.UserName;
            values.Surname = admin.Surname;
            values.Name = admin.Name;
            values.Password = admin.Password;
            values.Email = admin.Email;
            context.SaveChanges();
            return RedirectToAction("Index", "login");
        }
         
    }
}