using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            int currentPosition = 0;
            int currentNumber = numbers[0];
            int counter = 1;
            int maxCounter = 1;

            for (int i = currentPosition; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;

                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        currentNumber = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                    currentPosition = i + 1;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(currentNumber + " ");
            }
            Console.WriteLine();
        }
    }
}
