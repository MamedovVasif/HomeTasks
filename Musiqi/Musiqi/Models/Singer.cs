using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musiqi.Models
{
    class Singer
    {
        private string _Name;
        private string _Surname;
        private int _Age;
        public string Name { get { return _Name; } set { if (_Name.Length <= 100) { Name = value; } } }
        public string Surname { get { return _Surname; } set { if (_Surname.Length <= 100) { Surname = value; } } }
        public int Age { get { return _Age; } set { if (_Age <= 170) { Age = value; } } }
    }
}
