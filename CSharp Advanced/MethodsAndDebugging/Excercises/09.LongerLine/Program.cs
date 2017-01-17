using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lengthOne = LengthOfLine(x1, y1, x2, y2);
            double lengthTwo = LengthOfLine(x3, y3, x4, y4);

            if (lengthOne>=lengthTwo)
            {
                PrintNearestPoint(x1, y1, x2, y2);
            }

            else
            {
                PrintNearestPoint(x3, y3, x4, y4);
            }

            
        }

        private static double LengthOfLine(double x1, double y1, double x2, double y2)
        {
            double lineLength = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return lineLength;
        }

        public static double NearestPoint(double x1, double y1)
        {
            double distanceToZero = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return distanceToZero;
        }

        private static void PrintNearestPoint(double x1, double y1, double x2, double y2)
        {
            double distanceOne = NearestPoint(x1, y1);
            double distanceTwo = NearestPoint(x2, y2);

            if (distanceOne <= distanceTwo)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }

            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
        }



    }
}
