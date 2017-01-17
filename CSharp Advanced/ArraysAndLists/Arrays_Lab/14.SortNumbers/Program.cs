using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(x=>decimal.Parse(x)).ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
