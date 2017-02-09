using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> userData = new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string ipAddress = input[0];
                string username = input[1];
                int duration = int.Parse(input[2]);

                if (!userData.ContainsKey(username))
                {
                    //Dictionary<string, int> ipDuration = new Dictionary<string, int>();

                    userData.Add(username, new SortedDictionary<string, int>());
                }

                if (!userData[username].ContainsKey(ipAddress))
                {
                    userData[username].Add(ipAddress, duration);
                }

                else
                {
                    userData[username][ipAddress] += duration;
                }
            }


            foreach (var item in userData)
            {
                string name = item.Key;
                int sum = item.Value.Values.Sum();
                List<string> ips = item.Value.Keys.ToList();

                Console.WriteLine("{0}: {1} [{2}]", name, sum, String.Join(", ", ips));
            }
        }
    }
}
