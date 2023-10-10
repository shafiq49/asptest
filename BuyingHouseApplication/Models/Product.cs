using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyingHouseApplication.Models
{
    public class Product
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public string Fabric { get; set; }

        public string Color { get; set; }

        public int Quantity { get; set; }

        public double Unitprice { get; set; }

        public string Description { get; set; }


        public Category Category { get; set; }
  
    }
}