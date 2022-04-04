using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions__Indexer.Models
{
    class Hotel
    {
        private Room[] Rooms = new Room[0];
        public string Name;

        public void AddRoom(Room rooms)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = rooms;
        }
        public Room this[int index]
        {
            get
            {
                return Rooms[index];
            }
            set
            {
                Rooms[index] = value;
            }
        }
        public Hotel(string name)
        {
            this.name = name;
        }
        
        }
    }

