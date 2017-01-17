using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyEvensOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                n = Math.Abs(n);
            }

            MultipliyEvenOdds(n);
        }

        public static int SumOfOdd(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int last = n % 10;

                if (last % 2 != 0)
                {
                    sum += last;
                }
                n = n / 10;

            }

            return sum;
        }

        public static int SumOfEven(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int last = n % 10;

                if (last % 2 == 0)
                {
                    sum += last;
                }
                n = n / 10;
            }
            return sum;
        }

        public static void MultipliyEvenOdds(int n)
        {
            int n1 = SumOfEven(n);
            int n2 = SumOfOdd(n);

            Console.WriteLine(n1 * n2);

        }
    }
}
