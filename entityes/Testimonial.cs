using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project2BurgerMenu.entites
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string CustomerName { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool status { get; set; }

    }
}