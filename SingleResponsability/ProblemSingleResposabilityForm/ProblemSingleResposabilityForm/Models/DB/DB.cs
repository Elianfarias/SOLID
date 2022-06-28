namespace ProblemSingleResponsability.Models.DB
{
    public class Database
    {
        public void AddProductDB(Product product)
        {
            // add To DB
            Console.WriteLine("Se ha insertado el producto: " + product.Name);
        }
    }
}
