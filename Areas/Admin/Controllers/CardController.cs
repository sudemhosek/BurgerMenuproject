using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project2BurgerMenu.Areas.Admin.Controllers
{
    public class CardController : Controller
    {
        // GET: Admin/Card
        public ActionResult Index()
        {
            return View();
        }
    }
}