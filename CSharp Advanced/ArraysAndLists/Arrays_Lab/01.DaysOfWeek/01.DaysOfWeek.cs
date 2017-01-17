using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] arr2 = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n <= 7)
            {
                Console.WriteLine(arr2[n - 1]);
            }

            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}
