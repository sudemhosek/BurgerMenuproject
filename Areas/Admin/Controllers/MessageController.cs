using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;
using project2BurgerMenu.entityes;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Inbox()
        {
            var username = Session["x"];
            var email=context.Admins.Where(x=>x.UserName==username).Select(y=>y.Email).FirstOrDefault();
            var values =context.messages.Where(x=>x.ReceiverEmaiL==email).ToList();
            return View(values);
        }  
        public PartialViewResult PartialDetailMessage(int id)
        {
            var message = context.messages.Find(id);
            return PartialView( message);
        }
        public ActionResult SendBox()
        {
            var username = Session["x"];
            var email = context.Admins.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var values = context.messages.Where(x => x.SenderEmail == email).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(message message)
        {
            var username = Session["x"];
            var email = context.Admins.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            message.SenderEmail = email;
            message.Isread = false;
            message.SendDate = DateTime.Now;
            context.messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("SendBox","Message",new {area ="Admin"});
        }
    

      
    }
}