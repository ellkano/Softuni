using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.SrubskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> concert = new Dictionary<string, Dictionary<string, long>>();

            string pattern = @"(.*?) @(.*?) (\d+) (\d+)";

            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var match = Regex.Match(input, pattern);

                string singerName = match.Groups[1].Value;
                string venue = match.Groups[2].Value;
                int tickets = int.Parse(match.Groups[3].Value);
                int numberOfTickets = int.Parse(match.Groups[4].Value);

                long sum = (long)tickets * numberOfTickets;

                if (!concert.ContainsKey(venue))
                {
                    concert[venue] = new Dictionary<string, long>();
                }


                Dictionary<string, long> singers = new Dictionary<string, long>();

                if (!concert[venue].ContainsKey(singerName))
                {
                    concert[venue][singerName] = 0;
                }
                concert[venue][singerName] += sum;


                input = Console.ReadLine();
            }

            foreach (var item in concert)
            {
                Console.WriteLine(item.Key);
                var artist = item.Value;
                foreach (var pair in artist.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", pair.Key, pair.Value);
                }
            }
        }
    }
}
