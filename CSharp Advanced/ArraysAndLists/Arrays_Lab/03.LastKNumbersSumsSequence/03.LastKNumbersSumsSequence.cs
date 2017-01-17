using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            // int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] elements = new int[n];


            elements[0] = 1;

            Console.WriteLine(NextNumber(elements));


        }

        static int NextNumber(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i - 1]; 
            }

            return sum;
        }
    }
}
