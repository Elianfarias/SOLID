using SolutionDependencyInversion.Models;
using SolutionDependencyInversion.Commons;
using SolutionDependencyInversion.Services.Interface;
using SolutionDependencyInversion.Commons.Interface;

namespace SolutionDependencyInversion.Services
{
    public class ProductService : IProductService
    {
        readonly IInfo Info;
        
        public ProductService(IInfo info)
        {
            Info = info;
        }

        public string GetAllProducts(IList<Product> products) => Info.GetAllProducts(products);
    }
}
