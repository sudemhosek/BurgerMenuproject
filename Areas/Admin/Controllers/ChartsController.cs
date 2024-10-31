using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class ChartsController : Controller
    {BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReservationPeopleChart()
        {
            var data = context.Reservations
                .GroupBy(r => r.time)
                .Select(g => new
                {
                    ReservationTime = g.Key,
                    TotalPeople = g.Sum(r => r.peoplecount)
                })
                .ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ReservationStatusChart()
        {
            var data = context.Reservations
                .GroupBy(r => r.reservationstatuse) // 'status' alanı ile grupluyoruz
                .Select(g => new
                {
                    ReservationStatus = g.Key,
                    ReservationCount = g.Count()
                }).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ReservationTimeChart()
        {
            var data = context.Reservations.GroupBy(r => r.time)
                .Select(g => new
                {
                    ReservationTime = g.Key,
                    ReservationCount = g.Count()
                }).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CategoryProductChart()
        {
            var data = context.categories
                .Where(c => c.products.Count > 0)
                .Select(c => new
                {
                    CategoryName = c.categoryName,
                    ProductCount = c.products.Count
                })
                .ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}