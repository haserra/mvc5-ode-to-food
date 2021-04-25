using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData db;
        // private InMemoryRestaurantData db;
        // private field or instance member

        // The idea behind inversion of control is that, rather than tie the classes in your application together 
        // and let classes “new up” their dependencies, you switch it around so dependencies are instead passed in
        // during class construction. Martin Fowler has an excellent article explaining dependency injection/inversion of control if you want more on that.

        /**
        public HomeController()
        {
            this.db = new InMemoryRestaurantData();
        }
        */
        // instead o hardcoding the InMemoryRestaurantData dependency inside the HomeController class, let's inject it as a parameter
        // into the constructor, following best practices/ S.O.L.I.D. principles

        // the constructor is needed to initialize the private field db

        public HomeController(IRestaurantData db)
        {
            this.db = db;
        }
       
        public ActionResult Index()
        {
            string hello = "Hello, world!";
            IEnumerable<Restaurant> model = db.GetAll();
            //return hello;
            return View(model);           
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
    }
}