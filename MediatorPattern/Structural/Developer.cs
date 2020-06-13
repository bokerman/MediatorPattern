using System;

namespace MediatorPattern.Structural
{
    public class Developer : TeamMember
    {
        public Developer(string name) : base(name) {}

        public override void Receive(string @from, string message)
        {
            Console.Write($"{Name} ({typeof(Developer)}) has received ");
            base.Receive(@from, message);
        }
    }
}