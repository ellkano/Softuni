using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string intSign = IntegerSign(x);

            Console.WriteLine("The number {0} is {1}.", x, intSign);

        }

        static string IntegerSign(int num)
        {
            string sign = null;

            if (num < 0)
            {
                sign = "negative";
            }

            else if (num > 0)
            {
                sign = "positive";
            }

            else
            {
                sign = "zero";
            }

            return sign;
        }
    }
}
