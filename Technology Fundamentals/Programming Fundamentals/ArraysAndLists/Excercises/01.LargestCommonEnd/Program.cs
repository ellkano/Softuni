using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            int counterLeft = 0;
            int counterRight = 0;

            int arrLength = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < arrLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    counterLeft++;
                }

                else
                {
                    break;
                }

            }

            for (int i = 0; i < arrLength; i++)
            {
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    counterRight++;
                }

                else
                {
                    break;
                }

            }

            Console.WriteLine(Math.Max(counterLeft, counterRight));
        }
    }
}
