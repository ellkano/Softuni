using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintName(text);
        }

        private static void PrintName(string text)
        {
            Console.WriteLine($"Hello, {text}!");
        }
    }
}
