using ProblemInterfaceSegregation.Models.Interface;

namespace ProblemInterfaceSegregation.Models
{
    public class Penguin : ISwimmingBird
    {
        public double Weight { get; set; }
        public double Height { get; set; }

        public Penguin(double weight, double height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        public void Eat()
        {
            Console.WriteLine("Penguin eat something.");
        }
        public void Jump()
        {
            Console.WriteLine("Penguin start to Jump.");
        }
        public void Run()
        {
            Console.WriteLine("Penguin start to Run.");
        }
        public void Swim()
        {
            Console.WriteLine("Penguin start to Swim.");
        }
    }
}
