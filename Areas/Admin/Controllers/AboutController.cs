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
    public class AboutController : Controller
    {
       BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult list()
        {
            var value = context.Abouts
                .ToList();
            return View(value);
        }

        [HttpGet]

        public ActionResult update(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult update(About about)
        {
            var value = context.Abouts.Find(about.AboutId);
            value.Title = about.Title;
            value.Description = about.Description;
            value.Img = about.Img;
            context.SaveChanges();
            return RedirectToAction("list");
        }
    }
}