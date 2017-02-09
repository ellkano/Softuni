using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input != "END")
            {
                List<string> holder = input.Split().ToList();

                if (holder[0] == "A")
                {
                    phonebook[holder[1]] = holder[2];
                }

                else
                {
                   if (phonebook.ContainsKey(holder[1]))
                        {
                        string name = holder[1];
                        string value = phonebook[holder[1]];
                        Console.WriteLine("{0} -> {1}", name, value);

                        // долните две са същите

                        //string name = holder[1];
                        //Console.WriteLine("{0} -> {1}", name, phonebook[name]);

                        // или

                        //string name = holder[1];
                        //Console.WriteLine("{0} -> {1}", name, phonebook[holder[1]);


                    }

                    else
                        {
                            Console.WriteLine("Contact {0} does not exist.", holder[1]);
                        }
                    }

                    
               
                input = Console.ReadLine();
            }
        }
    }
}
