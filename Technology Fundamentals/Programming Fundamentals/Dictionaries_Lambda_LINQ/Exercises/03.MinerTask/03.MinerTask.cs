using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 1;

            //List<string> all = new List<string>();

            Dictionary<string, int> resources = new Dictionary<string, int>();

            List<int> numbers = new List<int>();
            List<string> products = new List<string>();


            while (input != "stop")
            {

                if (count % 2 != 0)
                {
                    products.Add(input);
                }

                else
                {
                    numbers.Add(int.Parse(input));
                }

                input = Console.ReadLine();
                count++;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (resources.ContainsKey(products[i]))
                {
                    resources[products[i]] += numbers[i];
                }

                else
                {
                    resources[products[i]] = numbers[i];
                }

                
            }



            foreach (KeyValuePair<string, int> pair in resources)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
