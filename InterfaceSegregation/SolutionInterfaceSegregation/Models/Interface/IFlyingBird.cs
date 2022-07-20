namespace ProblemInterfaceSegregation.Models.Interface
{
    public interface IFlyingBird : IBird
    {
        public void Fly();
        public void Glide();
    }
}
