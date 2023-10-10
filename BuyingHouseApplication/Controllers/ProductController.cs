using BuyingHouseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuyingHouseApplication.Controllers
{


    public class ProductController : Controller
    {
        private ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() {


            return View();
        }

        [HttpPost]
        public ActionResult SaveProduct(Product product) {
            var pro = new Product()
            {
                Name = product.Name,
                Color = product.Color,
                Description = product.Description,
                Unitprice = product.Unitprice,
                Quantity = product.Quantity,
                Fabric = product.Fabric
            };
            _context.Products.Add(pro);
            _context.SaveChanges();

            return View("Index");
        }
    }
}