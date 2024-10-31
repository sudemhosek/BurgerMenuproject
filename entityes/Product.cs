using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project2BurgerMenu.entites
{
    public class Product
    {public int productId { get; set; }
        [StringLength(100)]
        public string Productname { get; set; }
        public string Productdescription { get; set; }
        public decimal Productprice { get; set; }
        public string ımageUrl { get; set; }
        public int CategoryId { get; set; }
        public  virtual category category { get; set; }
        public bool? DealOfTheDay { get; set; } 
    }
}