namespace SolutionLiskovSubstitution.Models
{
    public class Penguin : Bird
    {
        public Penguin(double weight, double height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        public override void Eat()
        {
            Console.WriteLine("Penguin eat something.");
        }
    }
}
