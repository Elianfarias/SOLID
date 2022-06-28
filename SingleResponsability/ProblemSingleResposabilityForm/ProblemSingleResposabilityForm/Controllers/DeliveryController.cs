using Microsoft.AspNetCore.Mvc;
using ProblemSingleResponsability.Models;

namespace ProblemSingleResponsability.Controllers
{
    public class DeliveryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct(string name, float price)
        {
            var product = new Product(name, price);

            product.AddProduct();
            
            return Ok();
        }
    }
}