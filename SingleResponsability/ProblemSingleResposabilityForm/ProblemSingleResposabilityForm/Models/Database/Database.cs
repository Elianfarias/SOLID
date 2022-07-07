namespace ProblemSingleResponsability.Models.Database
{
    public class Database
    {
        private static List<Product> Products { get; set; } = new List<Product>();

        public static List<Product> GetProducts() => Products;

        public static void AddProduct(Product product)
        {
            // add To DB
            Products.Add(product);
        }
    }
}
