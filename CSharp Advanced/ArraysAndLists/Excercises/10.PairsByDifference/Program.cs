using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {

                    int difference = Math.Abs(numbers[i] - numbers[j]);

                    if (difference == n)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
