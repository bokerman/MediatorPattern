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
        public FirstColleague FirstColleague { get; set; }
        public SecondColleague SecondColleague { get; set; }
        public List<Colleague> ColleagueList => new List<Colleague> { FirstColleague, SecondColleague };

        public override void Send(string message, Colleague sender)
        {
            foreach (var listener in ColleagueList)
            {
                if(listener != sender)
                    listener.HandleNotification(message);
            }
        }
    }
}
