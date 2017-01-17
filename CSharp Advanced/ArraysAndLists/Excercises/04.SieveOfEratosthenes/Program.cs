using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool[] nums = new bool[n + 1];

            //bool isPrime = true;

            nums[0] = false;
            nums[1] = false;
            for (int i = 2; i < nums.Length; i++)
            {
                nums[i] = true;
            }

            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[i] == true)
                {
                    Console.Write(i + " ");

                    for (int j = 2; j * i <= nums.Length-1; j++)
                    {
                        nums[i * j] = false;
                    }
                }
            }

            Console.WriteLine();
        }

    }
}

