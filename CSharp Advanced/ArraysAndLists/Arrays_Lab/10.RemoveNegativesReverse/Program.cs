using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RemoveNegativesReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split();
            int[] numbers = new int[inputNumbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(inputNumbers[i]);
            }

            List<int> nonNegatives = new List<int>();

            foreach (int number in numbers)
            {
                if (number>=0)
                {
                    nonNegatives.Add(number);
                }
            }

            nonNegatives.Reverse();
            if (nonNegatives.Count>0)
            {
                Console.WriteLine(string.Join(" ", nonNegatives));
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
