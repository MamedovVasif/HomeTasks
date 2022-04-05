using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Up_Down_Casting.Models
{
    class USD
    {
        public double Amount { get; set; }
        public USD(double Amount)
        {
            this.Amount = Amount;
        }

        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount * 1.7);
        }

        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount / 1.7);
        }

        public static bool operator >(USD u, AZN a)
        {
            return u.Amount > a.Amount;
        }
        public static bool operator <(USD u, AZN a)
        {
            return u.Amount < a.Amount;
        }
    }
}
