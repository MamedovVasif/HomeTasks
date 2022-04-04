using Exceptions__Indexer.Models;
using System;

namespace Exceptions__Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel h1 = new Hotel("Hilton");
            Room r1 = new Room("A", 120, 2);
            Room r2 = new Room("B", 240, 4);
            Room r3 = new Room("C", 550, 6);
            h1.AddRoom(r1);
            h1.AddRoom(r2);
            h1.AddRoom(r3);
            Console.WriteLine(r1.Id);
            Console.WriteLine(r2.Id);
            Console.WriteLine(r3.Id);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            
        }
    }
}
