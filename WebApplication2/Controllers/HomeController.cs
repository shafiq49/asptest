using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        function function = new function();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello Shafiq !!!";
            var Contact = new Contact()
            {
                id = 1,
                name = "Shafiq",
                address= "Basabo, Dhaka",
                mobile = 01313474849

            };
            

            return View(Contact);
        }

        

    }
}