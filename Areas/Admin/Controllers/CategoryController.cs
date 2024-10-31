using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult CategoryList()
        {var values =context.categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult Create()

        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(category category)
        {
            context.categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("categoryList");
        }

        public ActionResult Delate(int id)
        {
            var value = context.categories.Find(id);
            context.categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("categoryList");

        }
        [HttpGet]
        public ActionResult Update(int id)
        {

            var values = context.categories.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult Update(category category)
        {
            var values = context.categories.Find(category.categoryId);
            values.categoryName = category.categoryName;
            context.SaveChanges();
            return RedirectToAction("CategoryList");

        }
    }
}