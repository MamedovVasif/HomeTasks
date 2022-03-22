using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apps1.Classlar
{
    class MotoredVehicle
    {
        public string model;
        public string make;
        public string productionyear;
        public string motorsize;
        public string fueltanksize;
        public double FuelUsedPerKm;
        public string Color;
        public string Transmission;
        public string HorsePower;
        public string PassangerCount;
        public double Fuel;
        
        public MotoredVehicle()
        {

        }
        public MotoredVehicle(string model,string make,string productionyear)
        {
            this.model = model;
            this.make = make;
            this.productionyear = productionyear;

        }
          public void GetInfo()
        {
            Console.WriteLine(model, make, productionyear);
        }

        public virtual void GetDetailedInfo()
        {
            Console.WriteLine(PassangerCount, HorsePower, Transmission, Color, FuelUsedPerKm, fueltanksize, motorsize, productionyear, make, model);
        }
    }
}
