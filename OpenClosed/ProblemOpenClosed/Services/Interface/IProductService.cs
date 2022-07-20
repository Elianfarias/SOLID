using ProblemOpenClosed.Models;

namespace ProblemOpenClosed.Services.Interface
{
    public interface IProductService
    {
        public string PrintAllProducts(IList<Product> products);
    }
}
