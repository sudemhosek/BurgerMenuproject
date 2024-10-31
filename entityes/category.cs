using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project2BurgerMenu.entites
{
    public class category
    {public int categoryId { get;set;}
        public string categoryName { get;set;}
        public List<Product> products { get;set;}
    }
}