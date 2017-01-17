using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefacorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {

                bool isSpecial = false;
                int sum = 0;
                int number = i;

                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                if ((sum == 5) || (sum == 7) || (sum == 11))
                {
                    isSpecial = true;
                } 
                Console.WriteLine($"{i} -> {isSpecial}");
                
            }

        }
    }
}
