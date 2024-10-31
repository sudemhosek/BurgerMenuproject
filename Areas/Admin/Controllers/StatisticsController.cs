using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.entites;
using project2BurgerMenu.Context;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class StatisticsController : Controller
    {
       BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            ViewBag.products = context.products.Count();
            ViewBag.categoryCount = context.categories.Count();
            ViewBag.reservationCount = context.Reservations.Count();
            ViewBag.totalPeopleCount = context.Reservations.Sum(r => r.peoplecount);
            ViewBag.testimonialsCount = context.contacts.Count();
            ViewBag.pendingReservations = context.Reservations.Count(r => r.reservationstatuse == "onay bekliyor");
            ViewBag.cancelledReservations = context.Reservations.Count(r => r.reservationstatuse == "İptal Edildi");
            ViewBag.approvedReservations = context.Reservations.Count(r => r.reservationstatuse == "Onaylandı");
            ViewBag.subscriberCount = context.subscriberss.Count();
            ViewBag.mostExpensiveDish = context.products.OrderByDescending(p => p.Productprice).Select(p => p.Productname).FirstOrDefault();
            ViewBag.mainCourseCount = context.products.Count(p => p.category.categoryName == "Ana Yemekler");
            ViewBag.lastReserve = context.Reservations.OrderByDescending(x => x.reservationId).Select(x => x.time).FirstOrDefault();

            return View();
        }
    }
}