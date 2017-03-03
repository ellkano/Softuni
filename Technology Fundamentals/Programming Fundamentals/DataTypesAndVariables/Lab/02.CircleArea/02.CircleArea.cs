using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * n * n;

            Console.WriteLine("{0:f12}", circleArea);
        }
    }
}
