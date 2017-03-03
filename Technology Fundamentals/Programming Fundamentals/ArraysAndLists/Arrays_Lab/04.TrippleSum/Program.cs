using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrippleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            int[] numbers = new int[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                numbers[i] = int.Parse(text[i]);
            }
            bool sumFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] == numbers[k])
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            sumFound = true;
                            break;
                        }

                    }
                }
            }
            if (!sumFound)
            {
                Console.WriteLine("No");
            }

        }
    }
}
