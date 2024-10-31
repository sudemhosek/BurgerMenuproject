using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class SubscribersController : Controller
    {BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {var value =context.subscriberss.ToList();
            return View(value);
        }
        public ActionResult Delate(int id)
        {
            var value = context.subscriberss.Find(id);
            context.subscriberss.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}