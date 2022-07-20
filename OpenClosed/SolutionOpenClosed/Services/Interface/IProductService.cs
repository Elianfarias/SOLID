using SolutionOpenClosed.Models.Interface;

namespace SolutionOpenClosed.Services.Interface
{
    public interface IProductService
    {
        public string PrintAllProducts(IList<IProduct> products);
    }
}