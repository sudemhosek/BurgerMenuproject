using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult ProductList()
        {
            var values =context.products.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProduct()
       
        { List<SelectListItem> values = ( from x in context.categories.ToList()
                                    select new SelectListItem
                                    { Text = x.categoryName,
                                        Value=x.categoryId.ToString()
                                    }).ToList();
            ViewBag.v=values;
            return View();
        }
        
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        { 
            context.products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public ActionResult DelateProduct(int id)
        {
            var value = context.products.Find(id);
            context.products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProductList");

        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> values = (from x in context.categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.categoryName,
                                               Value = x.categoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = context.products.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var value = context.products.Find(product.productId);
            value.Productname=product.Productname;
            value.ımageUrl=product.ımageUrl;
            value.Productdescription=product.Productdescription;
            value.Productprice=product.Productprice;
            value.CategoryId=product.CategoryId;
            context.SaveChanges();
            return RedirectToAction("ProductList");

        }
        public ActionResult Category(int id)
        {
            var values = context.products.Where(x => x.CategoryId == id).ToList();
            return View(values);
        }
    }
}