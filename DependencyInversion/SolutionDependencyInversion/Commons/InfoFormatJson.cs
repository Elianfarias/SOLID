using Newtonsoft.Json;
using SolutionDependencyInversion.Commons.Interface;
using SolutionDependencyInversion.Models;

namespace SolutionDependencyInversion.Commons
{
    public class InfoFormatJson : IInfo
    {
        public string GetAllProducts(IList<Product> products) => JsonConvert.SerializeObject(products);
    }
}
