using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrInt = new int[n];
            int[] reverseArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrInt[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                reverseArray[i - 1] = arrInt[n - i];
            }

            foreach (var item in reverseArray)
            {
                Console.WriteLine("{0} ", item);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(reverseArray[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
