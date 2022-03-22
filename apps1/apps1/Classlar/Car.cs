using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps1.Classlar
{
    class Car : MotoredVehicle
    {
        //public car(string model, string make, string productionyear) : base()
        //{

        //}

        public bool Ison;

        public void TurnOn()
        {
            Ison = true;
            Console.WriteLine("masin ise salindi");
        }
        public void TurnOff()
        {
            Ison = false;
            Console.WriteLine("masin sonduruldu");
        }
        public void Go() {
            if (Ison == false)
            {
                Console.WriteLine("1 duymesini sixin ise salmaq ucun");
                string button = Console.ReadLine();
                if (button == "1")
                {
                    Console.WriteLine("ise salindi");
                }
                else
                {
                    Console.WriteLine("duzgun duymeni basmadigin ucun mator yandi");
                    return;
                }
            }
            Console.WriteLine("Distance'i qeyd edin");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bir kmya serf olunna benzini girin");
            FuelUsedPerKm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ne qeder benzininiz var ?");
            Fuel = Convert.ToDouble(Console.ReadLine());
            if (distance * FuelUsedPerKm <= Fuel)
            {
                Console.WriteLine(distance + "Mesafe qet edildi");
            }
            else
            {
                Console.WriteLine("Kifayət qədər yanacaq yoxdur");
            }
        }
        
        public override void GetDetailedInfo() 
        {

        }
    }
}
