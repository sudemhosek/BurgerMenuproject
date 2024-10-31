using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project2BurgerMenu.entites
{
    public class DealOfTheDay
    {
        public int DealOfTheDayId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string ImageUrl { get; set; }
        public bool status { get; set; }

    }
}