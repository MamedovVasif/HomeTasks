using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    class Rectangular:Figure
    {
        private int _width;
        private int _length;
        public int width { get { return _width; } set { if (value > 0) { _width = value; } } }
        public int length { get { return _length; } set { if (value > 0) { _length = value; } } }
        public Rectangular(int width,int length)
        {
            this.width = width;
            this.length = length;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Rectangular metodu ise salinir");
        }
    }
}
