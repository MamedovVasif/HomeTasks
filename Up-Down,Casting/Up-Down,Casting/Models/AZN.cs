using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Up_Down_Casting.Models
{
    class AZN
    {
        public double Amount { get; set; }
        public AZN(double Amount)
        {
            this.Amount = Amount;
        }

        public static bool operator >(AZN a, USD u)
        {
            return a.Amount > (u.Amount * 1.7);
        }
        public static bool operator <(AZN a, USD u)
        {
            return a.Amount < (u.Amount * 1.7);
        }
    }
}
