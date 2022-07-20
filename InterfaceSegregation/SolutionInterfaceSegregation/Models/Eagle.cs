using ProblemInterfaceSegregation.Models.Interface;

namespace ProblemInterfaceSegregation.Models
{
    public class Eagle : IFlyingBird
    {
        public double Weight { get; set; }
        public double Height { get; set; }

        public Eagle(double weight, double height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        public void Eat()
        {
            Console.WriteLine("Eagle eat something.");
        }

        public void Fly()
        {
            Console.WriteLine("Eagle start to fly.");
        }
        public void Glide()
        {
            Console.WriteLine("Eagle start to Glide.");
        }
        public void Jump()
        {
            Console.WriteLine("Eagle start to Jump.");
        }
        public void Run()
        {
            Console.WriteLine("Eagle start to Run.");
        }
    }
}
