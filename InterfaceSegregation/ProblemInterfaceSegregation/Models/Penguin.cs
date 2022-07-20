using ProblemInterfaceSegregation.Models.Interface;

namespace ProblemInterfaceSegregation.Models
{
    public class Penguin : IBird
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
        public void Fly()
        {
            throw new NotImplementedException();
        }
        public void Glide()
        {
            throw new NotImplementedException();
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
