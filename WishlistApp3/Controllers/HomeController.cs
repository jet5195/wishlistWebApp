using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WishlistApp3.Models;

namespace WishlistApp3.Controllers
{
    public class HomeController : Controller
    {
        public wishlistDBEntities db = new wishlistDBEntities();

        public ActionResult Index()
        {
            return View(db.wishlists.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Wishlist()
        {
            return View(db.wishlists.ToList());
        }

        [HttpPost]
        public ActionResult RegButton(string button)
        {
            return View("TestView");
        }

        [HttpPost]
        public ActionResult AddItem(string button)
        {
            return View("TestView");
        }
    }
}