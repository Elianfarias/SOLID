using ProblemDependencyInversion.Models;

namespace ProblemDependencyInversion.Services.Interface
{
    public interface IProductService
    {
        public string GetAllProducts(IList<Product> products, bool outputFormatJson);
    }
}
