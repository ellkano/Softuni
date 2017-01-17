using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();

            int[] nums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                nums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {nums[i]}");
            }
        }
    }
}
