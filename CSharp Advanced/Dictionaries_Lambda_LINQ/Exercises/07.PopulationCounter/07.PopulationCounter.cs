using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> countryReport = new Dictionary<string, Dictionary<string, int>>();

            while (!input.Equals("report"))
            {
                List<string> firstSplit = input.Split('|').ToList();
                string country = firstSplit[1];
                string city = firstSplit[0];
                int count = int.Parse(firstSplit[2]);


                if (!countryReport.ContainsKey(country))
                {
                    //Dictionary<string, int> cityReport = new Dictionary<string, int>();

                    //cityReport[city] = count;
                    //countryReport[country] = cityReport;

                    countryReport.Add(country, new Dictionary<string, int>());

                }

                countryReport[country].Add(city, count);

                //else
                //{
                //    if (!countryReport[country].ContainsKey(city))
                //    {
                //        countryReport[country][city] = count;

                //    }

                //    else
                //    {
                //        countryReport[country][city] += count;
                //    }

                //}


                input = Console.ReadLine();
            }


            Dictionary<string, long> finalDict = new Dictionary<string, long>(); // long, защото int-a превърта за големи стойности

            foreach (var item in countryReport)
            {
                string name = item.Key;
                foreach (var count in item.Value)
                {
                    if (!finalDict.ContainsKey(name))
                    {
                        finalDict.Add(name, count.Value);
                    }
                    else
                    {
                        finalDict[name] += count.Value;
                    }
                    
                }

            }


            foreach (var pair in finalDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value);

                foreach (var towns in countryReport[pair.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", towns.Key, towns.Value);
                }
            }

        }
    }
}
