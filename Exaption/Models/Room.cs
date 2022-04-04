using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions__Indexer.Models
{
    class Room
    {
        private static int _id;
        public int Id { get; set; }
        public int IdAdd()
        {
            _id++;
            return _id;
        }


        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable = true; 

        public string ShowInfo()
        {
            return Name + "---" + Price + "---" + PersonCapacity + "---" + IsAvailable ;
        }
        public Room(string name, double price,int personcapasity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personcapasity;
            Id = IdAdd();
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
