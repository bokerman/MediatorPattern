using System;
using MediatorPattern.Structural;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            
            var firstColleague = new FirstColleague();
            var secondColleague = new SecondColleague();
            
            mediator.RegisterColleague(firstColleague);
            mediator.RegisterColleague(secondColleague);

            firstColleague.Send("Hello world from the First Colleague");
            secondColleague.Send("Hello world from the Second Colleague");

            Console.ReadKey();
        }
    }
}
