using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> typeOfDragons = new Dictionary<string, Dictionary<string, List<int>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];
                //string damage = input[2];
                //string health = input[3];
                //string armor = input[4];

                List<int> amunitions = new List<int>();
                int damage = 0;
                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(input[2]);
                }
                amunitions.Add(damage);

                int health = 0;
                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(input[3]);
                }
                amunitions.Add(health);

                int armor = 0;
                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(input[4]);
                }
                amunitions.Add(armor);


                if (!typeOfDragons.ContainsKey(type))
                {
                    typeOfDragons[type] = new Dictionary<string, List<int>>();
                }

                //Dictionary<string, List<int>> nameOfDragons = new Dictionary<string, List<int>>();

                if (!typeOfDragons[type].ContainsKey(name))
                {
                    typeOfDragons[type][name] = new List<int>();
                }
                typeOfDragons[type][name] = amunitions;


            }


            foreach (var item in typeOfDragons)
            {
                var average1 = item.Value.Values.Average(x => x[0]);
                var average2 = item.Value.Values.Average(x => x[1]);
                var average3 = item.Value.Values.Average(x => x[2]);

                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", item.Key, average1, average2, average3);

                var dragon = item.Value;

                foreach (var pair in dragon.OrderBy(x => x.Key))
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", pair.Key, pair.Value[0], pair.Value[1], pair.Value[2]);
                }
            }
        }
    }
}
