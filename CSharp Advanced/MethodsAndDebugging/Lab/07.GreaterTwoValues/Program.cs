using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            ReadConsole(text);

        }

        static void ReadConsole(string text)
        {

            if (text == "int")
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                GetMax(n1, n2);
            }

            else if (text == "char")
            {
                char c1 = char.Parse(Console.ReadLine());
                char c2 = char.Parse(Console.ReadLine());
                GetMax(c1, c2);
            }

            else
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                GetMax(text1, text2);
            }
        }

        static void GetMax(int x1, int x2)
        {
            if (x1 >= x2)
            {
                Console.WriteLine(x1);
            }

            else
            {
                Console.WriteLine(x2);
            }
        }
        static void GetMax(char c1, char c2)
        {
            if (c1 >= c2)
            {
                Console.WriteLine(c1);
            }

            else
            {
                Console.WriteLine(c2);
            }
        }
        static void GetMax(string text1, string text2)
        {
            if (text1.CompareTo(text2) >= 0)
            {
                Console.WriteLine(text1);
            }

            else
            {
                Console.WriteLine(text2);
            }
        }
    }
}
