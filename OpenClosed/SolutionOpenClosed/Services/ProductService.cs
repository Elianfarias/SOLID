using SolutionOpenClosed.Models.Interface;
using SolutionOpenClosed.Services.Interface;

namespace SolutionOpenClosed.Services
{
    public class ProductService : IProductService
    {
        public string PrintAllProducts(IList<IProduct> products)
        {
            var productsOutput = "** Listado de productos ** \n";

            foreach (var product in products)
            {
                productsOutput += "\n***************************************\n"
                                + "Nombre: " + product.Name + "\n"
                                + "Descripción: " + product.Description + "\n"
                                + "Precio: $" + product.GetPrice() + "\n";
            }

            return productsOutput;
        }
    }
}
