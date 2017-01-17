using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            DrawFigure(x);

        }

        static void UpperPart(int x)
        {
            Console.WriteLine(new string('-', 2 * x));
        }
        static void MiddlePart(int x)
        {
            for (int i = 0; i < x - 2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < x-1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        static void DrawFigure(int x)
        {
            UpperPart(x);
            MiddlePart(x);
            UpperPart(x);
        }
    }
}
