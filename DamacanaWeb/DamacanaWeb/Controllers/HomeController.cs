using DamacanaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DamacanaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Create an instance of product
            Product product1 = new Product()
            {
                Id = 1,
                Name = "Potion of Invisibility",
                Price = (decimal) 4.90
            };

            Product product2 = new Product()
            {
                Id = 1,
                Name = "Potion of Increased Magicka",
                Price = (decimal)4.90
            };

            Product product3 = new Product()
            {
                Id = 1,
                Name = "Potion of Cure Disease",
                Price = (decimal)4.90
            };


            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            //Send product to view engine
            return View(products);
        }

        [HttpPost]
        public ActionResult AddProduct()
        {
            Product product = new Product()
            {
                Name = "",
                Price = (decimal)0
            };

            return View(product);
        }

        public ActionResult SaveProduct(Product product)
        {
            ViewBag.Message = "SaveProduct worked sir...";
            
            return View(product);
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