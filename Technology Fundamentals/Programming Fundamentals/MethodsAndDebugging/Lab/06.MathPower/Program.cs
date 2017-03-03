using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            double numPow = MathPow(num, pow);
            Console.WriteLine(numPow);
        }

        public static double MathPow(double num, double pow)
        {
            double power = num;

            for (int i = 1; i < pow; i++)
            {
                power *= num;
            }
            return power;
        }
    }
}
