using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> finalDict = new Dictionary<string, List<string>>();

            while (!input.Equals("JOKER"))
            {
                List<string> allData = input.Split(':').ToList();

                char[] splitChars = new char[] { ',', ' ' };

                string name = allData[0];
                string[] cards = allData[1].Split(splitChars, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!finalDict.ContainsKey(name))
                {
                    finalDict[name] = new List<string>(cards);
                }

                finalDict[name].AddRange(cards);


                input = Console.ReadLine();
            }

            PrintPlayersScore(finalDict);

        }

        private static void PrintPlayersScore(Dictionary<string, List<string>> finalDict)
        {
            foreach (var player in finalDict)
            {
                string playerName = player.Key;
                List<string> playerCards = player.Value.Distinct().ToList();

                int sum = 0;

                foreach (var cards in playerCards)
                {

                    string lastElement = cards.Substring(cards.Length-1);
                    string firstElements = cards.Substring(0, cards.Length - 1);

                    int powerOfCard = PowerOfCard(firstElements);
                    int flashOfCard = FlashOfCard(lastElement);
                    sum += powerOfCard * flashOfCard;
                }
                Console.WriteLine("{0}: {1}", playerName, sum);
            }

            

        }

        private static int FlashOfCard(string lastElement)
        {
            switch (lastElement)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
            }
        }

        private static int PowerOfCard(string firstElements)
        {
            switch (firstElements)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
            }
        }
    }
}

