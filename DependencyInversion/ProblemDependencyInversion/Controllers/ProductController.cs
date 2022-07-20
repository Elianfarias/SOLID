using ProblemDependencyInversion.Models;
using ProblemDependencyInversion.Services.Interface;

namespace ProblemDependencyInversion.Controllers
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

        public string GetAllProducts(bool outputFormatJson)
        {
            return productService.GetAllProducts(products, outputFormatJson);
        }
    }
}
