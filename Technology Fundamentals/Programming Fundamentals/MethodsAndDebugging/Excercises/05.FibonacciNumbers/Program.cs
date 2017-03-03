using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FibonachiNumber(n);


        }
        public static void FibonachiNumber(int n)
        {
            int currentNumber = 1;

            if (n > 1)
            {
                int firstN = 1;
                int secondN = 1;
                for (int i = 2; i <= n; i++)
                {
                    currentNumber = firstN + secondN;
                    firstN = secondN;
                    secondN = currentNumber;
                }
            }

            Console.WriteLine(currentNumber);
        }
    }
}
