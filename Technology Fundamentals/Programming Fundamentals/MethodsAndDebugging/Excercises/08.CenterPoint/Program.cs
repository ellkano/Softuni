using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPodouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintNearestPoint(x1, y1, x2, y2);
        }

        private static void PrintNearestPoint(double x1, double y1, double x2, double y2)
        {
            double distanceOne = NearestPoint(x1, y1);
            double distanceTwo = NearestPoint(x2, y2);

            if (distanceOne<=distanceTwo)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }

            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }

        public static double NearestPoint(double x1, double y1)
        {
            double distanceToZero = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return distanceToZero;
        }
    }
}
