using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            FigureArea(text);

        }

        private static void FigureArea(string text)
        {
            if (text == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                TriangleArea(side, height);
            }

            else if (text == "square")
            {
                double side = double.Parse(Console.ReadLine());
                SquareArea(side);
            }

           else if (text == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                RectangleArea(width, height);
            }

           else
            {
                double radius = double.Parse(Console.ReadLine());
                CircleArea(radius);
            }

        }

        private static void CircleArea(double radius)
        {
            Console.WriteLine("{0:f2}", Math.Pow(radius, 2)*Math.PI);
        }

        private static void SquareArea(double side)
        {
            Console.WriteLine("{0:f2}", Math.Pow(side, 2));
        }

        private static void TriangleArea(double side, double height)
        {
            Console.WriteLine("{0:f2}", side * height/2);
        }
        private static void RectangleArea(double width, double height)
        {
            Console.WriteLine("{0:f2}", width * height);
        }
    }
}
