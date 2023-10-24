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
            string dt1, dt2;
            dt1 = "01/05/2021";
            dt2 = "01/05/2022";
            var diffs = function.YearMonthDiff(Convert.ToDateTime(dt1), Convert.ToDateTime(dt2));
            //Console.WriteLine("TotalMonths: " + diffs.TotalMonths);
            //Console.WriteLine("Years: " + diffs.Years);
            //Console.WriteLine("Months: " + diffs.Months);
            DateTime xxs = Convert.ToDateTime("01/05/2022");
            DateTime xxs1 = function.Make_DateSQL("01/05/2022");
            ViewBag.Message = "Year is :" + diffs.Years + Environment.NewLine + "Month is : " + diffs.Months + Environment.NewLine + "Total Month is : " + diffs.TotalMonths + Environment.NewLine + "Date: " + xxs + Environment.NewLine + "Date: " + xxs1;

            return View();
        }

        public ActionResult User()
        {
            return View();

        }
       

    }
}