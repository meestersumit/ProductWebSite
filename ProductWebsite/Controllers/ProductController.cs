using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductWebsite.Models;
using ProductWebsite.Services;

namespace ProductWebsite.Controllers
{
    public class ProductController : Controller
    {
        private readonly JsonFileProductService ProductService;
        public ProductController(JsonFileProductService productService)
        {
            ProductService = productService;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> Products = ProductService.GetProducts();
            return View("Product",Products);
        }
    }
}