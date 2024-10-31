using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;
using project2BurgerMenu.entityes;

namespace project2BurgerMenu.Controllers
{
    public class DefaultController : Controller
    {BurgerMenuContext context = new BurgerMenuContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(contact contact)
        {
            contact.isread = false;
            context.contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public PartialViewResult partialHead()
        { 
            return PartialView();
        }
        public PartialViewResult partialnavbar()
        { 
            return PartialView();
        }
        public PartialViewResult partialAbout()
        { var values =context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult TodaysOffer()
        { var values =context.products.Where(x=>x.DealOfTheDay==true).ToList();
            return PartialView(values);
        }
        public PartialViewResult partialMenu()
        {
            var products = context.products.ToList();
            return PartialView("PartialMenu", products);

        }
        public PartialViewResult partialcategory()
        {
            var values = context.categories.Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult partialfood()
        {
            return PartialView();
        }
        public PartialViewResult partialgallery()
        { var values =context.gallerys.ToList();
            return PartialView(values);
        }
        public PartialViewResult partialfooter()
        {
            ViewBag.description = context.Abouts.Select(x => x.Description).FirstOrDefault();
            return PartialView();
        }
        
        [HttpPost]
        public ActionResult PartialSubscribe(subscribers subscribe)
        {
            if (ModelState.IsValid)
            {subscribe.Date=DateTime.Now;
                context.subscriberss.Add(subscribe);
                context.SaveChanges();

                return RedirectToAction("Index", "Default");
            }

            return PartialView();
        }
        public PartialViewResult partialscripts()
        { 
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult partialreservation()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult partialreservation(Reservation reservation)
        {
            reservation.reservationstatuse = "Onay Bekleniyor";
            //  System.Diagnostics.Debug.WriteLine($"PeopleCount: {reservation.PeopleCount}");
            reservation.reservationdate = DateTime.Now;
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }
        public ActionResult GetProductsByCategory(int id)
        {
            var products = context.products.Where(p => p.CategoryId == id).ToList();
            if (products == null || !products.Any())
            {
                return PartialView("partialMenu", new List<project2BurgerMenu.entites.Product>()); // Boş bir liste döndür
            }
            return PartialView("partialMenu", products);
        }

    }
}