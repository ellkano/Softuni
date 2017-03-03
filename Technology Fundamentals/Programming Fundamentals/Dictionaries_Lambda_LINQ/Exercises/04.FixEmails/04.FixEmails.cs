using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 1;

            Dictionary<string, string> namesEmails = new Dictionary<string, string>();

            List<string> names = new List<string>();
            List<string> emails = new List<string>();

            while (input != "stop")
            {
                if (counter % 2 != 0)
                {
                    names.Add(input);
                }

                else
                {
                    emails.Add(input);
                }

                input = Console.ReadLine();
                counter++;
            }

            for (int i = 0; i < names.Count; i++)
            {
                namesEmails[names[i]] = emails[i];

            }

            foreach (KeyValuePair<string, string> pair in namesEmails)
            {
                if (!pair.Value.EndsWith(".us") && !pair.Value.EndsWith(".uk"))
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }



            }


        }
    }
}
