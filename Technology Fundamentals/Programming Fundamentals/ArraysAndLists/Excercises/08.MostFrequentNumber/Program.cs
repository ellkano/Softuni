﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxFrequentNum = 0;

            int maxCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            maxFrequentNum = numbers[i];
                        }
                    }
                }
            }
            Console.WriteLine(maxFrequentNum);
            //Console.WriteLine(maxCounter);
        }
    }
}
