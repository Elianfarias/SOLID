using SolutionDependencyInversion.Models;

namespace SolutionDependencyInversion.Commons.Interface
{
    public interface IInfo
    {
        public string GetAllProducts(IList<Product> products);
    }
}
