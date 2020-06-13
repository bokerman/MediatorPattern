using System;

namespace MediatorPattern.Structural
{
    public class Tester: TeamMember
    {
        public Tester(string name) : base(name) {}

        public override void Receive(string @from, string message)
        {
            Console.Write($"{Name} ({typeof(Tester)}) has received ");
            base.Receive(@from, message);
        }
    }
}