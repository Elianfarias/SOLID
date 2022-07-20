using SolutionDependencyInversion.Commons.Interface;
using SolutionDependencyInversion.Models;

namespace SolutionDependencyInversion.Services.Interface
{
    public interface IProductService
    {
        public string GetAllProducts(IList<Product> products);
    }
}
