using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 0;
            int currentLength = 1;
            int currentNumber = numbers[0]; ;
            int startNumber = numbers[0];
           


            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    currentLength++;
                    
                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;
                    }

                }

                else
                {
                    currentNumber = numbers[i + 1];
                    currentLength = 1;
                }
            }

            for (int i = startNumber; i < maxLength; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
