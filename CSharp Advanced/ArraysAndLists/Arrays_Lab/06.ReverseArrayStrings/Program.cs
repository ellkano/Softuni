using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            string[] reversed = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - i - 1];
            }

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
