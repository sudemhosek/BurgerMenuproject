using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project2BurgerMenu.entityes
{
    public class Reservation
    {public int reservationId { get;set;}
        public string Name { get;set;}
        public string surname { get;set;}
        public string email { get;set;}
        public string phone { get;set;}
        public int peoplecount { get;set;}
        public DateTime reservationdate { get;set;}
        public string time { get;set;}
        public string message {  get;set;}
        public string reservationstatuse { get;set;}

    }
}