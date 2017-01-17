using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            numbers.Sort();

            int count = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                
                if (i == numbers.Count - 1|| numbers[i] != numbers[i + 1])
                {
                    Console.WriteLine("{0} - {1}", numbers[i], count);
                   
                    count = 1;
                    
                }

                else
                {
                    count++;
                }



            }
        }
    }
}