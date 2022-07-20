using SolutionOpenClosed.Models.Interface;

namespace SolutionOpenClosed.Models
{
    public class Pharmacy : IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public float Promo { get; set; }

        public Pharmacy(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public double GetPrice() => Price * Promo;

    }
}
