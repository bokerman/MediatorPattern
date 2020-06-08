using System;
using MediatorPattern.Structural;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var firstColleague = mediator.CreateColleague<FirstColleague>();
            var secondColleague = mediator.CreateColleague<SecondColleague>();

            firstColleague.Send("Hello world from the First Colleague");
            secondColleague.Send("Hello world from the Second Colleague");

            Console.ReadKey();
        }
    }
}
