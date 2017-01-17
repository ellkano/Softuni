using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());

            List<int> results = FindPrimesInRange(first, last);

            Console.WriteLine(string.Join(", ", results));
        }

        private static List<int> FindPrimesInRange(int first, int last)
        {
            List<int> primes = new List<int>();
            if (first == 0 )
            {
                first += 2;
            }
            if (first==1)
            {
                first++;
            }

            for (int i = first; i <= last; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}
