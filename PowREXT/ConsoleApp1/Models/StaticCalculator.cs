using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
   static class Calculator
    {
        public static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1,int num2)
        {
            return num1 - num2;
        }
        public static int Multiplay(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
