using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public static class PowerExtension
    {
        public static int PowerEXT(this int num1)
        {
            int result = 1;
            for (int i = 2; i <=num1; i++)
            {
              result=  num1 * num1;
            }
            return result;
        }
    }
}
