using Newtonsoft.Json;
using ProblemDependencyInversion.Models;

namespace ProblemDependencyInversion.Commons
{
    public static class InfoFormatJson
    {
        public static string GetAllProducts(IList<Product> products) => JsonConvert.SerializeObject(products);
    }
}
