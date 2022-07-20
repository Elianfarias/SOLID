using ProblemOpenClosed.Models;
using ProblemOpenClosed.Services.Interface;

namespace ProblemOpenClosed.Controllers
{
    public class ProductController
    {
        private readonly IProductService productService;
        public IList<Product> products;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
            this.products = new List<Product>();

            products.Add(new Product("Coffee","This is a coffee", 100, "Food"));
            products.Add(new Product("shampoo", "This is a shampoo", 10, "Pharmacy"));
        }

        public string PrintAllProducts()
        {
            return productService.PrintAllProducts(products);
        }
    }
}
