namespace ProblemLiskovSubstitution.Models
{
    public abstract class Bird
    {
        protected double Weight;
        protected double Height;

        public abstract void Fly();
        public abstract void Eat();
    }
}
