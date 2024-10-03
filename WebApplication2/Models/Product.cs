using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fabric { get; set; }
        public string  Color { get; set; }
        public int Quentity { get; set; }
        public string Unitprice { get; set; }
        public string Description { get; set; }
        public Catagory Catagory { get; set; }


    }
}