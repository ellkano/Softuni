using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int>> finalResults = new Dictionary<string, SortedDictionary<string, int>>();

            string input = Console.ReadLine().ToLower();

            SortedDictionary<string, int> pairMaterials = new SortedDictionary<string, int>();
            pairMaterials["shards"] = 0;
            pairMaterials["fragments"] = 0;
            pairMaterials["motes"] = 0;

            //int neededPoints = 0;

            while (true)
            {
                string[] inputSplit = input.Split();

                for (int i = 0; i < inputSplit.Length - 1; i += 2)
                {
                    if (!pairMaterials.ContainsKey(inputSplit[i + 1]))
                    {
                        pairMaterials.Add(inputSplit[i + 1], 0);
                    }

                    pairMaterials[inputSplit[i + 1]] += int.Parse(inputSplit[i]);

                    if (pairMaterials["fragments"] >= 250 || pairMaterials["shards"] >= 250 || pairMaterials["motes"] >= 250)
                    {
                        break;
                    }

                }

                if (pairMaterials["shards"] >= 250 || pairMaterials["fragments"] >= 250 || pairMaterials["motes"] >= 250)
                {
                    break;
                }


                    input = Console.ReadLine().ToLower();
            }

            FirstDictData(finalResults, pairMaterials);

            foreach (var item in finalResults)
            {

                Dictionary<string, int> firstThree = new Dictionary<string, int>();
                Dictionary<string, int> others = new Dictionary<string, int>();


                Console.WriteLine("{0} obtained!", item.Key);

                FirstThreeMethod(pairMaterials, firstThree);
                

                foreach (var items in firstThree.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine("{0}: {1}", items.Key, items.Value);
                }

                OthersMethod(pairMaterials, others);
                foreach (var items in pairMaterials.OrderBy(x => x.Key))
                {
                    Console.WriteLine("{0}: {1}", items.Key, items.Value);
                }

            }
        }

        private static void OthersMethod(SortedDictionary<string, int> pairMaterials, Dictionary<string, int> others)
        {
            pairMaterials.Remove("shards");
            pairMaterials.Remove("fragments");
            pairMaterials.Remove("motes");
        }

        private static void FirstThreeMethod(SortedDictionary<string, int> pairMaterials, Dictionary<string, int> firstThree)
        {
            firstThree.Add("shards", pairMaterials["shards"]);
            firstThree.Add("fragments", pairMaterials["fragments"]);
            firstThree.Add("motes", pairMaterials["motes"]);
        }

        private static void FirstDictData(Dictionary<string, SortedDictionary<string, int>> finalResults, SortedDictionary<string, int> pairMaterials)
        {
            if (pairMaterials["shards"] >= 250)
            {
                pairMaterials["shards"] -= 250;

                finalResults["Shadowmourne"] = pairMaterials;
            }

            if (pairMaterials["fragments"] >= 250)
            {
                pairMaterials["fragments"] -= 250;

                finalResults["Valanyr"] = pairMaterials;
            }
            if (pairMaterials["motes"] >= 250)
            {
                pairMaterials["motes"] -= 250;

                finalResults["Dragonwrath"] = pairMaterials;
            }



            //Това отдолу е друго решение, по-кратко, ясно и добро


            //SortedDictionary<string, long> keyMaterials = new SortedDictionary<string, long>();
            //keyMaterials["shards"] = 0;
            //keyMaterials["motes"] = 0;
            //keyMaterials["fragments"] = 0;

            //SortedDictionary<string, long> junkMaterials = new SortedDictionary<string, long>();
            //bool isInput = true;

            //while (isInput)
            //{
            //    string[] materials = Console.ReadLine().ToLower().Split(' ').ToArray();

            //    for (int i = 0; i < materials.Length; i += 2)
            //    {
            //        long curentQuantiti = long.Parse(materials[i]);
            //        string curentMaterial = materials[i + 1];
            //        if (curentMaterial == "shards" || curentMaterial == "motes" || curentMaterial == "fragments")
            //        {
            //            keyMaterials[curentMaterial] += curentQuantiti;
            //        }
            //        else
            //        {
            //            if (!junkMaterials.ContainsKey(curentMaterial))
            //            {
            //                junkMaterials.Add(curentMaterial, 0);
            //            }
            //            junkMaterials[curentMaterial] += curentQuantiti;
            //        }

            //        if (keyMaterials["shards"] >= 250 || keyMaterials["motes"] >= 250 || keyMaterials["fragments"] >= 250)
            //        {
            //            foreach (var item in keyMaterials.OrderByDescending(x => x.Value))
            //            {
            //                switch (item.Key)
            //                {
            //                    case "motes":
            //                        Console.WriteLine("Dragonwrath obtained!");
            //                        keyMaterials[item.Key] -= 250;
            //                        break;
            //                    case "shards":
            //                        Console.WriteLine("Shadowmourne obtained!");
            //                        keyMaterials[item.Key] -= 250;
            //                        break;
            //                    case "fragments":
            //                        Console.WriteLine("Valanyr obtained!");
            //                        keyMaterials[item.Key] -= 250;
            //                        break;
            //                }
            //                break;
            //            }

            //            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            //            {
            //                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            //            }
            //            foreach (var item in junkMaterials)
            //            {
            //                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            //            }

            //            return;
            //        }
            //    }
            //}


            //////////////////////////////////////////////////////////////////////





            //Dictionary<string, int> resources = new Dictionary<string, int>();
            //SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            //resources.Add("shards", 0);
            //resources.Add("fragments", 0);
            //resources.Add("motes", 0);
            //bool notEnoughMaterial = true;
            //while (notEnoughMaterial)
            //{
            //    string[] command = Console.ReadLine().ToLower().Split(' ').ToArray();
            //    for (int i = 0; i < command.Length; i += 2)
            //    {
            //        int quantity = int.Parse(command[i]);
            //        string material = command[i + 1];
            //        if (resources.ContainsKey(material))
            //        {
            //            resources[material] += quantity;
            //            if (resources[material] >= 250)
            //            {
            //                resources[material] -= 250;
            //                string result = string.Empty;
            //                switch (material)
            //                {
            //                    case "shards": result = "Shadowmourne"; break;
            //                    case "fragments": result = "Valanyr"; break;
            //                    case "motes": result = "Dragonwrath"; break;
            //                }
            //                Console.WriteLine("{0} obtained!", result);
            //                notEnoughMaterial = false;
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            if (!junk.ContainsKey(material))
            //                junk.Add(material, 0);
            //            junk[material] += quantity;
            //        }
            //    }
            //}
            //var finalResources = resources.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            //foreach (var kvp in finalResources)
            //    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            //foreach (var kvp in junk)
            //    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);







        }
    }
}
