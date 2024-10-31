using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using project2BurgerMenu.entites;
using project2BurgerMenu.entityes;

namespace project2BurgerMenu.Context
{
    public class BurgerMenuContext : DbContext
    {
        public DbSet<category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<DealOfTheDay> dealOfTheDay { get; set; }
        public DbSet<Testimonial> testimonials { get; set;}
        public DbSet<Admin> Admins { get; set;}
        public DbSet<Reservation> Reservations { get; set;}
        public DbSet<About> Abouts { get; set;}
        public DbSet<message> messages { get; set;}
        public DbSet<contact> contacts { get; set;}
        public DbSet<Gallery> gallerys { get; set;}
        public DbSet<subscribers> subscriberss {  get; set;}


    }
}