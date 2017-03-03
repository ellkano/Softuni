using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> results = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length < 5).Distinct().OrderBy(x => (x)).ToList();

            Console.WriteLine(String.Join(", ", results));

        }
    }
}
