using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural
{
    public class ConcreteMediator : Mediator
    {
        private readonly List<Colleague> _colleagueList = new List<Colleague>();

        public override void Send(string message, Colleague sender)
        {
            foreach (var listener in _colleagueList)
            {
                if(listener != sender)
                    listener.HandleNotification(message);
            }
        }

        public void RegisterColleague(Colleague colleague)
        {
            colleague.SetMediator(this);
            _colleagueList.Add(colleague);
        }
    }
}
