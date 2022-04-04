using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions__Indexer.Models
{
    class NotAvailableException:Exception
    {
        public NotAvailableException() : base("Not Available")
        { }
        public NotAvailableException(string message) : base(message)
        { }
    }
}
