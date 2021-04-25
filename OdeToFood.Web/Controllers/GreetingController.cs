using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            GreetingViewModel model = new GreetingViewModel();

            // generally  I dont need to access the HttpContext directly
            // string name = HttpContext.Request.QueryString["name"];
            // instead we pass name as a parameter and the MVC framework will search the querystring for it 
            model.Name = name ?? "no name"; // the null coalescing operator
            // let's pull out the message string from the configuratin file
            model.Message = ConfigurationManager.AppSettings["message"];

            return View(model);
        }
    }
}