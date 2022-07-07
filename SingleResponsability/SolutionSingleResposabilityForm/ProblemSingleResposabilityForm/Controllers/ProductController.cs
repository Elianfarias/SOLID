using ProblemSingleResponsability.Models;
using ProblemSingleResponsability.Models.Database;
using ProblemSingleResposabilityForm.Controllers.DTO;
using ProblemSingleResposabilityForm.Services;

namespace ProblemSingleResponsability.Controllers
{
    public class ProductController
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices) => _productServices = productServices;


        public string GetProducts()
        {
            List<Product> products = Database.GetProducts();
            string productsString = "";

            foreach (var product in products)
            {
                productsString += "***************************************\n"
                                      + "Id: " + product.Name + "\n"
                                      + "Cantidad: " + product.Price + "\n";
            }

            return productsString;
        }

        public void AddProduct(ProductDto productDto)
        {
            Product product = new(productDto.Name, productDto.Price);

            _productServices.AddProduct(product);
        }
    }
}