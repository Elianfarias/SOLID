namespace ProblemLiskovSubstitution.Models
{
    public class Eagle : Bird
    {
        public Eagle(double weight, double height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        public override void Eat()
        {
            Console.WriteLine("Eagle eat something.");
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle start to fly.");
        }
    }
}
