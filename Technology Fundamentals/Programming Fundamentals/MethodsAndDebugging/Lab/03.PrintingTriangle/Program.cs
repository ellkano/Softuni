using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            PrintTriangle(x);

        }

        static void PrintTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= x - 1; i++)
            {
                for (int j = 1; j <= x-i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }

        }

    }

}

