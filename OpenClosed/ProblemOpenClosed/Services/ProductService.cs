using Newtonsoft.Json;
using ProblemOpenClosed.Models;
using ProblemOpenClosed.Services.Interface;

namespace ProblemOpenClosed.Services
{
    public class ProductService : IProductService
    {
        public string PrintAllProducts(IList<Product> products)
        {
            var productsOutput = "** Listado de productos ** \n";

            foreach (var product in products)
            {
                var price = "";

                if (product.Category == "Pharmacy")
                    price = (product.Price * 1.10).ToString();
                else
                    price = product.Price.ToString();

                productsOutput += "\n***************************************\n" 
                                + "Nombre: " + product.Name + "\n"
                                + "Descripción: " + product.Description + "\n"
                                + "Precio: $" + price + "\n";
            }

            return productsOutput;
        }
    }
}
