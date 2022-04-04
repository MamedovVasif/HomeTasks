using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions__Indexer.Models
{
    class NotFoundException:Exception
    {
        public NotFoundException() : base("Not Found")
        { }
        public NotFoundException(string message) : base(message)
        { }
    }
}
