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
    public class contactController : Controller
    {
       BurgerMenuContext context = new BurgerMenuContext();
        public PartialViewResult partialcontactaddress()
        {
            ViewBag.address = context.Abouts.Select(x => x.address).FirstOrDefault();
            ViewBag.email = context.Abouts.Select(x => x.email).FirstOrDefault();
            ViewBag.phonenumber = context.Abouts.Select(x => x.phonenumber).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult partialcontactlocation()
        {
            ViewBag.maplocation = context.Abouts.Select(x => x.maplocation).FirstOrDefault();
            return PartialView();
        }
    }
}