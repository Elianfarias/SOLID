using ProblemDependencyInversion.Models;
using ProblemDependencyInversion.Commons;
using ProblemDependencyInversion.Services.Interface;

namespace ProblemDependencyInversion.Services
{
    public class ProductService : IProductService
    {
        public string GetAllProducts(IList<Product> products, bool outputFormatJson) => outputFormatJson ? InfoFormatJson.GetAllProducts(products) : InfoFormatString.GetAllProducts(products);
    }
}
