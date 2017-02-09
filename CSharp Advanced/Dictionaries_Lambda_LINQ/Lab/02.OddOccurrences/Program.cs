using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string word in text)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result[word] = 1;
                }
            }


            //Отдолу е кодът, който го показа Иво Кенов
            //foreach (string word in text)
            //{
            //    if (!result.ContainsKey(word))
            //    {
            //        result[word] = 0;
            //    }
            //    result[word]++;

            //}



            List<string> final = new List<string>();

            foreach (KeyValuePair<string, int> pair in result)
            {
                if (pair.Value % 2 == 1)
                {
                    final.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", final));
            
        }
    }
}
