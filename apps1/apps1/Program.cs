using apps1.Classlar;
using System;
namespace apps1
{
    class Program
    {
        static void Main(string[] args)
        {
            MotoredVehicle mv1 = new MotoredVehicle("Mercedes","eclass","2020");
            //Console.WriteLine(mv1.model);
            Car c1 = new Car();
            c1.Go();
        }
    }
}
