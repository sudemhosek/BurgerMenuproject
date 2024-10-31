using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.entites;
using project2BurgerMenu.Context;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class NewContactController : Controller
    {
        BurgerMenuContext context= new BurgerMenuContext();
        public ActionResult Inbox()
        {var value = context.contacts.ToList();
            return View(value);
        }

        public ActionResult DetailMessage(int id)
        {
            var value = context.contacts.Where(x => x.contactid == id).FirstOrDefault();
            value.isread = true;
            context.SaveChanges();
            return View(value);
        }

        public ActionResult MessageStatusChangeToTrue(int id)
        {
            var value = context.contacts.Where(x => x.contactid == id).FirstOrDefault();
            value.isread = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public ActionResult MessageStatusChangeToFalse(int id)
        {
            var value = context.contacts.Where(x => x.contactid == id).FirstOrDefault();
            value.isread = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = context.contacts.Find(id);
            context.contacts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
    
}
}