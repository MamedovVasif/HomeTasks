using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musiqi.Models
{
    class Song
    {
        private string _Name;
        private string _Genre;
        private string _Singer;
        string[] Deyer = { "Pop", "Rock", "Jazz" };

    public string Name { get { return _Name; } set { if (_Name.Length <= 100) { Name = value; } } }
        public string Genre { get { return _Genre; } set { if (_Genre.Length <= 100) { Genre = value; } } }
        public string Singer { get { return _Singer; } set { if (_Singer.Length <= 100) { Singer = value; } } }
    }
}
