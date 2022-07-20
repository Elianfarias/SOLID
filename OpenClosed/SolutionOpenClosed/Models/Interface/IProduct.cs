namespace SolutionOpenClosed.Models.Interface
{
    public interface IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double GetPrice();
    }
}
