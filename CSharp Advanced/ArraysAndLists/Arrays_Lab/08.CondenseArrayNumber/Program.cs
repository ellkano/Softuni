using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            //int[] sum = new int[numbers.Length - 1];

           

            while (numbers.Length > 1)
            {
                int[] sum = new int[numbers.Length-1];
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = numbers[i] + numbers[i + 1];
                }
                numbers = sum;
            }


            Console.WriteLine(numbers[0]);

        }
    }
}
