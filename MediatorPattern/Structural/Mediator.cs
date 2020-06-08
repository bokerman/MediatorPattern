namespace MediatorPattern.Structural
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
        public abstract void RegisterColleague(Colleague colleague);
    }
}
