using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split().Select(char.Parse).ToArray();


            int minLength = Math.Min(first.Length, second.Length);

            bool firstIsBigger = false;
            bool secondIsBigger = false;

            for (int i = 0; i < minLength; i++)
            {
                if (first[i] > second[i])
                {
                    firstIsBigger = true;
                }

                else if (first[i] < second[i])
                {
                    secondIsBigger = true;
                }
                else if (first[i] == second[i])
                {
                    if (first.Length >= second.Length)
                    {
                        firstIsBigger = true;
                    }

                    else
                    {
                        secondIsBigger = true;
                    }
                }
                else
                {
                    break;
                }
            }


            if (firstIsBigger)
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));

            }

            else if (secondIsBigger)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));

            }
        }
    }
}
