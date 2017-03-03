using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];
            for (int i = 0; i < k; i++)
            {
                int lastNum = array[array.Length - 1];
                for (int j = 1; j < array.Length; j++)
                {
                    array[array.Length - j] = array[array.Length - 1 - j];
                }

                array[0] = lastNum;

                for (int l = 0; l < array.Length; l++)
                {
                    sum[l] += array[l];
                }

            }
            Console.WriteLine(string.Join(" ", sum));
           
        }
    }
}
