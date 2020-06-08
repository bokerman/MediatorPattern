using System;

namespace MediatorPattern.Structural
{
    public class SecondColleague : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Second colleague notified with: \"{message}\"");
        }
    }
}