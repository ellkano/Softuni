using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SplitWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.', ':', ';', '!', '(', ')', '[', ']', '/', '\\', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> upperCase = new List<string>();
            List<string> middleCase = new List<string>();
            List<string> lowerCase = new List<string>();

            //bool isLower = false;
            //bool isUpper = false;
            //bool isMixed = false;

            foreach (string word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {

                    if (IsAllLower(word))
                    {
                        lowerCase.Add(word);
                        break;
                    }

                    else if (IsAllUpper(word))
                    {
                        upperCase.Add(word);
                        break;
                    }
                    else
                    {
                        middleCase.Add(word);
                        break;
                    }

                    //if (word.ToLower().Equals(word))
                    //{
                    //    lowerCase.Add(word);
                    //    break;
                    //}

                    //else if (word.ToUpper().Equals(word))
                    //{
                    //    upperCase.Add(word);
                    //    break;
                    //}

                    //else
                    //{
                    //    middleCase.Add(word);
                    //    break;
                    //}
                }
                //if (isLower)
                //{
                //    lowerCase.Add(word);
                //}
                //else if (isUpper)
                //{
                //    upperCase.Add(word);
                //}

                //else if (isMixed)
                //{
                //    middleCase.Add(word);
                //}
            }

            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", middleCase));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCase));
        }

        public static bool IsAllUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsUpper(input[i]))
                    return false;
            }

            return true;
        }

        public static bool IsAllLower(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLower(input[i]))
                    return false;
            }

            return true;
        }

    }
}
