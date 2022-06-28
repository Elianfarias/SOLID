using ProblemSingleResponsability.Models.DB;

namespace ProblemSingleResponsability.Models
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public void AddProduct()
        {
            var db = new Database();

            db.AddProductDB(this);
        }
    }
}