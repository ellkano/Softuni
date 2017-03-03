using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];

            for (int i = 97; i <= 122; i++)
            {
                alphabet[i - 97] = (char)i;
            }

            string input = Console.ReadLine().ToLower();

            foreach (char letter in input)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (letter == alphabet[i])
                    {
                        Console.WriteLine("{0} -> {1}", letter, i);
                    }
                }
            }
        }
    }
}
