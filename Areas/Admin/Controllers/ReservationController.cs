using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using project2BurgerMenu.Context;
using project2BurgerMenu.entites;
using project2BurgerMenu.entityes;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult ReservationList()
        {
            var values = context.Reservations.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult DetailReservation(int id)
        {
            var value = context.Reservations.Where(x => x.reservationId == id).FirstOrDefault();
            return View(value);
        }
        public ActionResult Delate(int id)
        {
            var value = context.Reservations.Find(id);
            context.Reservations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ReservationList");

        }

        [HttpPost]
        public ActionResult DetailReservation(Reservation reservation)
        {
            var values = context.Reservations.Find(reservation.reservationId);
            values.Name = reservation.Name;
            values.surname = reservation.surname;
            values.email = reservation.email;
            values.phone = reservation.phone;
            values.peoplecount = reservation.peoplecount;
            values.reservationdate = reservation.reservationdate;
            values.time = reservation.time;
            values.message = reservation.message;
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }


        public ActionResult StatusChangeToConfirm(int id)
        {
            var value = context.Reservations.Where(x => x.reservationId == id).FirstOrDefault();
            value.reservationstatuse = "Onaylandı";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult StatusChangeToCancel(int id)
        {
            var value = context.Reservations.Where(x => x.reservationId == id).FirstOrDefault();
            value.reservationstatuse = "İptal Edildi";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult StatusChangeToWait(int id)
        {
            var value = context.Reservations.Where(x => x.reservationId == id).FirstOrDefault();
            value.reservationstatuse = "Onay Bekleniyor";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }
    }
}