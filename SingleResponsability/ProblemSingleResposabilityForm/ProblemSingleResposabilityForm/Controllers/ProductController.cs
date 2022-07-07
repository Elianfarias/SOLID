using ProblemSingleResponsability.Models;
using ProblemSingleResponsability.Models.Database;

namespace ProblemSingleResponsability.Controllers
{
    public class ProductController
    {
        public ProductController()
        {
        }

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
    }
}