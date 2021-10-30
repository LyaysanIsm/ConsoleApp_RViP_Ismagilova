using System;
using System.Linq;

namespace ConsoleApp_RViP_Ismagilova
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamport lamport = new Lamport();

            Event e1 = new Event(1, "First", null);
            Event e2 = new Event(2, "Second", 5);
            Event e3 = new Event(3, "Third", null);
            Event e4 = new Event(4, "Fourth", null);
            Event e5 = new Event(5, "Fifth", 3);
            Event e6 = new Event(6, "Sixth", null);
            Event e7 = new Event(7, "Seventh", 8);

            lamport.receive(e1);
            lamport.receive(e2);
            lamport.receive(e3);
            lamport.receive(e6);
            lamport.receive(e7);
            lamport.receive(e5);

            Console.WriteLine("All events: \n" + String.Join("", lamport.Events));

            Console.WriteLine(String.Format("Events ordered by time: \n{0}",
            String.Join("", lamport.Events.OrderBy(x => x.Clock.Value).ToList())));
        }
    }
}