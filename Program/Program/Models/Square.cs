using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    class Square:Figure
    {
        private int _side; 
        public int side { get { return _side; } set { if (value > 0){ _side = value; } } }
        public Square(int side)
        {
            this.side = side;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Square metodu ise salinir");
        }
    }
}
