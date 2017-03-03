using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int firstMax = MaxOfTwo(n1, n2);
            int secondMax = MaxOfTwo(firstMax, n3);

            Console.WriteLine(secondMax);
        }

        public static int MaxOfTwo(int n1, int n2)
        {
            return Math.Max(n1, n2);
        }
    }
}
