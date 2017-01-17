using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counterFinal = 0;
            int counterNow = 1;
            int numberNow = 0;
           
            if (array.Length == 1)
            {
                Console.Write(array[0]);
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counterNow++;

                    if (counterNow > counterFinal)
                    {
                        counterFinal = counterNow;
                        numberNow = array[i];
                    }

                }

                else
                {
                    
                    counterNow = 1;
                }
            }

            for (int i = 0; i < counterFinal; i++)
            {
                Console.Write($"{numberNow} ");
            }

            Console.WriteLine();



        }
    }
}
