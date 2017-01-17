using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            
            Console.WriteLine(ReversedSum(numbers));
           
        }

        private static int ReversedSum(int[] numbers)
        {
            List<int> sum = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int result = 0;
                while (numbers[i] > 0)
                {
                    result = result * 10 + numbers[i] % 10;
                    numbers[i] /= 10;
                }
                sum.Add(result);
            }
            return sum.Sum();

        }
    }
}
