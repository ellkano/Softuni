using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(x=>int.Parse(x)).OrderBy(x=>(x)).Reverse().Take(3).ToList();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
