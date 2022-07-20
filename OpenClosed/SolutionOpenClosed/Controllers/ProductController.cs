using SolutionOpenClosed.Models;
using SolutionOpenClosed.Models.Interface;
using SolutionOpenClosed.Services.Interface;

namespace SolutionOpenClosed.Controllers
{
    public class ProductController
    {
        private readonly IProductService productService;
        public IList<IProduct> products;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
            this.products = new List<IProduct>();

            products.Add(new Food("Coffee", "This is a coffee", 100));
            products.Add(new Pharmacy("shampoo", "This is a shampoo", 10));
        }

        public string PrintAllProducts()
        {
            return productService.PrintAllProducts(products);
        }
    }
}
