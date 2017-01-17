using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintReverseNumber(text);


            //string input = Console.ReadLine();

            //Console.WriteLine(string.Join("", input.Reverse())); - Най-краткото решение


        }

        private static void PrintReverseNumber(string text)
        {
            char[] newString = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                newString[i] = text[text.Length - i - 1];
            }

            Console.WriteLine(String.Join("", newString));
        }
    }
}
