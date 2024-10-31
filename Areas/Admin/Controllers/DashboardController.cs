using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            ViewBag.datetime = DateTime.Now.ToString("dd/MM/yyyy");
            ViewBag.products = context.products.Count();
            ViewBag.reservations = context.Reservations.Count();
            ViewBag.admins = context.Admins.Count();
            ViewBag.testimonials = context.contacts.Count();
            ViewBag.productNames = context.products.Select(p => p.Productname).ToList();
            ViewBag.productPrices = context.products.Select(p => p.Productprice).ToList();
            ViewBag.productCategory = context.products.Select(p => p.category.categoryName).ToList();

            // Progress için rastgele değerler oluşturma
            Random random = new Random();
            List<int> progressValues = new List<int>();

            for (int i = 0; i < ViewBag.productNames.Count; i++)
            {
                int randomProgress = random.Next(0, 101); // 0 ile 100 arasında rastgele bir sayı oluştur
                progressValues.Add(randomProgress);
            }

            ViewBag.productProgress = progressValues;

            return View();
        }
    }
}