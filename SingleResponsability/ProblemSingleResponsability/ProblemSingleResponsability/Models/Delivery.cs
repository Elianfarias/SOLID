namespace ProblemSingleResponsability.Models
{
    public class Delivery
    {
        public string Name { get; set; }
        public int Cellphone { get; set; }
        public List<Product> Products { get; set; }

        public Delivery(string name, int cellphone)
        {
            Name = name;
            Cellphone = cellphone;
            Products = new List<Product>();
        }
    }
}