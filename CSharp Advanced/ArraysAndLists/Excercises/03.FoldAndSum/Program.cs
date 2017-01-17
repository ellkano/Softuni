using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = input.Length / 4;

            int[] left = new int[k];
            int[] right = new int[k];
            int[] bottomMiddle = new int[2 * k];

            int[] upperMiddle = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                left[i] = input[i];
            }

            for (int i = 0; i < k; i++)
            {
                right[i] = input[3 * k + i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                bottomMiddle[i] = input[k + i];
            }

            Array.Reverse(left);
            Array.Reverse(right);


            for (int i = 0; i < 2 * k; i++)
            {
                if (i < k)
                {
                    upperMiddle[i] = left[i];
                }

                if (i >= k)
                {
                    upperMiddle[i] = right[i - k];
                }
            }

            for (int i = 0; i < 2*k; i++)
            {
                bottomMiddle[i] += upperMiddle[i];
            }

            Console.WriteLine(string.Join(" ", bottomMiddle));





        }
    }
}
