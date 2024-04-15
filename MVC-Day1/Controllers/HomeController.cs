using Microsoft.AspNetCore.Mvc;
using MVC_Day1.Models;

namespace MVC_Day1.Controllers
{
    public class HomeController:Controller
    {
        private static List<Product> products = new List<Product> 
        {
        new Product { Id = 1, Name = "Product 1", Price = 9.99 },
        new Product { Id = 2, Name = "Product 2", Price = 5.49 },
        new Product { Id = 3, Name = "Product 3", Price = 15.99 }
        };


        public ViewResult Index()
        {
            ViewBag.Products = products;
            return View(products);
        }

        public ViewResult Detail(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);

            ViewBag.Product = product;


            return View(product);
        }
    }
}
