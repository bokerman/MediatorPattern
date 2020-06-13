using System;
using MediatorPattern.Structural;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new TeamChatRoom();
            
            // Create developers
            var johnny = new Developer("Johnny");
            var brandon = new Developer("Brandon");
            var david = new Developer("David");

            // Create testers
            var michael = new Tester("Michael");
            var peter = new Tester("Peter");
            var alex = new Tester("Alex");

            
            chatRoom.RegisterTeamMembers(johnny, brandon, david, michael, peter, alex);

            johnny.Send("I did it!");
            michael.Send("Ok guys, let's test the crap out or it");
            brandon.SendTo<Developer>("Hopefully Johnny nailed it!");

            Console.ReadKey();
        }
    }
}
