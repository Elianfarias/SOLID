namespace ProblemSingleResponsability.Models.Database
{
    public class Database
    {
        private static List<Product> Products { get; set; } = new List<Product>();

        public static List<Product> GetProducts() => Products;

        public static void AddProduct(Product product)
        {
            //it is simulated that it is inserted into the database;
            Products.Add(product);
        }
    }
}
