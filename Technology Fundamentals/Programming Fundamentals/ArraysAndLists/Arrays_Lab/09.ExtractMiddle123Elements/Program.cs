using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddle123Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            ExtractMiddleElements(numbers);
        }

        private static void ExtractMiddleElements(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }

            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {numbers[numbers.Length/2-1]}, {numbers[numbers.Length / 2]} }}");
            }

            else if (numbers.Length % 2 != 0)
            {
                Console.WriteLine($"{{ {numbers[numbers.Length / 2-1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]} }}");
            }
        }
    }
}
