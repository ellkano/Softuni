using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());

            double area = TriangleArea(baseTriangle, heightTriangle);

            Console.WriteLine(area);
        }

        static double TriangleArea(double baseTrianglex, double heightTriangley)
        {
            double area = baseTrianglex * heightTriangley / 2;
            return area;
        }
    }
}
