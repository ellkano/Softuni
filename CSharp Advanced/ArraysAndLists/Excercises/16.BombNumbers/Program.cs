using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = input[0];
            int strengthIndex = input[1];

            RemoveElements(numbers, bombNumber, strengthIndex);

            int sum = numbers.Sum();


            Console.WriteLine(sum);


        }

        private static void RemoveElements(List<int> numbers, int bombNumber, int strengthIndex)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int startIndex = Math.Max(i - strengthIndex, 0);
                    int endIndex = Math.Min(i + strengthIndex, numbers.Count - 1);
                    numbers.RemoveRange(startIndex, (endIndex - startIndex + 1));
                    i = 0;
                }
                
            }

        }
    }
}
