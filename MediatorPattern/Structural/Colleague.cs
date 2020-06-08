using System.Xml.Serialization;

namespace MediatorPattern.Structural
{
    public abstract class Colleague
    {
        private Mediator _mediator;

        internal void SetMediator(Mediator mediator)
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