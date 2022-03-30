using Program.Models;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("1. Square 2.Rectangular 0.Quit");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Console.WriteLine("Proqramdan cixilir");
                    break;
                case 1:
                    Square s1 = new Square(5);
                    s1.CalcArea();
                    break;
                case 2:
                    Rectangular r1 = new Rectangular(2, 5);
                    r1.CalcArea();
                    break;
                

            }
        }
    }
}
