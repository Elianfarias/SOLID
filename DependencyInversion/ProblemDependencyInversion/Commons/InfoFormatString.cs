using ProblemDependencyInversion.Models;

namespace ProblemDependencyInversion.Commons
{
    public static class InfoFormatString
    {
        public static string GetAllProducts(IList<Product> products)
        {
            var productsOutput = "** Listado de productos ** \n";

            foreach (var product in products)
            {
                productsOutput += "\n***************************************\n"
                                + "Nombre: " + product.Name + "\n"
                                + "Descripción: " + product.Description + "\n"
                                + "Precio: $" + product.Price + "\n"
                                + "Categoria: $" + product.Category + "\n";
            }

            return productsOutput;
        }
    }
}
