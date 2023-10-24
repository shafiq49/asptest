using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            User aUser = new User()
            {
                Id = 1,
                Name = "Shafiq",
                Age= 35

            };
            return View(aUser);
        }
    }
}