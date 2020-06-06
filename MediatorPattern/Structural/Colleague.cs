namespace MediatorPattern.Structural
{
    public abstract class Colleague
    {
        private readonly Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }   

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}