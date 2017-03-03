using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                List<string> holder = input.Split().ToList();

                if (holder[0] == "A")
                {
                    phonebook[holder[1]] = holder[2];
                }

                else if (holder[0] == "S")
                {
                    if (phonebook.ContainsKey(holder[1]))
                    {
                        string keyString = holder[1];
                        Console.WriteLine("{0} -> {1}", keyString, phonebook[keyString]);
                    }

                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", holder[1]);
                    }
                }

                else
                {
                    foreach (KeyValuePair<string, string> namesNumbers in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", namesNumbers.Key, namesNumbers.Value);
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
