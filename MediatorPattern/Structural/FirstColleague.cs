using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Structural
{
    public class FirstColleague : Colleague
    {
        public FirstColleague(Mediator mediator) : base(mediator) {}

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"First colleague notified with: \"{message}\"");
        }
    }
}
