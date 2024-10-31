using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;
using Newtonsoft.Json.Linq;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialAdd()
        {
            List<SelectListItem> values = (from x in context.categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.categoryName,
                                               Value = x.categoryId.ToString()
                                           }).ToList();
            ViewBag.Categories = values;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAdd(Product product)
        {
            context.products.Add(product);
            context.SaveChanges();
            return PartialView();
        }
    }
}