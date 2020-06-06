namespace MediatorPattern.Structural
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);

    }
}
